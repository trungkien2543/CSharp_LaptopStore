using CSharp_laptop.BUS;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.Laptop
{
    public partial class LaptopGUI : Form
    {
        private MainForm mainForm;
        private string laptopID;
        private SanPhamBUS sanPhamBUS = new SanPhamBUS();

        public LaptopGUI(string laptopID, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.laptopID = laptopID;



            SanPhamDTO sanPhamDTO = sanPhamBUS.GetLaptopByID(laptopID);

            label13.Text = laptopID;
            label2.Text = sanPhamDTO.TenSP;
            label15.Text = sanPhamDTO.GiaBan.ToString();
            label14.Text = sanPhamDTO.Hang;
            label19.Text = sanPhamDTO.GPU;
            label16.Text = sanPhamDTO.CPU;
            label17.Text = sanPhamDTO.RAM.ToString();
            label18.Text = sanPhamDTO.KichThuoc;
            label12.Text = sanPhamDTO.HinhAnh;
            label20.Text = sanPhamDTO.KhuyenMai;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BaoHanhGUI(mainForm));
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }
    }
}
