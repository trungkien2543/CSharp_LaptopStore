﻿using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.KhachHang;
using iTextSharp.text.pdf;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;
using OfficeOpenXml;
using CSharp_laptop.GUI.Laptop;
using LaptopStore.DTO;

namespace CSharp_laptop.GUI
{
    public partial class KhachHangGUI : Form
    {
        int PH;
        bool hided;
        MainForm mainForm;
        KhachHangBUS bus;
        List<KhachHangDTO> dtos;

        List<VBButton> btnEditList;
        List<VBButton> btnDelList;

        public KhachHangGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            bus = new KhachHangBUS();
            dtos = bus.getAllKhachHang();

            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();
            InitializeComponent();

            PH = editpanel.Location.Y;

            editpanel.Location = new Point(editpanel.Location.X, this.Height - 10);
            hided = true;
        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            LoadTable();


        }
        private void LoadTable()
        {
            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();
            dataGridView1.Rows.Clear();
            dataGridView1.Controls.Clear();
            dataGridView1.Refresh();

            dtos = bus.getAllKhachHang();
            for (int i = 0; i < dtos.Count; i++)
            {
                KhachHangDTO kh = dtos[i];
                dataGridView1.Rows.Add(new object[] { kh.ID_KhachHang, kh.TenKH, kh.DiaChiKH, kh.SDT, kh.TichDiem });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                nameprocess.Text = "Sủa Khách Hàng";
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;
                int rowIndex = int.Parse(clickedButton.Name);

                guna2TextBoxID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                guna2TextBoxTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                guna2TextBoxDC.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                guna2TextBoxSDT.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                guna2TextBoxDiem.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

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

                int rowIndex = int.Parse(clickedButton.Name);

                String ma = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + ma, "Xóa Khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (bus.DeleteKhachHang(ma))
                    {
                        MessageBox.Show("Xóa Thành Công!");
                    }
                    else
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

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateKhachHangGUI(mainForm));
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateKhachHangGUI(mainForm));
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
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

        private void guna2CircleButton3_Click_1(object sender, EventArgs e)
        {
            button1.Text = "SHOW";
            timer1.Start();
        }

        private void vbButton2_Click_1(object sender, EventArgs e)
        {
            nameprocess.Text = "Thêm Khách Hàng";
            guna2TextBoxID.Text = TaoMaKH(bus.getAllKhachHang().Count);
            guna2TextBoxTen.Text = "";
            guna2TextBoxDC.Text = "";
            guna2TextBoxSDT.Text = "";
            guna2TextBoxDiem.Text = "";
            if (hided)
            {
                button1.Text = "HIDE";
                timer1.Start();
            }
        }
        private string TaoMaKH(int danhSach)
        {
            int doDai = danhSach + 1;
            string soChuoi = doDai.ToString("D3");
            return "KH" + soChuoi;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (nameprocess.Text == "Thêm Khách Hàng")
            {
                ThemKhachHang();
            }
            else
            {
                SuaKhachHang();
            }

            LoadTable();
        }
        private void SuaKhachHang()
        {
            if (checkTextBox())
                return;
            if (bus.GetKhachHangById(guna2TextBoxID.Text) == null)
            {
                MessageBox.Show("Mã Khách hàng không tồn tại!", "Lỗi!");
                return;
            }
            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string DC = guna2TextBoxDC.Text;
            string sdt = guna2TextBoxSDT.Text;
            int diem = int.Parse(guna2TextBoxDiem.Text);
            KhachHangDTO kh = new KhachHangDTO(id, ten, DC, sdt, diem);

            if (bus.UpdateKhachHang(kh))
            {
                MessageBox.Show("Sửa khách hàng thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Sửa khách thất bại!", "Thông Báo");

            }
        }

        private void ThemKhachHang()
        {
            if (checkTextBox())
                return;
            if (bus.GetKhachHangById(guna2TextBoxID.Text) != null)
            {
                MessageBox.Show("Mã Khách hàng đã tồn tại!", "Lỗi!");
                return;
            }
            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string DC = guna2TextBoxDC.Text;
            string sdt = guna2TextBoxSDT.Text;
            int diem = int.Parse(guna2TextBoxDiem.Text);
            KhachHangDTO kh = new KhachHangDTO(id, ten, DC, sdt, diem);

            if (bus.AddKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Thêm khách thất bại!", "Thông Báo");

            }

        }
        private bool checkTextBox()
        {
            if (string.IsNullOrEmpty(guna2TextBoxID.Text))
            {
                MessageBox.Show("Mã Khách hàng chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxTen.Text))
            {
                MessageBox.Show("Tên Khách hàng chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxDC.Text))
            {
                MessageBox.Show("Email chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxSDT.Text))
            {
                MessageBox.Show("Số Điện thoại chưa được nhập!", "Lỗi!"); return true;
            }
            return false;
        }

        private void guna2TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void guna2TextBoxDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Danh sách Khách hàng");

                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tên Khách Hàng";
                worksheet.Cells[1, 3].Value = "Địa chỉ";
                worksheet.Cells[1, 4].Value = "SĐT";
                worksheet.Cells[1, 5].Value = "Tích Điểm";

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
                saveFileDialog.FileName = "DanhSachKhach.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }

        private void ImportE_Click(object sender, EventArgs e)
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
                    SaveKhachHangToDatabase(ImportFromExcel(filePath));
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void SaveKhachHangToDatabase(List<KhachHangDTO> khs)     // lưu sản phẩm mới từ excel
        {
            foreach (var kh in khs)
            {
                bool result = bus.AddKhachHang(kh); // Gọi hàm thêm dữ liệu vào DB
                if (!result)
                {
                    MessageBox.Show($"Lỗi khi lưu khách hàng: {kh.TenKH} vì trùng ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private List<KhachHangDTO> ImportFromExcel(string filePath)        // import excel
        {
            List<KhachHangDTO> khs = new List<KhachHangDTO>();
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
                        KhachHangDTO laptop = new KhachHangDTO
                        {
                            ID_KhachHang = worksheet.Cells[row, 1].Value?.ToString(),
                            TenKH = worksheet.Cells[row, 2].Value?.ToString(),
                            DiaChiKH = worksheet.Cells[row, 3].Value?.ToString(),
                            SDT = worksheet.Cells[row, 4].Value?.ToString(),
                            TichDiem = int.Parse(worksheet.Cells[row, 5].Value?.ToString() ?? "0"),
                        };

                        khs.Add(laptop);

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error while reading Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return khs;
        }
    }
}
