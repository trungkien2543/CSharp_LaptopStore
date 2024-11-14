using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.Laptop;
using CSharp_laptop.Properties;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_laptop.GUI.TaiKhoan;
using CSharp_laptop.GUI.NhanVien;

namespace CSharp_laptop.GUI
{
    public partial class QuanLyTaiKhoanGUI : Form
    {
        //private TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        //private MainForm mainForm;
        //string selectedTK;
        //string soluong_tk;

        MainForm mainForm;
        TaiKhoanBUS bus;
        List<TaiKhoanDTO> nvs;
        List<VBButton> btnEditList;
        List<VBButton> btnDelList;
        public QuanLyTaiKhoanGUI(MainForm mainForm)
        {
            //this.mainForm = mainForm;
            //InitializeComponent();
            //LoadTaiKhoan();
            //AddButtonsToDataGridView();
            //edittable();

            bus = new TaiKhoanBUS();
            nvs = bus.GetAllTaiKhoan();

            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();

            this.mainForm = mainForm;
            InitializeComponent();

        }

        private void LoadTaiKhoan()
        {

            //List<TaiKhoanDTO> tk = TaiKhoanBUS.GetAllTaiKhoan();
            //soluong_tk = (1 + tk.Count).ToString();

            //dataGridView1.DataSource = tk;

        }
        private void TaiKhoanGUI_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nvs.Count; i++)
            {
                TaiKhoanDTO nv = nvs[i];
                dataGridView1.Rows.Add(new object[] { nv.TenDN, nv.MatKhau, nv.Quyen });
            }
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
        private bool IsbtnEditListNameExist(string name)
        {
            // Kiểm tra xem có Button nào trong danh sách có Name khớp với tên cần tìm không
            return btnEditList.Any(btn => btn.Name == name);
        }
        private bool IsbtnDelListNameExist(string name)
        {
            // Kiểm tra xem có Button nào trong danh sách có Name khớp với tên cần tìm không
            return btnDelList.Any(btn => btn.Name == name);
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column7"].Index && e.RowIndex >= 0)
            {
                if (!IsbtnEditListNameExist(e.RowIndex.ToString()))
                {
                    // Tạo nút VBButton cho mỗi hàng
                    VBButton btn = new VBButton();
                    btn.Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btn.Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                    btn.BackgroundColor = Color.FromArgb(233, 203, 157);
                    btn.BorderRadius = 10;

                    btn.Name = e.RowIndex.ToString();
                    btn.Text = "✏️";

                    // Thêm sự kiện click cho VBButton nếu cần
                    btn.Click += BtnEdit_Click;

                    // Thêm nút vào control của DataGridView
                    dataGridView1.Controls.Add(btn);
                    btnEditList.Add(btn);

                    // Đánh dấu đã vẽ ô để tránh vẽ đè
                    e.Handled = true;
                }
                else
                {
                    btnEditList[e.RowIndex].Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btnEditList[e.RowIndex].Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                }

            }
            if (e.ColumnIndex == dataGridView1.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                if (!IsbtnDelListNameExist(e.RowIndex.ToString()))
                {
                    // Tạo nút VBButton cho mỗi hàng
                    VBButton btn = new VBButton();
                    btn.Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btn.Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                    btn.BackgroundColor = Color.FromArgb(233, 203, 157);
                    btn.BorderRadius = 10;

                    btn.Name = e.RowIndex.ToString();
                    btn.Text = "❌";

                    // Thêm sự kiện click cho VBButton nếu cần
                    btn.Click += BtnDel_Click;

                    // Thêm nút vào control của DataGridView
                    dataGridView1.Controls.Add(btn);
                    btnDelList.Add(btn);

                    // Đánh dấu đã vẽ ô để tránh vẽ đè
                    e.Handled = true;
                }
                else
                {
                    btnDelList[e.RowIndex].Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btnDelList[e.RowIndex].Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                }

            }
        }
        
       
        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void artanPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateTaiKhoanGUI(mainForm));
        }

        private void dataGridView1_CellContentClick_1(object sender, EventArgs e)
        {

        }

        private void artanPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
