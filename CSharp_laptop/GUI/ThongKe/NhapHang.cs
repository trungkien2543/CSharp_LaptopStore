﻿using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using OxyPlot.Series;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CSharp_laptop.DAO;
using OxyPlot.Axes;

namespace CustomTabControl
{
    public partial class NhapHang : UserControl
    {
        public NhapHang()
        {
            InitializeComponent();
            LoadYearsIntoComboBox(); // Tải năm từ CSDL vào ComboBox
            InitializeChart();
            InitializeStockChart(); // Khởi tạo biểu đồ số lượng tồn kho theo hãng
        }

        private void LoadYearsIntoComboBox()
        {
            // Lấy danh sách các năm có sẵn từ cơ sở dữ liệu
            var years = GetYearsFromDatabase();

            // Xóa các mục hiện có trong ComboBox (nếu có)
            comboBoxYear.Items.Clear();

            // Thêm các năm vào ComboBox
            foreach (var year in years)
            {
                comboBoxYear.Items.Add(year.ToString());
            }

            // Đặt giá trị mặc định là năm đầu tiên trong danh sách nếu có
            if (years.Any())
            {
                comboBoxYear.SelectedItem = years.Last().ToString();
            }

            // Gọi lại InitializeChart khi thay đổi năm
            comboBoxYear.SelectedIndexChanged += (s, e) => InitializeChart();
        }

        private void InitializeChart()
        {
            // Kiểm tra nếu ComboBox chưa được chọn năm thì dừng
            if (comboBoxYear.SelectedItem == null)
                return;

            // Lấy năm đã chọn từ ComboBox
            int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());

            // Lấy dữ liệu từ cơ sở dữ liệu dựa theo năm đã chọn
            var data = GetImportDataFromDatabase(selectedYear);

            // Tìm giá trị lớn nhất trong dữ liệu để đặt trục X tự động
            int maxSoLuongNhap = data.AsEnumerable()
                                      .Select(row => Convert.ToInt32(row["SoLuongNhap"]))
                                      .Max();

            // Tạo model cho biểu đồ
            var plotModel = new PlotModel { Title = "Biểu đồ Nhập Hàng Theo Tháng" };

            // Tạo series Bar (biểu đồ cột)
            var barSeries = new BarSeries
            {
                Title = "Số lượng nhập",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}" // Hiển thị giá trị trên các cột
            };

            // Thêm các giá trị cột vào series
            foreach (DataRow row in data.Rows)
            {
                int soLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
                barSeries.Items.Add(new BarItem { Value = soLuongNhap });
            }

            // Thêm series vào model
            plotModel.Series.Add(barSeries);

            // Thiết lập trục Y (Tháng)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = data.AsEnumerable()
                                  .Select(row => "Tháng " + row["Thang"].ToString())
                                  .ToArray(),
            };
            plotModel.Axes.Add(categoryAxis);

            // Thiết lập trục X (Số lượng nhập) với khoảng giá trị tối đa động
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = maxSoLuongNhap + 2, // Thêm một khoảng nhỏ để tránh cột đụng sát trục
                Title = "Số lượng nhập"
            };
            plotModel.Axes.Add(valueAxis);

            // Gán PlotModel vào PlotView
            plotView1.Model = plotModel;
        }

        // Hàm lấy dữ liệu nhập hàng từ cơ sở dữ liệu theo năm
        private DataTable GetImportDataFromDatabase(int year)
        {
            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        MONTH(NgayNhap) AS Thang, 
                        COUNT(IMEI) AS SoLuongNhap
                    FROM PhieuNhap
                    JOIN ChiTietPhieuNhap ON PhieuNhap.ID_PhieuNhap = ChiTietPhieuNhap.ID_PhieuNhap
                    WHERE YEAR(NgayNhap) = @SelectedYear
                    GROUP BY MONTH(NgayNhap)
                    ORDER BY Thang";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SelectedYear", year);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Hàm lấy danh sách năm có trong cơ sở dữ liệu
        private List<int> GetYearsFromDatabase()
        {
            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
            List<int> years = new List<int>();

            using (var connection = connectionHelper.GetConnection())
            {
                string query = @"
                    SELECT DISTINCT YEAR(NgayNhap) AS Year
                    FROM PhieuNhap
                    ORDER BY Year";

                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    years.Add(reader.GetInt32("Year"));
                }

                connection.Close();
            }

            return years;
        }

        //Thong ke 2
        private void InitializeStockChart()
        {
            // Lấy dữ liệu tồn kho từ cơ sở dữ liệu
            var data = GetStockDataFromDatabase();

            // Tìm giá trị lớn nhất trong dữ liệu để đặt trục X tự động
            int maxSoLuongTon = data.AsEnumerable()
                                    .Select(row => Convert.ToInt32(row["SoLuongTon"]))
                                    .Max();

            // Tạo model cho biểu đồ
            var plotModel = new PlotModel { Title = "Số Lượng Tồn Kho Theo Hãng" };

            // Tạo series Bar (biểu đồ cột)
            var barSeries = new BarSeries
            {
                Title = "Số lượng tồn",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}" // Hiển thị giá trị trên các cột
            };

            // Thêm các giá trị cột vào series
            foreach (DataRow row in data.Rows)
            {
                int soLuongTon = Convert.ToInt32(row["SoLuongTon"]);
                barSeries.Items.Add(new BarItem { Value = soLuongTon });
            }

            // Thêm series vào model
            plotModel.Series.Add(barSeries);

            // Thiết lập trục Y (Hãng sản xuất)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = data.AsEnumerable()
                                  .Select(row => row["TenHang"].ToString())
                                  .ToArray(),
                Title = "Hãng", // Thêm nhãn "Hãng" cho trục Y
                AxisTitleDistance = 10 
            };
            plotModel.Axes.Add(categoryAxis);

            // Thiết lập trục X (Số lượng tồn kho)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = maxSoLuongTon + 2, // Thêm một khoảng nhỏ để tránh các cột đụng sát trục
                Title = "Số lượng tồn kho"
            };
            plotModel.Axes.Add(valueAxis);

            // Gán PlotModel vào PlotView
            plotView2.Model = plotModel;
        }

        private DataTable GetStockDataFromDatabase()
        {
            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                string query = @"
                SELECT 
                    HangSanXuat.TenHang,
                    COUNT(Laptop.IMEI) AS SoLuongTon
                FROM Laptop
                JOIN LoaiLaptop ON Laptop.LoaiLaptop = LoaiLaptop.IDLoaiLaptop
                JOIN HangSanXuat ON LoaiLaptop.Hang = HangSanXuat.ID_Hang
                WHERE Laptop.TrangThai = 1 
                GROUP BY HangSanXuat.TenHang";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
    }
}