using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_laptop.GUI
{
    public partial class KhuyenMaiGUI : Form
    {
        private string funcion = "";
        private KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();
        public KhuyenMaiGUI()
        {
            InitializeComponent();
            loadData();
            Customtable();
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

        }

        private void button1_Click(object sender, EventArgs e)// Thêm
        {
            //// Chuyển sang tabcontrol 1 
            //panel3.Visible = false;
            //tabControl1.SelectedIndex = 1;

            //Point currentLocation = panel2.Location;// Lấy vị trí hiện tại
            //panel2.Location = new Point(currentLocation.X, currentLocation.Y - 40);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)// Sửa
        {
            //panel3.Visible = true;
            //tabControl1.SelectedIndex = 1;
            //Point currentLocation = panel2.Location;// Lấy vị trí hiện tại
            //panel2.Location = new Point(currentLocation.X, currentLocation.Y + 40);
        }

        private void xoa_but_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void then_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            textBox1.Texts = createID();
            funcion = "add";
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

        }

        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dong_y_but_Click(object sender, EventArgs e)
        {
            bool hople = true;
            string input = textBox3.Texts;
            int result;
            if (int.TryParse(input, out result))
            {// Nếu chuyển đổi thành công
                if (result<0 || result>100)
                {
                    MessageBox.Show("Mức giảm giá phải trong khoảng từ 0 đến 100.");
                    hople = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ vào mức giảm giá.");
                hople = false;
            }
            KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
            {
                IDKM = textBox1.Texts,
                TenKM = textBox2.Texts,
                MucGiamGia = result,
                MoTa = textBox4.Texts,
                ThoiGianBatDau = dateTimePicker2.Value,
                ThoiGianKetThuc = dateTimePicker4.Value,
                NgayTao = dateTimePicker5.Value
            };
            //khuyenMaiBUS.AddorEditKhuyenMai(khuyenMai, funcion);
            //MessageBox.Show("abc " + khuyenMai.ThoiGianBatDau + "   " + int.Parse(textBox3.Text));
        }

        private void loadData()
        {
            List<KhuyenMaiDTO> khuyenMai = khuyenMaiBUS.getKhuyenMaiArr();
            KM_dataGridView.DataSource = khuyenMai;
        }

        void Customtable()
        {
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏️";
            btnEdit.Width = 60;
            btnEdit.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            KM_dataGridView.Columns.Add(btnEdit);

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.Width = 60;
            //btnDelete.Image = Image.FromFile("path-to-your-delete-icon.png"); // Đường dẫn tới icon xóa
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            KM_dataGridView.Columns.Add(btnDelete);
        }

        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        private string createID()// Tạo ID mới
        {
            string id = "KH001";
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MAX(ID_KhuyenMai) FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    string maxID = result.ToString();
                    int numberPart = int.Parse(maxID.Substring(2));// Lấy phần số từ ID hiện tại (bỏ phần "KH")
                    numberPart++;
                    id = "KH" + numberPart.ToString("D3");// Tạo ID mới với định dạng "KH" + số tự động tăng với 3 chữ số
                }
            }
            return id;
        }

        private void KM_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == KM_dataGridView.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = KM_dataGridView.Rows[e.RowIndex];
                tabControl1.SelectedIndex = 1;
                textBox1.Texts = row.Cells["ID"].Value.ToString(); 
                textBox2.Texts = row.Cells[3].Value.ToString();
                textBox3.Texts = row.Cells[4].Value.ToString();
                textBox4.Texts = row.Cells[5].Value.ToString();
                funcion = "edit";
            }
            if (e.ColumnIndex == KM_dataGridView.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = KM_dataGridView.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();
                MessageBox.Show("xóa " + id);
            }
        }
    }
}
