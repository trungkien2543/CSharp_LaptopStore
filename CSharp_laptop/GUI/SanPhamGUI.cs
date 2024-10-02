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
                string idLaptop = row.Cells["ID_Loai"].Value.ToString();
                string tenSP = row.Cells["TenSP"].Value.ToString();
                string giaBan = row.Cells["GiaBan"].Value.ToString();
                string hang = row.Cells["Hang"].Value.ToString();
                string cpu = row.Cells["CPU"].Value.ToString();
                string ram = row.Cells["RAM"].Value.ToString();
                string gpu = row.Cells["GPU"].Value.ToString();
                string hinhAnh = row.Cells["HinhAnh"].Value.ToString();
                string kichThuoc = row.Cells["KichThuoc"].Value.ToString();
                string khuyenMai = row.Cells["KhuyenMai"].Value.ToString();

                // Hiển thị thông tin lên MessageBox
                string message = $"ID Laptop: {idLaptop}\n" +
                                 $"Tên SP: {tenSP}\n" +
                                 $"Giá bán: {giaBan}\n" +
                                 $"Hãng: {hang}\n" +
                                 $"CPU: {cpu}\n" +
                                 $"RAM: {ram}\n" +
                                 $"GPU: {gpu}\n" +
                                 $"Hình ảnh: {hinhAnh}\n" +
                                 $"Kích thước: {kichThuoc}\n" +
                                 $"Khuyến mãi: {khuyenMai}";

                MessageBox.Show(message, "Thông tin Laptop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadLaptops()
        {
            List<SanPhamDTO> laptops = laptopBUS.GetLaptops();
            dataGridView1.DataSource = laptops;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
