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
            dateTimePicker1.Value = DateTime.Now.AddMonths(-12); // Ví dụ: Ngày cách đây 1 tháng
            dateTimePicker2.Value = DateTime.Now;
            LoadPieChartData(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadGridViewData(dateTimePicker1.Value, dateTimePicker2.Value);
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

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
