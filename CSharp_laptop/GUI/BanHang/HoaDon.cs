using CSharp_laptop.GUI.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharp_laptop.GUI.BanHang;

namespace CSharp_laptop.GUI
{
    public partial class HoaDon : Form
    {

        MainForm mainForm;


        public HoaDon(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BanHangForm(mainForm));
        }
    }
}
