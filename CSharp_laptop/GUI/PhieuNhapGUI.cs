using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
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
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        private BindingList<PhieuNhapDTO> phieuNhapList;
        public PhieuNhapGUI()
        {
            InitializeComponent();
   
        }

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

            LoadPhieuNhapData();
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

        private void them_but_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void them_sp_pn_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        //private void tabControl1_Resize(object sender, EventArgs e)
        //{
        //    panel6.Width = (int)(tabPage2.Width * 0.4); // 40% của Panel Main
        //    panel7.Width = (int)(tabPage2.Width * 0.6); // 60% của Panel Main
        //}

        private void tabPage2_Resize(object sender, EventArgs e)
        {

            panel6.Width = (int)(tabPage2.Width * 0.4); // 40% của Panel Main
            panel7.Width = (int)(tabPage2.Width * 0.6); // 60% của Panel Main
            //km_pan.Width = 600;

        }

        private void huy_but_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void them_sp_but_Click(object sender, EventArgs e)
        {
            sp_box.Visible = true;
            //km_box.Visible = false;

        }

        private void but_trolai_Click(object sender, EventArgs e)
        {
            sp_box.Visible = false;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPhieuNhapData()
        {
            phieuNhapList = phieuNhapBUS.GetAllPhieuNhap();
            //MessageBox.Show("abc" + phieuNhapList[0].ID);
            dataGridView_PN.DataSource = phieuNhapList;
        }
    }
}
