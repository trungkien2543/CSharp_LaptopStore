using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.NhanVien;
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

namespace CSharp_laptop.GUI
{
    public partial class NhanVienGUI : Form
    {
        int PH;
        bool hided;
        MainForm mainForm;
        NhanVienBUS bus;
        List<VBButton> btnEditList;
        List<VBButton> btnDelList;
        public NhanVienGUI(MainForm mainForm)
        {
            bus = new NhanVienBUS();

            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();

            this.mainForm = mainForm;

            InitializeComponent();

            PH = editpanel.Location.Y;

            editpanel.Location = new Point(editpanel.Location.X, this.Height + 30);
            hided = true;
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanVienGUI_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            dataGridView1.Rows.Clear();
            List<NhanVienDTO> nvs = bus.getAllNhanVien();
            for (int i = 0; i < nvs.Count; i++)
            {
                NhanVienDTO nv = nvs[i];
                dataGridView1.Rows.Add(new object[] { nv.ID_NhanVien, nv.TenNV, nv.NgaySinh, nv.SDT, nv.DiaChi, nv.GioiTinh ? "Nam" : "Nữ", nv.CCCD, nv.Email });
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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
                nameprocess.Text = "Sửa Nhân Viên";

                if (hided)
                {
                    button1.Text = "HIDE";
                    timer1.Start();
                }
                int rowIndex = int.Parse(clickedButton.Name);
                guna2TextBoxID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                guna2TextBoxTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                guna2TextBoxEmail.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                guna2TextBoxSDT.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                guna2TextBoxDiaChi.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                guna2TextBoxCCCD.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

                DateTime dateValue;
                if (DateTime.TryParse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), out dateValue))
                {
                    guna2DateTimePicker1.Value = dateValue;
                }
                if (dataGridView1.Rows[rowIndex].Cells[5].Value.ToString() != "Nam")
                {
                    NuRadioButton.Checked = true;
                    NamRadioButton.Checked = false;
                }
                else
                {
                    NuRadioButton.Checked = false;
                    NamRadioButton.Checked = true;
                }
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;

                int rowIndex = int.Parse(clickedButton.Name);

                String ma = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + ma, "Xóa Nhân Viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (bus.DeleteNhanVien(ma))
                    {
                        MessageBox.Show("Xóa Thành Công!");
                    } else
                    {

                        MessageBox.Show("Xóa Ko Thành Công!");
                    }
                    LoadTable();
                }
                else if (result == DialogResult.Cancel)
                {

                }

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

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateNhanVienGUI(mainForm));
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click_2(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateNhanVienGUI(mainForm));
        }
        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                editpanel.Location = new Point(editpanel.Location.X, editpanel.Location.Y - 5);
                if (editpanel.Location.Y <= this.Height - editpanel.Height)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (NuRadioButton.Checked)
            {
                NuLabel.ForeColor = Color.FromArgb(46, 88, 255);
            }
            else
            {

                NuLabel.ForeColor = Color.Black;
            }
        }

        private void guna2ImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (NamRadioButton.Checked)
            {
                NamLabel.ForeColor = Color.FromArgb(46, 88, 255);
            }
            else
            {

                NamLabel.ForeColor = Color.Black;
            }
        }

        private void NamLabel_Click(object sender, EventArgs e)
        {

        }


        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (nameprocess.Text == "Thêm Nhân Viên")
            {
                ThemNhanVien();
            } else
            {
                SuaNhanVien();
            }


            LoadTable();
        }
        private void SuaNhanVien()
        {
            if (KiemtraTextBox())
            {
                return;
            }
            NhanVienDTO nhanvientemp = bus.FindNhanVienById(guna2TextBoxID.Text);
            if (nhanvientemp == null)
            {
                MessageBox.Show("Mã Nhân Viên không tồn tại", "Lỗi!"); return;
            }


            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string email = guna2TextBoxEmail.Text;
            string STD = guna2TextBoxSDT.Text;
            string diachi = guna2TextBoxDiaChi.Text;
            string cccd = guna2TextBoxCCCD.Text;
            string ngaysinh = guna2DateTimePicker1.Value.ToString("dd/MM/yyyy");
            NhanVienDTO nv = new NhanVienDTO(id, ten, ngaysinh, STD, diachi, NamRadioButton.Checked, cccd, email);
            if (bus.UpdateNhanVien(nv))
            {
                MessageBox.Show("Sửa Nhân Viên Thành Công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Sửa Nhân Viên Không Thành Công!", "Thông Báo");
            }
        }
        private void ThemNhanVien()
        {
            if (KiemtraTextBox())
            {
                return;
            }
            NhanVienDTO nhanvientemp = bus.FindNhanVienById(guna2TextBoxID.Text);
            if (nhanvientemp != null)
            {
                MessageBox.Show("Mã Nhân Viên bị trùng với nhân viên " + nhanvientemp.TenNV, "Lỗi!"); return;
            }
            
            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string email = guna2TextBoxEmail.Text;
            string STD = guna2TextBoxSDT.Text;
            string diachi = guna2TextBoxDiaChi.Text;
            string cccd = guna2TextBoxCCCD.Text;
            string ngaysinh = guna2DateTimePicker1.Value.ToString("dd/MM/yyyy");
            NhanVienDTO nv = new NhanVienDTO(id, ten, ngaysinh, STD, diachi, NamRadioButton.Checked, cccd, email);
            if (bus.AddNhanVien(nv))
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công!", "Thông Báo");
            } else
            {
                MessageBox.Show("Thêm Nhân Viên Không Thành Công!", "Thông Báo");
            }

        }

        private bool KiemtraTextBox()
        {
            if (string.IsNullOrEmpty(guna2TextBoxID.Text))
            {
                MessageBox.Show("Mã Nhân Viên chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxTen.Text))
            {
                MessageBox.Show("Tên Nhân Viên chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxEmail.Text))
            {
                MessageBox.Show("Email chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxSDT.Text))
            {
                MessageBox.Show("Số điện thoại chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxCCCD.Text))
            {
                MessageBox.Show("CCCD chưa được nhập!", "Lỗi!"); return true;
            }
            if (!NuRadioButton.Checked && !NamRadioButton.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi!"); return true;
            }
            return false;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (!hided)
            {
                button1.Text = "SHOW";
                timer1.Start();
            }
        }

        private void vbButton2_Click_1(object sender, EventArgs e)
        {
            nameprocess.Text = "Thêm Nhân Viên";
            guna2TextBoxID.Text = TaoMaNV(bus.getAllNhanVien().Count);
            guna2TextBoxTen.Text = "";
            guna2TextBoxEmail.Text = "";
            guna2TextBoxSDT.Text = "";
            guna2TextBoxDiaChi.Text = "";
            guna2TextBoxCCCD.Text = "";
            if (hided)
            {
                button1.Text = "HIDE";
                timer1.Start();
            }
        }
        private string TaoMaNV(int danhSach)
        {
            int doDai = danhSach + 1;
            string soChuoi = doDai.ToString("D3");
            return "NV" + soChuoi;
        }

        private void guna2TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu không phải là số và không phải là phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void guna2TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu không phải là số và không phải là phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }
    }
}
