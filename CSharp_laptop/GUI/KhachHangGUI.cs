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
    public partial class KhachHangGUI : Form
    {
        public KhachHangGUI()
        {
            InitializeComponent();
            edittable();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void edittable()
        {
            dataGridView1.Columns["IDLaptop"].HeaderText = "Mã Laptop";
            dataGridView1.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá Niêm Yết";
            dataGridView1.Columns["Hang"].HeaderText = "Hãng Laptop";
            dataGridView1.Columns["KhuyenMai"].HeaderText = "Khuyến Mãi";

            dataGridView1.Columns["CPU"].Visible = false;
            dataGridView1.Columns["RAM"].Visible = false;
            dataGridView1.Columns["GPU"].Visible = false;
            dataGridView1.Columns["HinhAnh"].Visible = false;
            dataGridView1.Columns["KichThuoc"].Visible = false;

            dataGridView1.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng


            dataGridView1.Columns["IDLaptop"].Width = 100;  // Điều chỉnh chiều rộng
            dataGridView1.Columns["TenSP"].Width = 150;
            dataGridView1.Columns["GiaBan"].Width = 100;
            dataGridView1.Columns["Hang"].Width = 100;
            dataGridView1.Columns["KhuyenMai"].Width = 200;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }
        private void AddButtonsToDataGridView()
        {
            // Thêm cột nút "Sửa"
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏️";
            btnEdit.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            dataGridView1.Columns.Add(btnEdit);

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            //btnDelete.Image = Image.FromFile("path-to-your-delete-icon.png"); // Đường dẫn tới icon xóa
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            dataGridView1.Columns.Add(btnDelete);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
