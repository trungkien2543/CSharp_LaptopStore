using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
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
        private KhuyenMaiDAO KhuyenMaiDAO = new KhuyenMaiDAO();

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
            string searchTerm = rjTextBox1.Texts.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            if (searchTerm != "")
            {
                khuyenMaiList = khuyenMaiBUS.TimKiem(searchTerm); // Gọi BUS để tìm kiếm
                KM_dataGridView.DataSource = khuyenMaiList; // Hiển thị dữ liệu lên DataGridView
            }
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

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()  // export excel
        {
            khuyenMaiList = khuyenMaiBUS.getKhuyenMaiArr();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add("Danh sách khuyến mãi");

                // Thêm tiêu đề ở dòng đầu tiên
                worksheet.Cells["A1:G1"].Merge = true; // Hợp nhất các ô từ A1 đến G1
                worksheet.Cells["A1"].Value = "DANH SÁCH KHUYẾN MÃI"; // Nội dung tiêu đề
                worksheet.Cells["A1"].Style.Font.Size = 18; // Font chữ lớn
                worksheet.Cells["A1"].Style.Font.Bold = true; // In đậm
                worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                worksheet.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa theo chiều dọc
                worksheet.Row(1).Height = 40; // Tăng chiều cao dòng tiêu đề

                // Thêm header vào Excel (dòng thứ hai)
                worksheet.Cells[2, 1].Value = "ID";
                worksheet.Cells[2, 2].Value = "Tên Khuyến Mãi";
                worksheet.Cells[2, 3].Value = "Mức giảm giá(%)";
                worksheet.Cells[2, 4].Value = "Mô tả";
                worksheet.Cells[2, 5].Value = "Thời gian bắt đầu";
                worksheet.Cells[2, 6].Value = "Thời gian kết thúc";
                worksheet.Cells[2, 7].Value = "Ngày tạo";

                // Định dạng header
                using (var range = worksheet.Cells[2, 1, 2, 7]) // Phạm vi các ô header
                {
                    range.Style.Font.Bold = true; // In đậm
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                    range.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid; // Nền solid
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Màu nền xám nhạt
                    range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin); // Viền
                }

                // Đổ dữ liệu từ danh sách vào Excel (bắt đầu từ dòng 3)
                for (int i = 0; i < khuyenMaiList.Count; i++)
                {
                    var KM = khuyenMaiList[i];
                    worksheet.Cells[i + 3, 1].Value = KM.IDKM;
                    worksheet.Cells[i + 3, 2].Value = KM.TenKM;
                    worksheet.Cells[i + 3, 3].Value = KM.MucGiamGia;
                    worksheet.Cells[i + 3, 4].Value = KM.MoTa;
                    worksheet.Cells[i + 3, 5].Value = KM.ThoiGianBatDau.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Cells[i + 3, 6].Value = KM.ThoiGianKetThuc.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Cells[i + 3, 7].Value = KM.NgayTao.ToString("yyyy-MM-dd HH:mm:ss");
                }

                // Kẻ bảng và căn giữa dữ liệu
                var dataRange = worksheet.Cells[2, 1, khuyenMaiList.Count + 2, 7]; // Phạm vi bảng (bao gồm header và dữ liệu)
                dataRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                dataRange.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                dataRange.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc

                // Tự động căn chỉnh kích thước cột
                worksheet.Cells.AutoFitColumns();

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DanhSachKhuyenMai.xlsx"; // Tên file mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file Excel tại vị trí người dùng chọn
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

                    ImportFromExcel(filePath);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void ImportFromExcel(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {

                // Kiểm tra nếu file không tồn tại
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load file Excel
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {

                    var worksheet = package.Workbook.Worksheets[0]; // Lấy Sheet đầu tiên
                    int rowCount = worksheet.Dimension.Rows; // Số hàng

                    for (int row = 3; row <= rowCount; row++) // Bỏ qua dòng tiêu đề
                    {
                        string idKM = worksheet.Cells[row, 1].Value?.ToString();
                        string tenKM = worksheet.Cells[row, 2].Value?.ToString();
                        string mucGiamGiaString = worksheet.Cells[row, 3].Value?.ToString();
                        string moTa = worksheet.Cells[row, 4].Value?.ToString();

                        DateTime thoiGianBatDau = DateTime.Parse(worksheet.Cells[row, 5].Value?.ToString());
                        DateTime thoiGianKetThuc = DateTime.Parse(worksheet.Cells[row, 6].Value?.ToString());
                        DateTime ngayTao = DateTime.Now;


                        KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
                        {
                            IDKM = idKM,
                            TenKM = tenKM,
                            MucGiamGia = int.Parse(mucGiamGiaString),
                            MoTa = moTa,
                            ThoiGianBatDau = thoiGianBatDau,
                            ThoiGianKetThuc = thoiGianKetThuc,
                            NgayTao = ngayTao
                        };
                        // Kiểm tra nếu IDKM đã tồn tại
                        var existingKhuyenMai = KhuyenMaiDAO.Get1KhuyenMai(idKM);

                        if (existingKhuyenMai != null)
                        {
                            DialogResult dialogResult = MessageBox.Show(
                                $"Khuyến mãi với ID {idKM} đã tồn tại. Bạn có muốn ghi đè dữ liệu không?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (dialogResult == DialogResult.Yes)
                            {
                                // Ghi đè dữ liệu
                                KhuyenMaiDAO.AddorEditKhuyenMai(khuyenMai, "edit");
                                MessageBox.Show($"Ghi đè khuyến mãi {idKM} thành công!", "Thông báo");
                                LoadData();
                            }
                        }
                        else
                        {
                            // Thêm mới khuyến mãi
                            KhuyenMaiDAO.AddorEditKhuyenMai(khuyenMai, "add");
                            MessageBox.Show($"Thêm mới khuyến mãi {idKM} thành công!", "Thông báo");
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi import: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
