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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using System.Text.RegularExpressions;
using CSharp_laptop.DTO;
using System.Media;
using Microsoft.VisualBasic;
using System.Transactions;
using MySql.Data.MySqlClient;


namespace CSharp_laptop.GUI.BanHang
{


    public partial class BanHangForm : Form
    {

        private FilterInfoCollection filterInfoCollection; // Lưu thông tin các thiết bị video

        private VideoCaptureDevice videoCaptureDevice; // Tương tác với thiết bị video

        private string pattern = @"^H\d{3}L\d{3}\d{4}$"; // Mẫu biểu thức chính quy cho IMEI

        private HashSet<string> scannedCodes = new HashSet<string>();


        MainForm mainForm;


        private BindingList<LaptopDTO> listSP; // Để tự động cập nhật list

        private Dictionary<String, long> laptopWithGiaBan;


        private LaptopBUS LaptopBUS;

        private LoaiLaptopBUS LoaiLaptopBUS;

        private KhachHangBUS KhachHangBUS;

        private HoaDonBUS HoaDonBUS;

        private ChiTietHoaDonBUS ChiTietHoaDonBUS;

        private long ThanhTien, TongTien, GiamGia;



        public BanHangForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            LaptopBUS = new LaptopBUS();

            LoaiLaptopBUS = new LoaiLaptopBUS();

            KhachHangBUS = new KhachHangBUS();

            HoaDonBUS = new HoaDonBUS();

            ChiTietHoaDonBUS = new ChiTietHoaDonBUS();

            listSP = new BindingList<LaptopDTO>();

            laptopWithGiaBan = new Dictionary<string, long>();

            Load += Form1_Load;

            lblCamera.Visible = false;

            LoadLaptops();

            edittable();

            txtTongTien.Enabled = false;

            txtGiamGia.Enabled = false;

            txtThanhTien.Enabled = false;

            txtTienThoi.Enabled = false;

            txtTichDiem.Text = "0";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lấy danh sách camera và thêm vào ComboBox
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbxCamera.Items.Add(device.Name);
            }
            cbxCamera.SelectedIndex = 0; // Chọn camera đầu tiên
        }


        private void edittable()
        {
            dataGridView2.Columns["IMEI"].HeaderText = "IMEI";
            dataGridView2.Columns["ThoiGianBaoHanh"].HeaderText = "Thời gian bảo hành";
            dataGridView2.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView2.Columns["LoaiLaptop"].HeaderText = "Mã loại";


            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            AddButtonsToDataGridView();

        }

        private void LoadLaptops()
        {
            dataGridView2.DataSource = listSP;
        }

        private void AddButtonsToDataGridView()
        {
            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.Width = 60;
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView2.Columns.Add(btnDelete);


        }



        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void vbButton2_Click(object sender, EventArgs e)
        {
            // Khởi tạo thiết bị video từ lựa chọn trong ComboBox
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbxCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            lblCamera.Visible = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Lấy frame từ camera và hiển thị trên PictureBox
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Khởi tạo BarcodeReader từ ZXing.Windows.Compatibility để quét mã vạch
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    string scannedCode = result.Text; // Lấy mã vạch từ kết quả

                    // Kiểm tra mã đã quét trước đó chưa
                    if (!scannedCodes.Contains(scannedCode))
                    {


                        LaptopDTO tempLaptop = LaptopBUS.GetLaptopByIMEI(scannedCode);

                        if (tempLaptop.TrangThai == 1)
                        {

                            scannedCodes.Add(scannedCode); // Lưu mã vào danh sách đã quét


                            // Xử lý mã mới
                            listSP.Add(tempLaptop);

                            laptopWithGiaBan.Add(tempLaptop.IMEI, LaptopBUS.GetGiaBanByIMEI(tempLaptop.IMEI));

                            ThanhTien += laptopWithGiaBan[tempLaptop.IMEI];

                            txtThanhTien.Text = ThanhTien.ToString("N0");

                            CapNhatGia();



                            // Phát âm thanh báo hiệu
                            PlayBeepSound();
                        }


                    }


                }));
            }

            bitmap.Dispose();
        }


        private void vbButton1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();

                lblCamera.Visible = false;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void PlayBeepSound()
        {
            try
            {



                // Tạo và phát âm thanh
                SoundPlayer player = new SoundPlayer("banhangSound.wav");

                player.Play(); // Hoặc player.PlaySync() nếu muốn chặn cho đến khi âm thanh phát xong

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể phát âm thanh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BanHangForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();

                lblCamera.Visible = false;
            }
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Nhập mã IMEI của laptop:", "Bán hàng", "", -1, -1);

            // Kiểm tra người dùng có nhập dữ liệu hay không
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return; // Dừng thực hiện nếu input trống
            }


            // Kiểm tra mã đã quét trước đó chưa
            if (!scannedCodes.Contains(userInput))
            {

                LaptopDTO tempLaptop = LaptopBUS.GetLaptopByIMEI(userInput);

                if (tempLaptop != null)
                {
                    if (tempLaptop.TrangThai == 1)
                    {

                        scannedCodes.Add(userInput); // Lưu mã vào danh sách đã quét


                        // Xử lý mã mới
                        listSP.Add(tempLaptop);

                        laptopWithGiaBan.Add(tempLaptop.IMEI, LaptopBUS.GetGiaBanByIMEI(tempLaptop.IMEI));

                        ThanhTien += laptopWithGiaBan[tempLaptop.IMEI];


                        txtThanhTien.Text = ThanhTien.ToString("N0");

                        CapNhatGia();



                        // Phát âm thanh báo hiệu
                        PlayBeepSound();
                    }
                    else
                    {
                        MessageBox.Show($"Mã này đã bán rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show($"Mã này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show($"Mã này đã được thêm vào hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                LaptopDTO laptopDTO = listSP.ElementAt(e.RowIndex);

                // Hiển thị hộp thoại Yes/No
                DialogResult result = MessageBox.Show($"IMEI: {laptopDTO.IMEI}\nBạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra người dùng chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    scannedCodes.Remove(laptopDTO.IMEI);

                    ThanhTien -= laptopWithGiaBan[laptopDTO.IMEI];

                    txtThanhTien.Text = txtThanhTien.Text = ThanhTien.ToString("N0");

                    CapNhatGia();

                    laptopWithGiaBan.Remove(laptopDTO.IMEI);

                    listSP.Remove(laptopDTO);

                }
                else
                {
                    return;
                }

            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhachHangDTO khachHangDTO = KhachHangBUS.findKhachHang(txtSDT.Text);

                if (khachHangDTO != null)
                {
                    txtID.Text = khachHangDTO.ID_KhachHang;
                    txtKhachHang.Text = khachHangDTO.TenKH;
                    txtDiaChi.Text = khachHangDTO.DiaChiKH;
                    txtTichDiem.Text = khachHangDTO.TichDiem.ToString();

                    CapNhatGia();

                }
                else
                {
                    MessageBox.Show("Thông tin khách chưa được lưu trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSDT.Text = "";
                    txtID.Text = "";
                    txtKhachHang.Text = "";
                    txtDiaChi.Text = "";
                    txtTichDiem.Text = "0";

                    mainForm.OpenChildForm(new KhachHangGUI(mainForm));

                }

                e.Handled = true; // Ngăn xử lý mặc định của phím
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh 'beep'
            }
        }

        private long GiaGiam()
        {
            long GiaGiam = int.Parse(txtTichDiem.Text) * 1000;
            if (ThanhTien < GiaGiam)
            {
                return ThanhTien;
            }
            return GiaGiam;
        }

        private void CapNhatGia()
        {
            GiamGia = GiaGiam();

            txtGiamGia.Text = GiamGia.ToString("N0");

            TongTien = ThanhTien - GiamGia;

            txtTongTien.Text = TongTien.ToString("N0");

            if (!txtTienThoi.Text.Equals("") && !txtKhachDua.Text.Equals(""))
            {
                long KhachDua = long.Parse(txtKhachDua.Text);

                long TienThoi = KhachDua - TongTien;

                txtTienThoi.Text = TienThoi.ToString("N0");
            }


        }

        private void txtKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long KhachDua = long.Parse(txtKhachDua.Text);

                long TienThoi = KhachDua - TongTien;

                txtTienThoi.Text = TienThoi.ToString("N0");

                e.Handled = true; // Ngăn xử lý mặc định của phím
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh 'beep'
            }
        }

        private void Reset()
        {
            // Xóa danh sách đã scan
            scannedCodes.Clear();

            listSP.Clear();

            laptopWithGiaBan.Clear();

            txtSDT.Text = "";
            txtID.Text = "";
            txtKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtTichDiem.Text = "0";

            txtThanhTien.Text = "";
            txtGiamGia.Text = "";
            txtTongTien.Text = "";
            txtKhachDua.Text = "";
            txtTienThoi.Text = "";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            // Thêm hóa đơn


            // Thêm chi tiết hóa đơn

            // Cập nhật tích điểm cho khách hàng


            // Cập nhật trạng thái của laptop

            // Cập nhật số lượng tồn kho

            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Chưa có thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listSP.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();

                lblCamera.Visible = false;
            }



            // CHAP 1: Tạo đối tượng HoaDonDTO
            HoaDonDTO hoaDonDTO = new HoaDonDTO
            {
                NgayLap = DateTime.Now,
                MaNV = mainForm.NhanVienDangNhap,
                MaKH = txtID.Text,
                TongTien = TongTien
            };

            // CHAP 2: Tạo danh sách ChiTietHoaDonDTO
            List<ChiTietHoaDonDTO> chiTietHoaDonList = new List<ChiTietHoaDonDTO>();
            foreach (var sp in listSP)
            {
                ChiTietHoaDonDTO chiTietHoaDon = new ChiTietHoaDonDTO
                {
                    IMEI = sp.IMEI,
                    GiaBan = laptopWithGiaBan[sp.IMEI]
                };
                chiTietHoaDonList.Add(chiTietHoaDon);
            }

            // CHAP 3: Tích điểm


            int DiemHienTai = int.Parse(txtTichDiem.Text);

            int DiemGiam = (int)(GiamGia / 1000);

            int DiemThem = (int)(TongTien / 500000);

            int TichDiemTong = DiemHienTai - DiemGiam + DiemThem;

            // CHAP 4: Cập nhật trạng thái sản phẩm


            // CHAP 5: Cập nhật số lượng tồn kho




            // Gọi BUS để thêm hóa đơn và chi tiết hóa đơn
            if (HoaDonBUS.AddHoaDon(hoaDonDTO, chiTietHoaDonList, TichDiemTong))
            {
                Reset();
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }


    }


}
