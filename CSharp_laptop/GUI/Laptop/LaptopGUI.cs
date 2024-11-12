using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
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
        private LoaiLaptopBUS sanPhamBUS = new LoaiLaptopBUS();
        private LaptopBUS laptopBUS = new LaptopBUS();


        public LaptopGUI(string laptopID, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.laptopID = laptopID;



            LoaiLaptopDTO sanPhamDTO = sanPhamBUS.GetLaptopByID(laptopID);

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

            LoadLaptops(laptopID);
            edittable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new LoaiLaptopGUI(mainForm));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BaoHanhGUI(mainForm));
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new LoaiLaptopGUI(mainForm));
        }

        private void edittable()
        {

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        private void LoadLaptops(string loaiLaptop)
        {
            List<LaptopDTO> laptops = laptopBUS.GetLaptopsByLoai(loaiLaptop);
            dataGridView2.DataSource = laptops;
        }
    }
}
