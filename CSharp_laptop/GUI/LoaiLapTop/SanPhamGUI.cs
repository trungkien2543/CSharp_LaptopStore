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

namespace CSharp_laptop.GUI
{
    public partial class SanPhamGUI : Form
    {

        private SanPhamBUS laptopBUS = new SanPhamBUS();
        string selectedLaptopID;
        string soluong_lap;
        private MainForm mainForm;
        public SanPhamGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            LoadLaptops();
            edittable();
            AddButtonsToDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EditSanPham editSanPham = new EditSanPham(soluong_lap, "add");
            //editSanPham.Show();
            mainForm.OpenChildForm(new EditSanPham("L" + soluong_lap, "add", mainForm));
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idLaptop = row.Cells["IDLaptop"].Value.ToString();
                selectedLaptopID = idLaptop;

            }

            if (e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                mainForm.OpenChildForm(new EditSanPham(selectedLaptopID, "Sửa sản phẩm", mainForm));
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm với ID: {selectedLaptopID}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = laptopBUS.DeleteLaptop(selectedLaptopID.ToString());

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLaptops();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm vì ảnh hưởng tới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnView"].Index && e.RowIndex >= 0)
            {
                mainForm.OpenChildForm(new LaptopGUI(selectedLaptopID, mainForm));
            }
        }

        private void LoadLaptops()
        {
            List<SanPhamDTO> laptops = laptopBUS.GetLaptops();
            soluong_lap = (1 + laptops.Count).ToString();

            dataGridView1.DataSource = laptops;
        }

        private void edittable()
        {
            dataGridView1.Columns["IDLaptop"].HeaderText = "Mã Loại Laptop";
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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        private void AddButtonsToDataGridView()
        {
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


            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.Name = "btnView";
            btnView.HeaderText = "Chi tiết";
            btnView.Text = "📄";
            btnView.Width = 60;
            btnView.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnView);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new EditSanPham("L" + soluong_lap, "add", mainForm));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
