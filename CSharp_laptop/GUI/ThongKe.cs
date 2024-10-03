using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting;
using MySql.Data.MySqlClient;
using CSharp_laptop.DAO;

namespace CSharp_laptop.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            LoadYears();
        }

        // Hàm để điền các năm vào ComboBox
        private void LoadYears()
        {
            // Xóa các mục cũ nếu có
            ccbYear.Items.Clear();

            // Sử dụng MySqlConnectionHelper để kết nối CSDL
            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                // Truy vấn để lấy danh sách các năm có trong bảng hoadon
                var command = new MySqlCommand("SELECT DISTINCT YEAR(NgayLap) AS Nam FROM hoadon ORDER BY Nam;", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy giá trị năm từ kết quả truy vấn và thêm vào ComboBox
                        int year = reader.GetInt32("Nam");
                        ccbYear.Items.Add(year.ToString());
                    }
                }
            }

            // Kiểm tra xem ComboBox có mục nào không
            if (ccbYear.Items.Count > 0)
            {
                ccbYear.SelectedIndex = 0; // Chọn mặc định là năm đầu tiên trong danh sách
            }
            else
            {
                MessageBox.Show("Không có dữ liệu năm nào trong cơ sở dữ liệu!");
            }
        }

        // Hàm cập nhật biểu đồ với năm được chọn
        private void LoadChartData(string year)
        {
            var months = new List<string>();
            var revenue = new List<double>();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                // Cập nhật câu truy vấn để chỉ thống kê theo năm đã chọn
                var command = new MySqlCommand($"SELECT MONTH(NgayLap) AS Thang, SUM(TongTien) AS DoanhThu FROM hoadon WHERE YEAR(NgayLap) = @year GROUP BY MONTH(NgayLap) ORDER BY Thang;", connection);
                command.Parameters.AddWithValue("@year", year); // Sử dụng parameter để tránh SQL Injection

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32("Thang");
                        months.Add("Tháng " + month.ToString());
                        revenue.Add(reader.GetDouble("DoanhThu"));
                    }
                }
            }

            // Cập nhật biểu đồ với dữ liệu lấy được
            var series = new LineSeries<double>
            {
                Values = revenue,
                Name = "Doanh Thu:",
                Stroke = new SolidColorPaint(new SkiaSharp.SKColor(0, 176, 240)),
                Fill = null
            };

            cartesianChart1.Series = new ISeries[] { series };

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis { Labels = months.ToArray() }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Doanh Thu (VNĐ)"
                }
            };

            cartesianChart1.Update();
        }


        private void cartesianChart1_Load(object sender, EventArgs e)
        {           
            // Lấy năm được chọn
            string selectedYear = ccbYear.SelectedItem.ToString();

            // Gọi hàm cập nhật biểu đồ với năm được chọn
            LoadChartData(selectedYear);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy năm được chọn
            string selectedYear = ccbYear.SelectedItem.ToString();

            // Gọi hàm cập nhật biểu đồ với năm được chọn
            LoadChartData(selectedYear);
        }
    }
}
