using CSharp_laptop.BUS;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class EditSanPham : Form
    {
        private SanPhamBUS sanPhamBUS = new SanPhamBUS();
        string function;
        public EditSanPham()
        {
            InitializeComponent();
        }

        public EditSanPham(string idLaptop, string tenSP, string giaBan, string hang, string cpu, string ram, string gpu, string hinhAnh, string kichThuoc, string khuyenMai, string chucnang)
        {
            InitializeComponent();

            textBox1.Text = idLaptop;
            textBox2.Text = tenSP;
            textBox3.Text = giaBan;
            comboBox1.Text = hang;
            textBox4.Text = gpu;
            textBox5.Text = cpu;
            textBox6.Text = ram;
            textBox7.Text = kichThuoc;
            textBox8.Text = hinhAnh;
            comboBox2.Text = khuyenMai;
            label1.Text = chucnang;
            function = chucnang;

        }

        public EditSanPham(string idLaptop, string chucnang)
        {
            InitializeComponent();
            SanPhamDTO sanPhamDTO = sanPhamBUS.GetLaptopByID(idLaptop);

            textBox1.Text = sanPhamDTO.IDLaptop;
            textBox2.Text = sanPhamDTO.TenSP;
            textBox3.Text = sanPhamDTO.GiaBan.ToString();
            comboBox1.Text = sanPhamDTO.Hang;
            textBox4.Text = sanPhamDTO.GPU;
            textBox5.Text = sanPhamDTO.CPU;
            textBox6.Text = sanPhamDTO.RAM.ToString();
            textBox7.Text = sanPhamDTO.KichThuoc;
            textBox8.Text = sanPhamDTO.HinhAnh;
            comboBox2.Text = sanPhamDTO.KhuyenMai;
            label1.Text = chucnang;
            function = chucnang;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPhamDTO laptop = new SanPhamDTO
            {
                IDLaptop = textBox1.Text,
                TenSP = textBox2.Text,
                GiaBan = long.Parse(textBox3.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                Hang = comboBox1.Text,
                CPU = textBox5.Text,
                RAM = int.Parse(textBox6.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                GPU = textBox4.Text,
                HinhAnh = textBox8.Text,
                KichThuoc = textBox7.Text,
                KhuyenMai = comboBox2.Text
            };

            bool result = true;


            if (function == null)
            {

                result = sanPhamBUS.AddLaptop(laptop);
                MessageBox.Show("Thêm laptop");
                if (result)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lưu thất bại! Kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa laptop");
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
