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
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

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

            if (!string.IsNullOrEmpty(label12.Text))
            {
                pictureBox1.Image = Image.FromFile(label12.Text);
            }

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

            dataGridView2.Columns["IMEI"].HeaderText = "Mã IMEI";
            dataGridView2.Columns["ThoiGianBaoHanh"].HeaderText = "Thời gian bảo hành";
            dataGridView2.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView2.Columns["LoaiLaptop"].HeaderText = "Loại Laptop";
        }

        private void LoadLaptops(string loaiLaptop)
        {
            List<LaptopDTO> laptops = laptopBUS.GetLaptopsByLoai(loaiLaptop);
            dataGridView2.DataSource = laptops;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            string searchTerm = rjTextBox1.Texts.Trim(); // Lấy từ TextBox
            DataTable result = laptopBUS.SearchLaptop(searchTerm, laptopID); // Gọi BUS để tìm kiếm
            dataGridView2.DataSource = result;
        }

        private void dataGridView2_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                e.Value = (int)e.Value == 0 ? "Đã bán" : "Chưa bán";
                e.FormattingApplied = true;
            }
        }
    }
}
