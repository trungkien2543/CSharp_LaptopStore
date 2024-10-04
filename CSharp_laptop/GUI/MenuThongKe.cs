using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class MenuThongKe : Form
    {
        public MenuThongKe()
        {
            InitializeComponent();
            // Sự kiện khi di chuột vào button
            button1.MouseEnter += (s, e) =>
            {
                button1.BackColor = Color.DodgerBlue;  // Thay đổi màu nền khi di chuột vào
                button1.ForeColor = Color.Yellow;      // Thay đổi màu chữ khi di chuột vào
            };

            // Sự kiện khi chuột rời khỏi button
            button1.MouseLeave += (s, e) =>
            {
                button1.BackColor = Color.LightBlue;   // Trả về màu nền ban đầu
                button1.ForeColor = Color.White;       // Trả về màu chữ ban đầu
            };

            // Sự kiện Click
            button1.Click += button1_Click;

            // Thêm sự kiện Paint để bo góc button
            button1.Paint += new PaintEventHandler(Button1_Paint);
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            // Tạo GraphicsPath để vẽ button bo góc
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 20; // Độ bo góc

            // Lấy button hiện tại
            Button btn = sender as Button;

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.CloseFigure();

            // Đặt vùng của button thành đường bo góc
            btn.Region = new Region(path);

            // Vẽ nền của button
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(btn.BackColor), path);

            // Vẽ text của button
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Tạo một instance của form mới
            ThongKe newForm = new ThongKe();

            // Hiển thị form mới
            newForm.Show();

            // Ẩn form hiện tại
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
