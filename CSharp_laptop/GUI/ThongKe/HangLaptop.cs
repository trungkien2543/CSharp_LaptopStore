using CSharp_laptop.DAO;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using MySql.Data.MySqlClient;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTabControl
{
    public partial class HangLaptop : UserControl
    {
        public HangLaptop()
        {
            InitializeComponent();
            //Load dữ liệu sẵn cho TK2
            LoadComboBoxHang();
            dateTimePicker1.Value = DateTime.Now.AddMonths(-12); // Ví dụ: Ngày cách đây 1 tháng
            dateTimePicker2.Value = DateTime.Now;
            string selectedBrand = ccbHang.SelectedItem.ToString();
            LoadPieChartData(dateTimePicker1.Value, dateTimePicker2.Value,selectedBrand);
            LoadGridViewData(dateTimePicker1.Value, dateTimePicker2.Value,selectedBrand);
        }

        private void LoadComboBoxHang()
        {
            ccbHang.Items.Clear();
            ccbHang.Items.Add("Tất cả"); // Thêm tùy chọn "Tất cả"

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand(
                    "SELECT DISTINCT TenHang FROM hangsanxuat;", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ccbHang.Items.Add(reader.GetString("TenHang")); // Thêm từng hãng vào ComboBox
                    }
                }
            }

            ccbHang.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }

        // Hàm thống kê số lượng bán chạy theo các hãng
        private void LoadPieChartData(DateTime fromDate, DateTime toDate, string selectedBrand)
        {
            var brands = new List<string>();
            var quantities = new List<int>();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                string query;
                if (selectedBrand == "Tất cả")
                {
                    // Truy vấn thống kê theo tên hãng
                    query = @"SELECT hangsanxuat.TenHang, COUNT(*) AS SoLuongBan FROM chitiethoadon 
                  INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                  INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                  INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                  INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                  WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate
                  GROUP BY hangsanxuat.TenHang;";
                }
                else
                {
                    // Truy vấn thống kê theo tên sản phẩm
                    query = @"SELECT loailaptop.TenSP, COUNT(*) AS SoLuongBan FROM chitiethoadon 
                  INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                  INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                  INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                  INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                  WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate
                    AND hangsanxuat.TenHang = @selectedBrand
                  GROUP BY loailaptop.TenSP;";
                }

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                if (selectedBrand != "Tất cả")
                {
                    command.Parameters.AddWithValue("@selectedBrand", selectedBrand);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        brands.Add(reader.GetString(0)); // Tên hãng hoặc tên sản phẩm
                        quantities.Add(reader.GetInt32(1)); // Số lượng bán
                    }
                }
            }



            // Cập nhật Pie Chart với dữ liệu lấy được
            var pieSeries = new List<PieSeries<int>>();

            for (int i = 0; i < brands.Count; i++)
            {
                pieSeries.Add(new PieSeries<int>
                {
                    Values = new int[] { quantities[i] }, // Giá trị số lượng
                    Name = brands[i],  // Tên hãng hiển thị trong chú thích
                    Stroke = new SolidColorPaint(SKColors.White) { StrokeThickness = 2 },
                    Fill = new SolidColorPaint(SKColor.Parse(GetRandomColor())), // Màu ngẫu nhiên cho mỗi hãng
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black), // Màu của nhãn dữ liệu
                    DataLabelsSize = 14, // Kích thước nhãn
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle // Vị trí nhãn
                });
            }

            pieChart1.Series = pieSeries.ToArray(); // Gán dữ liệu vào biểu đồ Pie Chart

            // Hiển thị chú thích cho các phần của Pie Chart với tên hãng
            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;

            pieChart1.Update(); // Cập nhật biểu đồ
        }

        // Hàm để tạo màu ngẫu nhiên cho từng PieSeries
        private string GetRandomColor()
        {
            Random rand = new Random();
            return $"#{rand.Next(0x1000000):X6}"; // Tạo chuỗi màu dạng Hex (ví dụ: #AABBCC)
        }


        // Hàm để tải dữ liệu vào DataGridView
        private void LoadGridViewData(DateTime fromDate, DateTime toDate, string selectedBrand)
        {
            var dataTable = new DataTable();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                string query;

                if (selectedBrand == "Tất cả")
                {
                    // Thống kê theo hãng
                    query = @"SELECT hangsanxuat.TenHang, COUNT(*) AS SoLuongBan, SUM(hoadon.TongTien) AS DoanhThu 
                      FROM chitiethoadon 
                      INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                      INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                      INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                      INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                      WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate 
                      GROUP BY hangsanxuat.TenHang;";
                }
                else
                {
                    // Thống kê theo sản phẩm thuộc hãng cụ thể
                    query = @"SELECT loailaptop.TenSP, COUNT(*) AS SoLuongBan, SUM(hoadon.TongTien) AS DoanhThu 
                      FROM chitiethoadon 
                      INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                      INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                      INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                      INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                      WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate 
                        AND hangsanxuat.TenHang = @selectedBrand
                      GROUP BY loailaptop.TenSP;";
                }

                var command = new MySqlCommand(query, connection);

                // Thêm tham số
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                if (selectedBrand != "Tất cả")
                {
                    command.Parameters.AddWithValue("@selectedBrand", selectedBrand);
                }

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable); // Điền dữ liệu vào DataTable
                }
            }

            // Cập nhật DataGridView
            dataGridView1.DataSource = dataTable;

            // Đổi tên cột sau khi gán nguồn dữ liệu
            if (selectedBrand == "Tất cả")
            {
                // Khi chọn "Tất cả", hiển thị tên hãng
                dataGridView1.Columns["TenHang"].HeaderText = "Tên Hãng";
            }
            else
            {
                // Khi chọn hãng cụ thể, hiển thị tên sản phẩm
                dataGridView1.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            }

            dataGridView1.Columns["SoLuongBan"].HeaderText = "Số Lượng Bán";
            dataGridView1.Columns["DoanhThu"].HeaderText = "Doanh Thu";
        }


        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string selectedBrand = ccbHang.SelectedItem.ToString();

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi hàm LoadPieChartData để cập nhật biểu đồ với khoảng thời gian đã chọn
            LoadPieChartData(startDate, endDate,selectedBrand);
            // Gọi hàm LoadGridViewData để cập nhật DataGridView với dữ liệu mới
            LoadGridViewData(startDate, endDate, selectedBrand);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HangLaptop_Load(object sender, EventArgs e)
        {

        }

        private void ccbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = ccbHang.SelectedItem.ToString();
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            LoadPieChartData(fromDate, toDate, selectedBrand);
            LoadGridViewData(fromDate, toDate, selectedBrand);
        }
    }
}
