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

namespace CSharp_laptop.GUI
{
    public partial class SanPhamGUI : Form
    {

        private SanPhamBUS laptopBUS = new SanPhamBUS();
        string selectedLaptopID;
        public SanPhamGUI()
        {
            InitializeComponent();
            LoadLaptops();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditSanPham editSanPham = new EditSanPham();
            editSanPham.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                string idLaptop = row.Cells["IDLaptop"].Value.ToString();
                string tenSP = row.Cells["TenSP"].Value.ToString();
                string giaBan = row.Cells["GiaBan"].Value.ToString();
                string hang = row.Cells["Hang"].Value.ToString();
                string cpu = row.Cells["CPU"].Value.ToString();
                string ram = row.Cells["RAM"].Value.ToString();
                string gpu = row.Cells["GPU"].Value.ToString();
                string hinhAnh = row.Cells["HinhAnh"].Value.ToString();
                string kichThuoc = row.Cells["KichThuoc"].Value.ToString();
                string khuyenMai = row.Cells["KhuyenMai"].Value.ToString();

                selectedLaptopID = idLaptop;
                // Hiển thị thông tin lên MessageBox
                string message = $"Đã chọn laptopID = {selectedLaptopID}";

                MessageBox.Show(message, "Thông tin Laptop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EditSanPham editSanPham = new EditSanPham(idLaptop, "Sửa sản phẩm");
                editSanPham.Show();


            }
        }

        private void LoadLaptops()
        {
            List<SanPhamDTO> laptops = laptopBUS.GetLaptops();
            dataGridView1.DataSource = laptops;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedLaptopID))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = laptopBUS.DeleteLaptop(selectedLaptopID);

                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLaptops();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
