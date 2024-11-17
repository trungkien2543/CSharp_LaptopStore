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

namespace CSharp_laptop.GUI.BanHang
{


    public partial class BanHangForm : Form
    {

        private FilterInfoCollection filterInfoCollection; // Lưu thông tin các thiết bị video

        private VideoCaptureDevice videoCaptureDevice; // Tương tác với thiết bị video

        private string pattern = @"^H\d{3}L\d{3}\d{4}$"; // Mẫu biểu thức chính quy cho IMEI

        private HashSet<string> scannedCodes = new HashSet<string>();

        //scannedCodes.Contains(codeToRemove) scannedCodes.Remove(codeToRemove); Xóa code


        MainForm mainForm;

        private BindingList<LaptopDTO> listSP; // Để tự động cập nhật list

        private LaptopBUS LaptopBUS;



        public BanHangForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            LaptopBUS = new LaptopBUS();

            listSP = new BindingList<LaptopDTO>();

            Load += Form1_Load;

            lblCamera.Visible = false;

            LoadLaptops();

            edittable();
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

        }

        private void LoadLaptops()
        {
            dataGridView2.DataSource = listSP;
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
                        scannedCodes.Add(scannedCode); // Lưu mã vào danh sách đã quét

                        // Xử lý mã mới
                        listSP.Add(LaptopBUS.GetLaptopByIMEI(scannedCode));

                        //MessageBox.Show($"Mã mới được quét: {scannedCode}. Tổng số: {listSP.Count()}",
                        //    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Phát âm thanh báo hiệu
                        PlayBeepSound();

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
            scannedCodes.Clear();
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
    }
}
