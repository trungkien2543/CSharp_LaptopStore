using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.NhanVien;
using CSharp_laptop.Properties;
using LaptopStore.DTO;
using OfficeOpenXml;
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
            this.mainForm = mainForm;

            InitializeComponent();

            PH = editpanel.Location.Y;

            editpanel.Location = new Point(editpanel.Location.X, this.Height + 30);
            hided = true;
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanVienGUI_Load(object sender, EventArgs e)
        {
            LoadTable(bus.getAllNhanVien());
        }
        private void LoadTable(List<NhanVienDTO> nvs)
        {
            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();
            dataGridView1.Rows.Clear();
            dataGridView1.Controls.Clear();
            dataGridView1.Refresh();

            dataGridView1.Refresh();
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
                    }
                    else
                    {

                        MessageBox.Show("Xóa Ko Thành Công!");
                    }
                    LoadTable(bus.getAllNhanVien());
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
            }
            else
            {
                SuaNhanVien();
            }


            LoadTable(bus.getAllNhanVien());
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
            }
            else
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

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string filterText = searchTextBox.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng mới
                bool visible = row.Cells["Column2"].Value.ToString().ToLower().Contains(filterText);
                row.Visible = visible; // Hiển thị hoặc ẩn hàng dựa trên điều kiện
            }
        }
        private void rjTextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadTable(bus.SearchNhanVien(searchTextBox.Texts));
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Danh sách nhân viên");

                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tên Nhân Viên";
                worksheet.Cells[1, 3].Value = "Ngày Sinh";
                worksheet.Cells[1, 4].Value = "SĐT";
                worksheet.Cells[1, 5].Value = "Địa Chỉ";
                worksheet.Cells[1, 6].Value = "Giới tính";
                worksheet.Cells[1, 7].Value = "CCCD";
                worksheet.Cells[1, 8].Value = "Email";

                for (int i = 0; i < dataGridView1.Rows.Count; i++) // Lặp qua các hàng
                {
                    if (dataGridView1.Rows[i].IsNewRow) // Bỏ qua dòng mới (nếu có)
                        continue;

                    for (int j = 0; j < dataGridView1.Columns.Count; j++) // Lặp qua các cột
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value; // Gán giá trị vào Excel
                    }
                }

                worksheet.Cells[1, 1, 1, dataGridView1.Columns.Count].Style.Font.Bold = true; // In đậm tiêu đề
                worksheet.Cells[1, 1, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count].AutoFitColumns(); // Tự động chỉnh độ rộng cột

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DanhSachNhanVien.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"; // Lọc các file Excel
                openFileDialog.Title = "Chọn file Excel";

                // Kiểm tra xem người dùng có chọn file hay không
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;

                    // Gọi hàm nhập dữ liệu và lưu vào database
                    SaveNhanVienToDatabase(ImportFromExcel(filePath));
                    LoadTable(bus.getAllNhanVien());
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void SaveNhanVienToDatabase(List<NhanVienDTO> nvs)     // lưu sản phẩm mới từ excel
        {
            foreach (var nv in nvs)
            {
                bool result = bus.AddNhanVien(nv); // Gọi hàm thêm dữ liệu vào DB
                if (!result)
                {
                    MessageBox.Show($"Lỗi khi lưu nhân viên: {nv.TenNV} vì trùng ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private List<NhanVienDTO> ImportFromExcel(string filePath)        // import excel
        {
            List<NhanVienDTO> nvs = new List<NhanVienDTO>();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Lấy sheet đầu tiên
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng 2 (bỏ qua header)
                    {
                        NhanVienDTO nv = new NhanVienDTO
                        {
                            ID_NhanVien = worksheet.Cells[row, 1].Value?.ToString(),
                            TenNV = worksheet.Cells[row, 2].Value?.ToString(),
                            NgaySinh = worksheet.Cells[row, 3].Value?.ToString(),
                            SDT = worksheet.Cells[row, 4].Value?.ToString(),
                            DiaChi = worksheet.Cells[row, 5].Value?.ToString(),
                            GioiTinh = worksheet.Cells[row, 6].Value?.ToString() == "Nam" ? true : false,
                            CCCD = worksheet.Cells[row, 7].Value?.ToString(),
                            Email = worksheet.Cells[row, 8].Value?.ToString()
                        };

                        nvs.Add(nv);

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error while reading Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nvs;
        }


    }
}
