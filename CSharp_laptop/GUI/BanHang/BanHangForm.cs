using CSharp_laptop.BUS;
using CSharp_laptop.GUI.Laptop;
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

namespace CSharp_laptop.GUI.BanHang
{
    public partial class BanHangForm : Form
    {
        private LoaiLaptopBUS laptopBUS = new LoaiLaptopBUS();
        string selectedLaptopID;
        MainForm mainForm;
        public BanHangForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadLaptops();
            edittable();
            AddButtonsToDataGridView();


  

            // Load dữ liệu cho comboBox
            LoadDataForComboBox(cbxCPU, "CPU");
            LoadDataForComboBox(cbxHang, "TenHang");
            LoadDataForComboBox(cbxRAM, "RAM");
            LoadDataForComboBox(cbxGPU, "GPU");
            LoadDataForComboBox(cbxKichThuoc, "KichThuoc");
        }


        private void edittable()
        {
            dataGridView2.Columns["IDLoaiLaptop"].Visible = false;
            dataGridView2.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dataGridView2.Columns["GiaBan"].HeaderText = "Giá Bán";
            dataGridView2.Columns["Hang"].HeaderText = "Hãng Laptop";
            dataGridView2.Columns["KhuyenMai"].HeaderText = "Khuyến Mãi";

            dataGridView2.Columns["CPU"].HeaderText = "CPU";
            dataGridView2.Columns["RAM"].HeaderText = "RAM";
            dataGridView2.Columns["GPU"].HeaderText = "GPU";
            dataGridView2.Columns["HinhAnh"].Visible = false;
            dataGridView2.Columns["KichThuoc"].HeaderText = "Kích thước";

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void LoadLaptops()
        {
            List<LoaiLaptopDTO> laptops = laptopBUS.GetLaptops();
    

            dataGridView2.DataSource = laptops;


            // Tạo cột mới cho DataGridView
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Name = "NewColumn"; // Đặt tên cột
            newColumn.HeaderText = "New Column"; // Tên hiển thị của cột
            newColumn.ReadOnly = false; // Có thể cho phép chỉnh sửa hoặc không tùy theo nhu cầu

            // Thêm cột mới vào DataGridView
            dataGridView2.Columns.Add(newColumn);
        }

        private void AddButtonsToDataGridView()
        {

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnAdd";
            btnDelete.HeaderText = "Thêm";
            btnDelete.Text = "+";
            btnDelete.Width = 60;
            //btnDelete.Image = Image.FromFile("path-to-your-delete-icon.png"); // Đường dẫn tới icon xóa
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnDelete);
        }



        private void LoadDataForComboBox(ComboBox comboBox, String Item)
        {
            List<String> strings = new List<String>();
            strings.Add("");
            strings.AddRange(new LoaiLaptopBUS().getValueForComboBox(Item));

            comboBox.DataSource = strings;
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

        private void cbxKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSoTien_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSoSanPham_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            
            if (txtTenSP.Texts == "Nhập tên sản phẩm")
            {
                txtTenSP.Texts = "";
                txtTenSP.ForeColor = Color.Black; // Đổi màu chữ về màu bình thường
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTenSP.Texts))
            {
                txtTenSP.Texts = "Nhập tên sản phẩm"; // Văn bản hint
                txtTenSP.ForeColor = Color.Gray; // Đổi màu chữ sang màu xám
            }
        }

    }
}
