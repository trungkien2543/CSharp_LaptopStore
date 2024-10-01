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

namespace CSharp_laptop.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu
            var months = new List<string>();
            var revenue = new List<double>();

            // Thay thế chuỗi kết nối dưới đây bằng thông tin kết nối của bạn
            string connectionString = "server=localhost;database=laptop_csharp;user=root;password=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT MONTH(NgayLap) AS Thang, SUM(TongTien) AS DoanhThu FROM hoadon GROUP BY MONTH(NgayLap) ORDER BY Thang;", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy giá trị tháng dưới dạng số nguyên
                        int month = reader.GetInt32("Thang");

                        // Chuyển đổi sang chuỗi
                        months.Add("Tháng " + month.ToString());

                        // Lấy giá trị doanh thu
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
