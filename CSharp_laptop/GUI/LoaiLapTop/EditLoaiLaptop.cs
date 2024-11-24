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

            TaiDuLieuComboBoxKhuyenMai();
            TaiDuLieuComboBoxHang();


            if (chucnang == "add")
            {
                tb_id.Text = idLaptop;
            }
            else
            {
                LoaiLaptopDTO sanPhamDTO = loaiLaptopBUS.GetLaptopByID(idLaptop);

                tb_id.Text = sanPhamDTO.IDLoaiLaptop;
                tb_ten.Text = sanPhamDTO.TenSP;
                tb_gia.Text = sanPhamDTO.GiaBan.ToString();
                tb_gpu.Text = sanPhamDTO.GPU;
                tb_cpu.Text = sanPhamDTO.CPU;
                tb_ram.Text = sanPhamDTO.RAM.ToString();
                tb_kichthuoc.Text = sanPhamDTO.KichThuoc;
                tb_anh.Text = sanPhamDTO.HinhAnh;

                cbbhang.SelectedValue = sanPhamDTO.Hang;
                cbbkm.SelectedValue = sanPhamDTO.KhuyenMai;

                label1.Text = chucnang;

                if (!string.IsNullOrEmpty(tb_anh.Text))
                {
                    pictureBox1.Image = Image.FromFile(tb_anh.Text);
                }
            }


        }

        private void TaiDuLieuComboBoxKhuyenMai()
        {
            Dictionary<string, string> khuyenMai = khuyenMaiBUS.GetKhuyenMai();

            cbbkm.DataSource = new BindingSource(khuyenMai, null);
            cbbkm.DisplayMember = "Value";  // Hiển thị tên khuyến mãi
            cbbkm.ValueMember = "Key";      // Giá trị là mã khuyến mãi

        }

        private void TaiDuLieuComboBoxHang()
        {
            Dictionary<string, string> hangSanXuat = hangBUS.GetHangSanXuat();

            cbbhang.DataSource = new BindingSource(hangSanXuat, null);
            cbbhang.DisplayMember = "Value";  // Hiển thị tên hãng
            cbbhang.ValueMember = "Key";      // Giá trị là mã hãng
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
                IDLoaiLaptop = tb_id.Text,
                TenSP = tb_ten.Text,
                GiaBan = long.Parse(tb_gia.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                Hang = ((KeyValuePair<string, string>)cbbhang.SelectedItem).Key,
                CPU = tb_cpu.Text,
                RAM = int.Parse(tb_ram.Text),  // Chuyển đổi từ chuỗi sang số nguyên
                GPU = tb_gpu.Text,
                HinhAnh = tb_anh.Text,
                KichThuoc = tb_kichthuoc.Text,
                KhuyenMai = ((KeyValuePair<string, string>)cbbkm.SelectedItem).Key

            };

            bool result = (function == "add") ? SaveLoaiLaptop(laptop, true) : SaveLoaiLaptop(laptop, false);
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
                tb_anh.Text = imagePath;

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

        private void tb_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
