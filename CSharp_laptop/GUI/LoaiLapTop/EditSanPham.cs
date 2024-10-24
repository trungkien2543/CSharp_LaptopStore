﻿using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
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
        private MainForm mainForm;
        public EditSanPham()
        {
            InitializeComponent();
            loadcombobox();
        }

        public EditSanPham(string idLaptop, string chucnang, MainForm mainform)
        {
            this.mainForm = mainform;
            InitializeComponent();


            if (chucnang == "add")
            {
                rjTextBox1.Texts = idLaptop;
            }
            else
            {
                SanPhamDTO sanPhamDTO = sanPhamBUS.GetLaptopByID(idLaptop);

                rjTextBox1.Texts = sanPhamDTO.IDLaptop;
                rjTextBox2.Texts = sanPhamDTO.TenSP;
                rjTextBox3.Texts = sanPhamDTO.GiaBan.ToString();
                rjTextBox4.Texts = sanPhamDTO.GPU;
                rjTextBox5.Texts = sanPhamDTO.CPU;
                rjTextBox6.Texts = sanPhamDTO.RAM.ToString();
                rjTextBox7.Texts = sanPhamDTO.KichThuoc;
                rjTextBox8.Texts = sanPhamDTO.HinhAnh;


                comboBox1.Text = sanPhamDTO.Hang;
                comboBox2.Text = sanPhamDTO.KhuyenMai;
                label1.Text = chucnang;
            }
            function = chucnang;
            loadcombobox();
        }

        private void loadcombobox()
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");

            comboBox2.Items.Add("KM001");
            comboBox2.Items.Add("KM002");
            comboBox2.Items.Add("KM003");
            comboBox2.Items.Add("KM004");
            comboBox2.Items.Add("KM005");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SanPhamDTO laptop = new SanPhamDTO
            {
                IDLaptop = rjTextBox1.Text,
                TenSP = rjTextBox2.Text,
                GiaBan = long.Parse(rjTextBox3.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                Hang = comboBox1.Text,
                CPU = rjTextBox5.Text,
                RAM = int.Parse(rjTextBox6.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                GPU = rjTextBox4.Text,
                HinhAnh = rjTextBox8.Text,
                KichThuoc = rjTextBox7.Text,
                KhuyenMai = comboBox2.Text
            };

//            IDLaptop = textBox1.Text,
//TenSP = textBox2.Text,
//GiaBan = long.Parse(textBox3.Text),  // Chuyển đổi từ chuỗi sang số nguyên
//Hang = comboBox1.Text,
//CPU = textBox5.Text,
//RAM = int.Parse(textBox6.Text),  // Chuyển đổi từ chuỗi sang số nguyên
//GPU = textBox4.Text,
//HinhAnh = textBox8.Text,
//KichThuoc = textBox7.Text,
//KhuyenMai = comboBox2.Text

            bool result = true;


            if (function == "add")
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            SanPhamDTO laptop = new SanPhamDTO
            {
                IDLaptop = rjTextBox1.Texts,
                TenSP = rjTextBox2.Texts,
                GiaBan = long.Parse(rjTextBox3.Texts),  // Chuyển đổi từ chuỗi sang số nguyên
                Hang = comboBox1.Text,
                CPU = rjTextBox5.Texts,
                RAM = int.Parse(rjTextBox6.Texts),  // Chuyển đổi từ chuỗi sang số nguyên
                GPU = rjTextBox4.Text,
                HinhAnh = rjTextBox8.Texts,
                KichThuoc = rjTextBox7.Texts,
                KhuyenMai = comboBox2.Text

            };


            //IDLaptop = textBox1.Text,
            //    TenSP = textBox2.Text,
            //    GiaBan = long.Parse(textBox3.Text),  // Chuyển đổi từ chuỗi sang số nguyên
            //    Hang = comboBox1.Text,
            //    CPU = textBox5.Text,
            //    RAM = int.Parse(textBox6.Text),  // Chuyển đổi từ chuỗi sang số nguyên
            //    GPU = textBox4.Text,
            //    HinhAnh = textBox8.Text,
            //    KichThuoc = textBox7.Text,
            //    KhuyenMai = comboBox2.Text

            bool result = true;


            if (function == "add")
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

        private void vbButton2_Click(object sender, EventArgs e)
        {
            //Close();
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }
    }
}
