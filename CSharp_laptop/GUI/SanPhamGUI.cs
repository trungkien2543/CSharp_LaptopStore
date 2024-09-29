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
        public SanPhamGUI()
        {
            InitializeComponent();
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
            if (e.RowIndex >= 0) // Kiểm tra để đảm bảo không phải hàng tiêu đề
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string id = selectedRow.Cells["Column1"].Value.ToString();
                string tenSP = selectedRow.Cells["Column2"].Value.ToString();
                long gia = Convert.ToInt64(selectedRow.Cells["Column3"].Value);
                string hang = selectedRow.Cells["Column4"].Value.ToString();
                string cpu = selectedRow.Cells["Column5"].Value.ToString();
                int ram = Convert.ToInt32(selectedRow.Cells["Column6"].Value);
                string gpu = selectedRow.Cells["Column7"].Value.ToString();
                string hinhAnh = selectedRow.Cells["Column8"].Value.ToString();
                string kichThuoc = selectedRow.Cells["Column9"].Value.ToString();
                string khuyenMai = selectedRow.Cells["Column10"].Value.ToString();


                MessageBox.Show($"ID: {id}\nTên sản phẩm: {tenSP}\nGiá: {gia}");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
