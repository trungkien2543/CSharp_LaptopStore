using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class KhuyenMaiGUI : Form
    {
        public KhuyenMaiGUI()
        {
            InitializeComponent();
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {

            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

            //panel3.Visible = false;
            //panel2.Location = new Point(10, 125);

        }

        private void button1_Click(object sender, EventArgs e)// Thêm
        {
            //// Chuyển sang tabcontrol 1 
            //panel3.Visible = false;
            //tabControl1.SelectedIndex = 1;

            //Point currentLocation = panel2.Location;// Lấy vị trí hiện tại
            //panel2.Location = new Point(currentLocation.X, currentLocation.Y - 40);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)// Sửa
        {
            //panel3.Visible = true;
            //tabControl1.SelectedIndex = 1;
            //Point currentLocation = panel2.Location;// Lấy vị trí hiện tại
            //panel2.Location = new Point(currentLocation.X, currentLocation.Y + 40);
        }

        private void xoa_but_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

        }

        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
