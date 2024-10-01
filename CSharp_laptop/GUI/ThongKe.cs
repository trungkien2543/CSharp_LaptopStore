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
            // Tạo dữ liệu mẫu
            var values = new double[] { 3, 5, 7, 4, 6 };

            // Tạo một series mới cho biểu đồ
            var series = new LineSeries<double>
            {
                Values = values,
                Name = "Doanh Thu", // Tên series
                Stroke = new SolidColorPaint(new SKColor(255, 0, 0)),
                Fill = null // Không tô màu cho vùng dưới đường
            };

            // Thêm series vào biểu đồ
            cartesianChart1.Series = new ISeries[] { series };

            // Thiết lập các nhãn cho trục X
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5" } // Nhãn cho trục X
                }
            };

            // Thiết lập các nhãn cho trục Y
            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                   Name = "Giá Trị", // Tiêu đề cho trục Y
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
