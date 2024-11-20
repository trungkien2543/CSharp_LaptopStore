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

        string selectedLaptopID;
        string soluong_lap;
        private MainForm mainForm;
        public LoaiLaptopGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            Reset();


            AddButtonsToDataGridView();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new EditLoaiLaptop("L" + soluong_lap, "add", mainForm));
        }

        private void LoadLaptops()
        {
            laptops = laptopBUS.GetLaptops();
            soluong_lap = (1 + laptops.Count).ToString();

            dataGridView2.DataSource = laptops;
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
            mainForm.OpenChildForm(new EditLoaiLaptop("L" + soluong_lap, "add", mainForm));
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
        }


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
        }


        private void LoadDataForComboBox(ComboBox comboBox, String Item)
        {
            List<String> strings = new List<String>();
            strings.Add("");
            strings.AddRange(new LoaiLaptopBUS().getValueForComboBox(Item, txtTen, cbxCPU, cbxRAM, cbxGPU, cbxHang, cbxKichThuoc, txtGia));

            comboBox.DataSource = strings;
        }

        private void Reset()
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
        }

        private void ExportToExcel()
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
                }

                // Lưu file Excel
                var filePath = "DanhSachLaptop.xlsx";
                File.WriteAllBytes(filePath, package.GetAsByteArray());

                MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
