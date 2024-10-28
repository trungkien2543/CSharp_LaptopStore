using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class PhieuNhapGUI : Form
    {
        public PhieuNhapGUI()
        {
            InitializeComponent();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi
        }

        private void them_but_Click(object sender, EventArgs e)
        {

        }

        private void sua_but_Click(object sender, EventArgs e)
        {

        }

        private void tim_but_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {

        }

        private void them_but_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
