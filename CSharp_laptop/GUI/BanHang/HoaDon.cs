using CSharp_laptop.GUI.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharp_laptop.GUI.BanHang;
using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using OfficeOpenXml;
using CSharp_laptop.GUI.Laptop;

namespace CSharp_laptop.GUI
{
    public partial class HoaDon : Form
    {

        MainForm mainForm;

        List<HoaDonDTO> hoaDonDTOs;


        List<ChiTietHoaDonDTO> listCTHD;

        HoaDonBUS HoaDonBUS;

        ChiTietHoaDonBUS ChiTietHoaDonBUS;


        public HoaDon(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            HoaDonBUS = new HoaDonBUS();

            ChiTietHoaDonBUS = new ChiTietHoaDonBUS();

            hoaDonDTOs = new List<HoaDonDTO>();

            listCTHD = new List<ChiTietHoaDonDTO>();

            LoadHoaDons();

            edittable();

            AddButtonsToDataGridView();

            Reset();




        }

        private void LoadHoaDons()
        {
            hoaDonDTOs = HoaDonBUS.GetAllHoaDon();

            listCTHD = ChiTietHoaDonBUS.GetAllChiTietHoaDon();


            dataGridView2.DataSource = hoaDonDTOs;
        }

        private void edittable()
        {
            dataGridView2.Columns["ID_HoaDon"].HeaderText = "Mã hóa đơn";
            dataGridView2.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dataGridView2.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dataGridView2.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataGridView2.Columns["TongTien"].HeaderText = "Tổng tiền";


            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        private void AddButtonsToDataGridView()
        {
            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.Name = "btnView";
            btnView.HeaderText = "Chi tiết";
            btnView.Text = "📄";
            btnView.Width = 90;
            btnView.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnView);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BanHangForm(mainForm));

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            Finding();
        }

        private void Finding()
        {
            hoaDonDTOs = HoaDonBUS.FindWithCondition(txtFind, DateTimeFrom, DateTimeTo);

            listCTHD = ChiTietHoaDonBUS.GetChiTietHoaDonWithHoaDon(txtFind, DateTimeFrom, DateTimeTo);

            dataGridView2.DataSource = hoaDonDTOs;


        }

        private void Reset()
        {
            txtFind.Texts = "";

            // Lấy năm hiện tại
            int currentYear = DateTime.Now.Year;

            // Lấy ngày đầu năm
            DateTime firstDayOfYear = new DateTime(currentYear, 1, 1);

            // Lấy ngày cuối năm
            DateTime lastDayOfYear = new DateTime(currentYear, 12, 31, 23, 59, 59);

            // Gán vào các DateTimePicker
            DateTimeFrom.Value = firstDayOfYear;
            DateTimeTo.Value = lastDayOfYear;


        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void vbButton3_Click_1(object sender, EventArgs e)
        {
            Reset();

            LoadHoaDons();
        }

        private void DateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            Finding();
        }

        private void DateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            Finding();
        }

        private void ExportToExcel()  // export excel
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add("Danh sách hóa đơn");

                // Thêm header vào Excel
                worksheet.Cells[1, 1].Value = "Mã hóa đơn";
                worksheet.Cells[1, 2].Value = "Mã nhân viên";
                worksheet.Cells[1, 3].Value = "Mã khách hàng";
                worksheet.Cells[1, 4].Value = "Ngày lập";
                worksheet.Cells[1, 5].Value = "Tổng tiền";


                // Đổ dữ liệu từ danh sách vào Excel
                for (int i = 0; i < hoaDonDTOs.Count; i++)
                {
                    var hoaDon = hoaDonDTOs[i];
                    worksheet.Cells[i + 2, 1].Value = hoaDon.ID_HoaDon;
                    worksheet.Cells[i + 2, 2].Value = hoaDon.MaNV;
                    worksheet.Cells[i + 2, 3].Value = hoaDon.MaKH;

                    // Định dạng ngày tháng cho cột "Ngày lập"
                    var ngayLapCell = worksheet.Cells[i + 2, 4];
                    ngayLapCell.Value = hoaDon.NgayLap;

                    // Đặt định dạng ngày tháng theo kiểu dd/MM/yyyy
                    ngayLapCell.Style.Numberformat.Format = "dd/MM/yyyy";  // Định dạng ngày tháng


                    worksheet.Cells[i + 2, 5].Value = hoaDon.TongTien;
                }


                // Thêm chi tiết hóa đơn
                // Tạo một worksheet
                var worksheet1 = package.Workbook.Worksheets.Add("Chi tiết hóa đơn");

                // Thêm header vào Excel
                worksheet1.Cells[1, 1].Value = "Mã IMEI";
                worksheet1.Cells[1, 2].Value = "Mã hóa đơn";
                worksheet1.Cells[1, 3].Value = "Giá bán";



                // Đổ dữ liệu từ danh sách vào Excel
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    var chiTietHoaDon = listCTHD[i];
                    worksheet1.Cells[i + 2, 1].Value = chiTietHoaDon.IMEI;
                    worksheet1.Cells[i + 2, 2].Value = chiTietHoaDon.ID_HoaDon;
                    worksheet1.Cells[i + 2, 3].Value = chiTietHoaDon.GiaBan;
                }


                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DanhSachHoaDon.xlsx"; // Tên file mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file Excel tại vị trí người dùng chọn
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView2.Columns["btnView"].Index && e.RowIndex >= 0)
            {

                mainForm.OpenChildForm(new ChiTietHoaDon(mainForm, hoaDonDTOs[e.RowIndex]));

                
            }
        }
    }
}
