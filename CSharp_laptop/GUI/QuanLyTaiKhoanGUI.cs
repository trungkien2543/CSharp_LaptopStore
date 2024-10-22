using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
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

namespace CSharp_laptop.GUI
{
    public partial class QuanLyTaiKhoanGUI : Form
    {
        private TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        private MainForm mainForm;
        string selectedTK;
        string soluong_tk;
        public QuanLyTaiKhoanGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();     
            LoadTaiKhoan();
            AddButtonsToDataGridView();
            edittable();
        }

        private void LoadTaiKhoan()
        {

            List<TaiKhoanDTO> tk = TaiKhoanBUS.GetAllTaiKhoan();
            soluong_tk = (1 + tk.Count).ToString();

            dataGridView1.DataSource = tk;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateTaiKhoanGUI(mainForm));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idLaptop = row.Cells["TenDN"].Value.ToString();
                selectedTK = idLaptop;

            }

            if (e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                //mainForm.OpenChildForm(new EditSanPham(selectedTK, "Sửa sản phẩm", mainForm));
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm với ID: {selectedTK}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

              
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnThem"].Index && e.RowIndex >= 0)
            {
                //mainForm.OpenChildForm(new QuanLyTaiKhoanGUI(selectedTK, mainForm));
            }
        }
        private void AddButtonsToDataGridView()
        {
            DataGridViewButtonColumn btnThem = new DataGridViewButtonColumn();
            btnThem.Name = "btnThem";
            btnThem.HeaderText = "Thêm";
            btnThem.Text = "+";
            btnThem.Width = 60;
            btnThem.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnThem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnThem);
            // Thêm cột nút "Sửa"
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏️";
            btnEdit.Width = 60;
            btnEdit.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnEdit);

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.Width = 60;
            //btnDelete.Image = Image.FromFile("path-to-your-delete-icon.png"); // Đường dẫn tới icon xóa
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnDelete);


            
        }
        private void edittable()
        {
            dataGridView1.Columns["TenDN"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["Matkhau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["Quyen"].HeaderText = "Quyền";

            dataGridView1.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }
    }
}
