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
using LiveChartsCore.SkiaSharpView.WinForms;

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
                ccbYear.SelectedIndex = ccbYear.Items.Count - 1; // Chọn mặc định là năm cuối cùng trong danh sách
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


        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

        // Hàm thống kê số lượng bán chạy theo các hãng
        private void LoadPieChartData(DateTime fromDate, DateTime toDate)
        {
            var brands = new List<string>();
            var quantities = new List<int>();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                // Câu truy vấn lấy số lượng sản phẩm bán chạy theo hãng trong khoảng thời gian từ 'fromDate' đến 'toDate'
                var command = new MySqlCommand(
                    @"SELECT hangsanxuat.TenHang, COUNT(*) AS SoLuongBan FROM chitiethoadon 
                    INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                    INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                    INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                    INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                    WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate 
                    GROUP BY hangsanxuat.TenHang;", connection);

                // Thêm tham số ngày bắt đầu và ngày kết thúc vào truy vấn
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string brand = reader.GetString("TenHang");
                        int quantity = reader.GetInt32("SoLuongBan");

                        brands.Add(brand);  // Lưu tên hãng
                        quantities.Add(quantity);  // Lưu số lượng
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi hàm LoadPieChartData để cập nhật biểu đồ với khoảng thời gian đã chọn
            LoadPieChartData(startDate, endDate);
            // Gọi hàm LoadGridViewData để cập nhật DataGridView với dữ liệu mới
            LoadGridViewData(startDate, endDate);
        }

        // Hàm để tải dữ liệu vào DataGridView
        private void LoadGridViewData(DateTime fromDate, DateTime toDate)
        {
            var dataTable = new DataTable();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                var command = new MySqlCommand(
                    @"SELECT hangsanxuat.TenHang, COUNT(*) AS SoLuongBan, SUM(hoadon.TongTien) AS DoanhThu FROM chitiethoadon 
                    INNER JOIN laptop ON chitiethoadon.IMEI = laptop.IMEI
                    INNER JOIN loailaptop ON loailaptop.IDLoaiLaptop = laptop.LoaiLaptop
                    INNER JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon 
                    INNER JOIN hangsanxuat ON loailaptop.Hang = hangsanxuat.ID_Hang 
                    WHERE hoadon.NgayLap BETWEEN @fromDate AND @toDate 
                    GROUP BY hangsanxuat.TenHang;", connection);


                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable); // Điền dữ liệu vào DataTable
                }
            }

            // Cập nhật DataGridView
            dataGridView1.DataSource = dataTable; // Gán DataTable làm nguồn dữ liệu cho DataGridView
            // Đổi tên cột sau khi gán nguồn dữ liệu
            dataGridView1.Columns["TenHang"].HeaderText = "Tên Hãng ";
            dataGridView1.Columns["SoLuongBan"].HeaderText = "Số Lượng Bán";
            dataGridView1.Columns["DoanhThu"].HeaderText = "Doanh thu";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
