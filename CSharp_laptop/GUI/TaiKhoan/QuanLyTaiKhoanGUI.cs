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
using Guna.UI2.WinForms;
using CSharp_laptop.DAO;

namespace CSharp_laptop.GUI
{
    public partial class QuanLyTaiKhoanGUI : Form
    {
        //private TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        //private MainForm mainForm;
        //string selectedTK;
        //string soluong_tk;
        int PH;
        bool hided;
        MainForm mainForm;
        TaiKhoanBUS bus;
        List<TaiKhoanDTO> nvs;
        List<VBButton> btnEditList;
        List<VBButton> btnDelList;

        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public QuanLyTaiKhoanGUI(MainForm mainForm)
        {
            //this.mainForm = mainForm;
            //InitializeComponent();
            //LoadTaiKhoan();
            //AddButtonsToDataGridView();
            //edittable();

            this.mainForm = mainForm;

            bus = new TaiKhoanBUS();
            nvs = bus.GetAllTaiKhoan();

            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();


            InitializeComponent();
            TaiDuLieuComboBoxQuyen();

            PH = editpanel.Location.Y;

            editpanel.Location = new Point(editpanel.Location.X, this.Height - 10);
            hided = true;


            
        }

        private void LoadDataToDataGridView()
        {
            

            for (int i = 0; i < nvs.Count; i++)
            {
                TaiKhoanDTO nv = nvs[i];
                dataGridView1.Rows.Add(new object[] { nv.TenDN, nv.MatKhau, nv.Quyen });
            }
        }
        private void LoadTaiKhoan()
        {

            //List<TaiKhoanDTO> tk = TaiKhoanBUS.GetAllTaiKhoan();
            //soluong_tk = (1 + tk.Count).ToString();

            //dataGridView1.DataSource = tk;

        }
        private void TaiKhoanGUI_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi
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
                int rowIndex = int.Parse(clickedButton.Name);

                guna2TextBoxID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                guna2TextBoxTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                guna2TextBoxDiem.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                if (hided)
                {
                    button1.Text = "HIDE";
                    timer1.Start();
                }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Xác định vị trí trung tâm theo cả hai chiều
            int targetX = (this.Width - editpanel.Width) / 2;
            int targetY = (this.Height - editpanel.Height) / 2 + 158;

            if (hided)
            {
                // Di chuyển editpanel đến vị trí trung tâm theo chiều Y
                editpanel.Location = new Point(editpanel.Location.X, editpanel.Location.Y - 5);

                // Kiểm tra nếu editpanel đã đến vị trí trung tâm theo chiều Y
                if (editpanel.Location.Y <= targetY)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                editpanel.Location = new Point(editpanel.Location.X, editpanel.Location.Y + 5);
                if (editpanel.Location.Y >= this.Height)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }

        }


        private void vbButton2_Click_1(object sender, EventArgs e)
        {
            guna2TextBoxID.Text = "";
            guna2TextBoxTen.Text = "";
            guna2TextBoxDiem.Text = "";
            if (hided)
            {
                button1.Text = "HIDE";
                timer1.Start();
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
            //mainForm.OpenChildForm(new CreateTaiKhoanGUI(mainForm));
            tabControl1.SelectedIndex = 1;

        }

        private void dataGridView1_CellContentClick_1(object sender, EventArgs e)
        {

        }

        private void artanPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            button1.Text = "SHOW";
            timer1.Start();
        }

        private void editpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void TaiDuLieuComboBoxQuyen()
        {
            Dictionary<string, string> quyen = taiKhoanBUS.GetAllQuyen();
            rjComboBox2.DataSource = new BindingSource(quyen, null);
            rjComboBox2.DisplayMember = "Value";  // Hiển thị tên khuyến mãi
            rjComboBox2.ValueMember = "Key";      // Giá trị là mã khuyến mãi
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và ComboBox
            string tenDN = rjTextBox2.Texts; // Lấy tên đăng nhập và loại bỏ khoảng trắng
            string matKhau = rjTextBox1.Texts; // Lấy mật khẩu và loại bỏ khoảng trắng
            string quyen = ((KeyValuePair<string, string>)rjComboBox2.SelectedItem).Key; // Lấy quyền từ ComboBox

            // Tạo một đối tượng TaiKhoanDTO
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO
            {
                TenDN = tenDN,
                MatKhau = matKhau,
                Quyen = quyen
            };

            bool isAdded = taiKhoanBUS.AddTaiKhoan(taiKhoan);

            if (isAdded)
            {
                MessageBox.Show("Tài khoản đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rjTextBox1.Text = "";
                rjTextBox2.Text = ""; // Sử dụng Clear() để xóa nội dung
                rjComboBox2.SelectedIndex = 0; // Hoặc chọn một giá trị mặc định
            }
            else
            {
                // Thêm tài khoản thất bại
                MessageBox.Show("Có lỗi xảy ra khi thêm tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            // Lấy thông tin từ các TextBox và ComboBox
            string tenDN = guna2TextBoxID.Text; // Lấy tên đăng nhập và loại bỏ khoảng trắng
            string matKhauMoi = guna2TextBoxTen.Text; // Lấy mật khẩu mới và loại bỏ khoảng trắng
            string quyenMoi = guna2TextBoxDiem.Text; // Lấy quyền từ ComboBox

            // Tạo một đối tượng TaiKhoanDTO với dữ liệu mới
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO
            {
                TenDN = tenDN,
                MatKhau = matKhauMoi,
                Quyen = quyenMoi
            };

            // Gọi hàm UpdateMatKhauQuyen để cập nhật tài khoản
            bool isUpdated = taiKhoanBUS.SuaTK(taiKhoan);

            if (isUpdated)
            {
                MessageBox.Show("Tài khoản đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Refresh();

        }


    }
}
