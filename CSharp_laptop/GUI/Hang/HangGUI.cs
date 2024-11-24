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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class HangGUI : Form
    {
        private HangBUS hangBUS = new HangBUS();
        private MainForm mainForm;

        List<HangDTO> hangs;

        string HangID;

        String selectedHangID;
        public HangGUI(MainForm mainForm)
        {
            InitializeComponent();
            loadHangs();


            Customtable();
            this.mainForm = mainForm;
        }

        private void loadHangs()
        {
            hangs = hangBUS.GetHangs();
            dataGridView2.DataSource = hangs;
        }

        void Customtable()
        {
            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏️";
            btnEdit.Width = 60;
            btnEdit.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnEdit);

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.Width = 60;
            //btnDelete.Image = Image.FromFile("path-to-your-delete-icon.png"); // Đường dẫn tới icon xóa
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnDelete);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            auto_ID();
            mainForm.OpenChildForm(new EditHangGUI(mainForm, "add", HangID));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string idHang = row.Cells["ID_Hang"].Value.ToString();
                selectedHangID = idHang;

            }

            if (e.ColumnIndex == dataGridView2.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                mainForm.OpenChildForm(new EditHangGUI(mainForm, "update", selectedHangID));

            }
            else if (e.ColumnIndex == dataGridView2.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm với ID: {selectedHangID}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (hangBUS.DeleteHangSanXuat(selectedHangID))
                {
                    MessageBox.Show("Xóa hãng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa hãng vì ảnh hưởng tới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadHangs();
            }


        }

        private void auto_ID()
        {
            int soluong_lap = hangs.Count + 1; // Tính số lượng laptop mới

            if (soluong_lap < 10)
            {
                HangID = "H00" + soluong_lap; // Ví dụ: L001, L002...
            }
            else if (soluong_lap < 100)
            {
                HangID = "H0" + soluong_lap; // Ví dụ: L010, L099...
            }
            else
            {
                HangID = "H" + soluong_lap; // Ví dụ: L100, L101...
            }

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {

            if (rjTextBox1.Texts == "Tìm kiếm")
            {
                rjTextBox1.Texts = "";
                rjTextBox1.ForeColor = Color.Black; // Đổi màu chữ về màu bình thường
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(rjTextBox1.Texts))
            {
                rjTextBox1.Texts = "Tìm kiếm"; // Văn bản hint
                rjTextBox1.ForeColor = Color.Gray; // Đổi màu chữ sang màu xám
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            string searchTerm = rjTextBox1.Texts.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            DataTable result = hangBUS.SearchHangSanXuat(searchTerm); // Gọi BUS để tìm kiếm
            dataGridView2.DataSource = result; // Hiển thị dữ liệu lên DataGridView
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            loadHangs();
        }
    }
}
