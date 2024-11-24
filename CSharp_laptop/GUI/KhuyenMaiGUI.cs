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
        private BindingList<KhuyenMaiDTO> khuyenMaiList;

        public KhuyenMaiGUI()
        {
            InitializeComponent();
            LoadData();
            Customtable();
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

        }
        //--------------------------//
        //tabControl1
        private void tk_but_Click(object sender, EventArgs e)
        {

        }

        private void then_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            textBox1.Texts = khuyenMaiBUS.GetMaxID();
            textBox2.Texts = "";
            textBox3.Texts = "";
            textBox4.Texts = "";
            text_mess1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            funcion = "add";
        }

        private void LoadData()
        {
            khuyenMaiList = khuyenMaiBUS.getKhuyenMaiArr();
            KM_dataGridView.DataSource = khuyenMaiList;
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
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            KM_dataGridView.Columns.Add(btnDelete);
        }

        private void KM_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)//Sửa/xóa
        {
            if (e.ColumnIndex == KM_dataGridView.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = KM_dataGridView.Rows[e.RowIndex];
                tabControl1.SelectedIndex = 1;
                textBox1.Texts = row.Cells["ID"].Value.ToString();
                textBox2.Texts = row.Cells[3].Value.ToString();
                textBox3.Texts = row.Cells[4].Value.ToString();
                textBox4.Texts = row.Cells[5].Value.ToString();
                text_mess1.Text = "";
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells[6].Value);
                dateTimePicker3.Value = Convert.ToDateTime(row.Cells[7].Value);
                dateTimePicker4.Value = Convert.ToDateTime(row.Cells[7].Value);
                dateTimePicker5.Value = Convert.ToDateTime(row.Cells[8].Value);
                funcion = "edit";
            }
            if (e.ColumnIndex == KM_dataGridView.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = KM_dataGridView.Rows[e.RowIndex];

                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //string id = row.Cells["ID"].Value.ToString();
                    //khuyenMaiBUS.DeleteKhuyenMai(id);

                    khuyenMaiList.Remove((KhuyenMaiDTO)row.DataBoundItem);
                }
                else
                {
                    
                }
            }
        }


        //--------------------------//
        //tabControl2
        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dong_y_but_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (textBox3.Texts == "")
            {
                text_mess1.Text = "Vui lòng nhập mức giảm giá.";
                check--;
            }
            if (text_mess1.Text != "")
            {
                check--;
            }
            //Kiểm tra thời gian
            DateTime date1 = dateTimePicker2.Value.Date;
            DateTime date2 = dateTimePicker4.Value.Date;
            TimeSpan time1 = dateTimePicker1.Value.TimeOfDay;
            TimeSpan time2 = dateTimePicker3.Value.TimeOfDay;
            DateTime datetime1 = date1.Add(time1);
            DateTime datetime2 = date2.Add(time2);
            if (datetime1 >= datetime2)
            {
                MessageBox.Show("Thời gian Kết thúc phải lớn hơn thời gian bắt đầu.");
            }

            if (check == 0)
            {
                KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
                {
                    IDKM = textBox1.Texts,
                    TenKM = textBox2.Texts,
                    MucGiamGia = int.Parse(textBox3.Texts),
                    MoTa = textBox4.Texts,
                    ThoiGianBatDau = datetime1,
                    ThoiGianKetThuc = datetime2,
                    NgayTao = dateTimePicker5.Value.Date
                };
                khuyenMaiBUS.AddorEditKhuyenMai(khuyenMai, funcion);
                LoadData();
                tabControl1.SelectedIndex = 0;
            }
        }

        private void check_tb3(object sender, EventArgs e)
        {
            string input = textBox3.Texts;
            int result;
            if (int.TryParse(input, out result))
            {// Nếu chuyển đổi thành công
                if (result < 0 || result > 100)
                {
                    text_mess1.Text = "Số phải nằm trong khoảng từ 0 đến 100.";
                }
                else
                {
                    text_mess1.Text = "";
                }
            }
            else
            {
                text_mess1.Text = "Vui lòng nhập một số trong khoảng từ 0 đến 100.";
            }
        }
    }
}
