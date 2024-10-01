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
            // Giả sử bạn có dữ liệu doanh thu cho từng tháng
            var months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var revenue = new double[] { 2000000, 2500000, 3000000, 4000000, 3500000, 4500000, 3000000, 5000000, 5500000, 6000000, 7000000, 8000000 };

            // Tạo một series mới cho doanh thu
            var series = new LineSeries<double>
            {
                Values = revenue,
                Name = "Doanh Thu",
                Stroke = new SolidColorPaint(new SKColor(0, 176, 240)), // Màu đường
                Fill = null
            };

            // Thêm series vào biểu đồ
            cartesianChart1.Series = new ISeries[] { series };

            // Thiết lập các nhãn cho trục X
            cartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = months // Nhãn cho trục X
        }
            };

            // Thiết lập trục Y
            cartesianChart1.YAxes = new Axis[]
            {
        new Axis
        {
            Name  = "Doanh Thu (VNĐ)", // Tiêu đề cho trục Y
        }
            };

            // Cập nhật biểu đồ
            cartesianChart1.Update();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
