using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.BanHang
{
    public partial class BanHangForm : Form
    {

        MainForm mainForm;
        public BanHangForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }

        private void btnThemThongTin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabThanhToan;
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabGioHang;
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
