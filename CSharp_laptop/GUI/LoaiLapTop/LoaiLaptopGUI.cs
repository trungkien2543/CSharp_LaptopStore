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
using System.Windows.Forms;
using OfficeOpenXml;

namespace CSharp_laptop.GUI
{
    public partial class LoaiLaptopGUI : Form
    {

        private LoaiLaptopBUS laptopBUS = new LoaiLaptopBUS();

        private List<LoaiLaptopDTO> laptops;

        private KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

        private HangBUS hangBUS = new HangBUS();

        private Dictionary<string, string> HangDictionary = new Dictionary<string, string>  // Dictionary cho hãng
        {
        };
        
        private Dictionary<string, string> KhuyenMaiDictionary = new Dictionary<string, string> // Dictionary cho khuyến mãi
        {
        };

        string selectedLaptopID;
        string soluong_lap;

        string maLaptop;

        private MainForm mainForm;
        public LoaiLaptopGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            Reset();

            AddButtonsToDataGridView();
        }

        private void LoadLaptops()
        {
            laptops = laptopBUS.GetLaptops();
            soluong_lap = (1 + laptops.Count).ToString();

            dataGridView2.DataSource = laptops;
            TaiDuLieuHang();
            TaiDuLieuKhuyenMai();
        }

        private void auto_ID()
        {
            int soluong_lap = laptops.Count + 1; // Tính số lượng laptop mới

            if (soluong_lap < 10)
            {
                maLaptop = "L00" + soluong_lap; // Ví dụ: L001, L002...
            }
            else if (soluong_lap < 100)
            {
                maLaptop = "L0" + soluong_lap; // Ví dụ: L010, L099...
            }
            else
            {
                maLaptop = "L" + soluong_lap; // Ví dụ: L100, L101...
            }
            
        }

        private void edittable()
        {
            dataGridView2.Columns["IDLoaiLaptop"].HeaderText = "Mã Loại Laptop";
            dataGridView2.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dataGridView2.Columns["GiaBan"].HeaderText = "Giá Niêm Yết";
            dataGridView2.Columns["Hang"].HeaderText = "Hãng Laptop";
            dataGridView2.Columns["KhuyenMai"].HeaderText = "Khuyến Mãi";

            dataGridView2.Columns["CPU"].Visible = false;
            dataGridView2.Columns["RAM"].Visible = false;
            dataGridView2.Columns["GPU"].Visible = false;
            dataGridView2.Columns["HinhAnh"].Visible = false;
            dataGridView2.Columns["KichThuoc"].Visible = false;

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        private void AddButtonsToDataGridView()
        {
            // Thêm cột nút "Sửa"
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


            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.Name = "btnView";
            btnView.HeaderText = "Chi tiết";
            btnView.Text = "📄";
            btnView.Width = 90;
            btnView.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnView);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            auto_ID();
            mainForm.OpenChildForm(new EditLoaiLaptop(maLaptop, "add", mainForm));
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string idLaptop = row.Cells["IDLoaiLaptop"].Value.ToString();
                selectedLaptopID = idLaptop;

            }

            if (e.ColumnIndex == dataGridView2.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                mainForm.OpenChildForm(new EditLoaiLaptop(selectedLaptopID, "Sửa sản phẩm", mainForm));
            }
            else if (e.ColumnIndex == dataGridView2.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm với ID: {selectedLaptopID}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = laptopBUS.DeleteLaptop(selectedLaptopID.ToString());

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLaptops();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm vì ảnh hưởng tới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView2.Columns["btnView"].Index && e.RowIndex >= 0)
            {
                mainForm.OpenChildForm(new LaptopGUI(selectedLaptopID, mainForm));
            }
        } // nút sửa và xóa


        private void find(object sender, EventArgs e)
        {
            laptops = laptopBUS.findLaptop(txtTen, cbxCPU, cbxRAM, cbxGPU, cbxHang, cbxKichThuoc, txtGia);


            // Kiểm tra và tải dữ liệu cho từng ComboBox nếu chưa có giá trị
            if (cbxCPU.Text.Equals(""))
            {
                LoadDataForComboBox(cbxCPU, "CPU");
            }

            if (cbxHang.Text.Equals(""))
            {
                LoadDataForComboBox(cbxHang, "TenHang");
            }

            if (cbxRAM.Text.Equals(""))
            {
                LoadDataForComboBox(cbxRAM, "RAM");
            }

            if (cbxGPU.Text.Equals(""))
            {
                LoadDataForComboBox(cbxGPU, "GPU");
            }

            if (cbxKichThuoc.Text.Equals(""))
            {
                LoadDataForComboBox(cbxKichThuoc, "KichThuoc");
            }


            dataGridView2.DataSource = laptops;
        } // bộ lọc


        private void LoadDataForComboBox(ComboBox comboBox, String Item)        // Kiên
        {
            List<String> strings = new List<String>();
            strings.Add("");
            strings.AddRange(new LoaiLaptopBUS().getValueForComboBox(Item, txtTen, cbxCPU, cbxRAM, cbxGPU, cbxHang, cbxKichThuoc, txtGia));

            comboBox.DataSource = strings;
        }

        private void Reset()        // Kiên
        {
            LoadLaptops();
            edittable();


            // Load dữ liệu cho comboBox
            LoadDataForComboBox(cbxCPU, "CPU");
            LoadDataForComboBox(cbxHang, "TenHang");
            LoadDataForComboBox(cbxRAM, "RAM");
            LoadDataForComboBox(cbxGPU, "GPU");
            LoadDataForComboBox(cbxKichThuoc, "KichThuoc");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }       // đặt lại

        private void ExportToExcel()  // export excel
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add("Danh sách Laptop");

                // Thêm header vào Excel
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tên Sản Phẩm";
                worksheet.Cells[1, 3].Value = "Giá Bán";
                worksheet.Cells[1, 4].Value = "Hãng";
                worksheet.Cells[1, 5].Value = "CPU";
                worksheet.Cells[1, 6].Value = "RAM";
                worksheet.Cells[1, 7].Value = "GPU";
                worksheet.Cells[1, 8].Value = "Kích Thước";
                worksheet.Cells[1, 9].Value = "SL Tồn Kho";
                worksheet.Cells[1, 10].Value = "Khuyến Mãi";

                // Đổ dữ liệu từ danh sách vào Excel
                for (int i = 0; i < laptops.Count; i++)
                {
                    var laptop = laptops[i];
                    worksheet.Cells[i + 2, 1].Value = laptop.IDLoaiLaptop;
                    worksheet.Cells[i + 2, 2].Value = laptop.TenSP;
                    worksheet.Cells[i + 2, 3].Value = laptop.GiaBan;
                    worksheet.Cells[i + 2, 4].Value = laptop.Hang;
                    worksheet.Cells[i + 2, 5].Value = laptop.CPU;
                    worksheet.Cells[i + 2, 6].Value = laptop.RAM;
                    worksheet.Cells[i + 2, 7].Value = laptop.GPU;
                    worksheet.Cells[i + 2, 8].Value = laptop.KichThuoc;
                    worksheet.Cells[i + 2, 9].Value = laptop.SLTonKho;
                    worksheet.Cells[i + 2, 10].Value = laptop.KhuyenMai;
                }

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DanhSachLaptop.xlsx"; // Tên file mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file Excel tại vị trí người dùng chọn
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }// nút export excel

        private List<LoaiLaptopDTO> ImportFromExcel(string filePath)        // import excel
        {
            List<LoaiLaptopDTO> laptops2 = new List<LoaiLaptopDTO>();

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
                        string hangValue = worksheet.Cells[row, 4].Value?.ToString();
                        string kmValue = worksheet.Cells[row, 10].Value?.ToString();

                        // Tra cứu mã hãng và mã khuyến mãi
                        string hangKey = HangDictionary.FirstOrDefault(x => x.Value == hangValue).Key ?? "Unknown";
                        string kmKey = KhuyenMaiDictionary.FirstOrDefault(x => x.Value == kmValue).Key ?? "Unknown";

                        //MessageBox.Show(hangKey + kmKey);

                        LoaiLaptopDTO laptop = new LoaiLaptopDTO
                        {
                            IDLoaiLaptop = worksheet.Cells[row, 1].Value?.ToString(),
                            TenSP = worksheet.Cells[row, 2].Value?.ToString(),
                            GiaBan = long.Parse(worksheet.Cells[row, 3].Value?.ToString() ?? "0"),
                            Hang = hangKey, // Lưu mã hãng
                            CPU = worksheet.Cells[row, 5].Value?.ToString(),
                            RAM = int.Parse(worksheet.Cells[row, 6].Value?.ToString() ?? "0"),
                            GPU = worksheet.Cells[row, 7].Value?.ToString(),
                            HinhAnh = worksheet.Cells[row, 8].Value?.ToString(),
                            KichThuoc = worksheet.Cells[row, 9].Value?.ToString(),
                            KhuyenMai = kmKey // Lưu mã khuyến mãi
                        };

                        laptops2.Add(laptop);

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error while reading Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return laptops2;
        }

        private void SaveLaptopsToDatabase(List<LoaiLaptopDTO> laptops)     // lưu sản phẩm mới từ excel
        {
            foreach (var laptop in laptops)
            {
                // Kiểm tra xem ID đã tồn tại trong database hay chưa
                var existingLaptop = laptopBUS.GetLaptopByID(laptop.IDLoaiLaptop);

                if (existingLaptop != null)
                {
                    // Nếu tồn tại, hiển thị thông báo hỏi người dùng
                    DialogResult result = MessageBox.Show(
                        $"Sản phẩm với ID {laptop.IDLoaiLaptop} đã tồn tại. Bạn có muốn ghi đè thông tin không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Nếu người dùng chọn Yes, gọi hàm cập nhật
                        bool updateResult = laptopBUS.UpdateLaptop(laptop);
                        if (!updateResult)
                        {
                            MessageBox.Show(
                                $"Lỗi khi cập nhật laptop: {laptop.TenSP} \n" +
                                $"Dữ liệu cập nhật không tương thích vui lòng kiểm tra lại tên hãng và khuyến mãi\n !" +
                                $"Giá bán phải là số!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Người dùng chọn No, không thực hiện gì
                        MessageBox.Show($"Sản phẩm {laptop.TenSP} không được ghi đè.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Nếu ID không tồn tại, gọi hàm thêm mới
                    bool insertResult = laptopBUS.AddLaptop(laptop);
                    if (!insertResult)
                    {
                        MessageBox.Show(
                            $"Lỗi khi lưu laptop: {laptop.TenSP}",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Hoàn thành việc nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vbButton3_Click(object sender, EventArgs e)        // Nút import excel
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
                    SaveLaptopsToDatabase(ImportFromExcel(filePath));
                    LoadLaptops();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void TaiDuLieuKhuyenMai()
        {
            // Lấy dữ liệu khuyến mãi từ lớp BUS
            Dictionary<string, string> khuyenMai = khuyenMaiBUS.GetKhuyenMai();


            // Lưu vào Dictionary cho việc tra cứu
            KhuyenMaiDictionary = khuyenMai;
        }

        private void TaiDuLieuHang()
        {
            // Lấy dữ liệu hãng sản xuất từ lớp BUS
            Dictionary<string, string> hangSanXuat = hangBUS.GetHangSanXuat();

            // Lưu vào Dictionary cho việc tra cứu
            HangDictionary = hangSanXuat;
        }
    }
}
