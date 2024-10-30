using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using LaptopStore.DTO;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class EditLoaiLaptop : Form
    {
        private LoaiLaptopBUS loaiLaptopBUS = new LoaiLaptopBUS();
        string function;
        private MainForm mainForm;

        private KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

        private HangBUS hangBUS = new HangBUS();
        public EditLoaiLaptop()
        {
            InitializeComponent();
        }

        public EditLoaiLaptop(string idLaptop, string chucnang, MainForm mainform)
        {
            this.mainForm = mainform;
            function = chucnang;
            InitializeComponent();


            if (chucnang == "add")
            {
                rjTextBox1.Texts = idLaptop;
            }
            else
            {
                LoaiLaptopDTO sanPhamDTO = loaiLaptopBUS.GetLaptopByID(idLaptop);

                rjTextBox1.Texts = sanPhamDTO.IDLoaiLaptop;
                rjTextBox2.Texts = sanPhamDTO.TenSP;
                rjTextBox3.Texts = sanPhamDTO.GiaBan.ToString();
                rjTextBox4.Texts = sanPhamDTO.GPU;
                rjTextBox5.Texts = sanPhamDTO.CPU;
                rjTextBox6.Texts = sanPhamDTO.RAM.ToString();
                rjTextBox7.Texts = sanPhamDTO.KichThuoc;
                rjTextBox8.Texts = sanPhamDTO.HinhAnh;


                rjComboBox1.Text = sanPhamDTO.Hang;
                rjComboBox2.Text = sanPhamDTO.KhuyenMai;
                label1.Text = chucnang;

                //if (!string.IsNullOrEmpty(rjTextBox8.Texts))
                //{
                //    pictureBox1.Image = Image.FromFile(rjTextBox8.Texts);
                //}
            }
            
            TaiDuLieuComboBoxKhuyenMai();
            TaiDuLieuComboBoxHang();
        }

        private void TaiDuLieuComboBoxKhuyenMai()
        {
            Dictionary<string, string> khuyenMai = khuyenMaiBUS.GetKhuyenMai();
            rjComboBox2.DataSource = new BindingSource(khuyenMai, null);
            rjComboBox2.DisplayMember = "Value";  // Hiển thị tên khuyến mãi
            rjComboBox2.ValueMember = "Key";      // Giá trị là mã khuyến mãi
        }

        private void TaiDuLieuComboBoxHang()
        {
            Dictionary<string, string> hangSanXuat = hangBUS.GetHangSanXuat();
            rjComboBox1.DataSource = new BindingSource(hangSanXuat, null);
            rjComboBox1.DisplayMember = "Value";  // Hiển thị tên hãng
            rjComboBox1.ValueMember = "Key";      // Giá trị là mã hãng
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            mainForm.OpenChildForm(new LoaiLaptopGUI(mainForm));
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            LoaiLaptopDTO laptop = new LoaiLaptopDTO
            {
                IDLoaiLaptop = rjTextBox1.Texts,
                TenSP = rjTextBox2.Texts,
                GiaBan = long.Parse(rjTextBox3.Texts),  // Chuyển đổi từ chuỗi sang số nguyên
                Hang = ((KeyValuePair<string, string>)rjComboBox1.SelectedItem).Key,
                CPU = rjTextBox5.Texts,
                RAM = int.Parse(rjTextBox6.Texts),  // Chuyển đổi từ chuỗi sang số nguyên
                GPU = rjTextBox4.Texts,
                HinhAnh = rjTextBox8.Texts,
                KichThuoc = rjTextBox7.Texts,
                KhuyenMai = ((KeyValuePair<string, string>)rjComboBox2.SelectedItem).Key

            };

            bool result = (function == "add") ? SaveLoaiLaptop(laptop,true) : SaveLoaiLaptop(laptop, false);
        }

        bool SaveLoaiLaptop(LoaiLaptopDTO loaiLaptopDTO, bool isAdd)
        {
            loaiLaptopBUS = new LoaiLaptopBUS();

            if (isAdd && loaiLaptopBUS.CheckIfIDExists(loaiLaptopDTO.IDLoaiLaptop))
            {
                MessageBox.Show("ID loại laptop đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập ID khác.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            bool result = isAdd ? loaiLaptopBUS.AddLaptop(loaiLaptopDTO) : loaiLaptopBUS.UpdateLaptop(loaiLaptopDTO);

            string action = isAdd ? "Thêm" : "Update";

            MessageBox.Show(result ? $"{action} thành công!" : $"{action} thất bại!", "Thông báo",
                    MessageBoxButtons.OK,
                    result ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            return result;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new LoaiLaptopGUI(mainForm));
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập bộ lọc cho hộp thoại chọn file (chỉ hiện các file ảnh)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị đường dẫn ảnh trong TextBox
                rjTextBox8.Texts = imagePath;

                // Kiểm tra file có tồn tại không trước khi hiển thị
                if (File.Exists(imagePath))
                {
                    // Hiển thị ảnh trong PictureBox
                    pictureBox1.Image = new System.Drawing.Bitmap(imagePath);

                    // Tùy chọn: Đặt kích thước PictureBox để phù hợp với ảnh
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("File không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
