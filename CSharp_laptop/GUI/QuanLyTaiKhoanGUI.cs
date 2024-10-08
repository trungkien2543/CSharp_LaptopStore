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
    public partial class QuanLyTaiKhoanGUI : Form
    {
        private TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        private MainForm mainForm;
        public QuanLyTaiKhoanGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            LoadTaiKhoan();
            dataGridView1.Columns[1].Width = 280;
            dataGridView1.Columns[2].Width = 280;
        }

        private void LoadTaiKhoan()
        {

            List<TaiKhoanDTO> accs = TaiKhoanBUS.GetAllTaiKhoan();
            dataGridView1.DataSource = accs;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateTaiKhoanGUI());
        }
    }
}
