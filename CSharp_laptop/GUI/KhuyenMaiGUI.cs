using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using Org.BouncyCastle.Utilities;
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
        private KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();
        public KhuyenMaiGUI()
        {
            InitializeComponent();
            loadData();
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

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
            //tabControl1.SelectedIndex = 1;
            DateTime ngaySinh = DateTime.MinValue;
            MessageBox.Show("Đây là thông báo đơn giản."+ ngaySinh);

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

        private void dong_y_but_Click(object sender, EventArgs e)
        {
            KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO();
            {
                //idKM = rjTextBox1.Texts, 
                //TenHang = rjTextBox2.Texts, 
                //DiaChi = rjTextBox3.Texts, 
                //SDT = rjTextBox4.Texts
            }
        }

        private void loadData()
        {
            List<KhuyenMaiDTO> khuyenMai = khuyenMaiBUS.getKhuyenMaiArr();
            KM_dataGridView.DataSource = khuyenMai;
        }
    }
}
