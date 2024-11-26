using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
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

namespace CSharp_laptop.GUI.Laptop
{
    public partial class BaoHanhGUI : Form
    {
        private MainForm mainForm;
        private BaoHanhBUS baoHanhBUS = new BaoHanhBUS();
        private LaptopBUS laptopBUS = new LaptopBUS();
        private LoaiLaptopBUS loaiLaptopBUS = new LoaiLaptopBUS();
        string chucnang;

        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        LaptopDTO laptop;

        public BaoHanhGUI(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            edittable();

            tb_ghichu.ReadOnly = true;
            tb_mabh.ReadOnly = true;
        }

        private void load_bh()
        {
            List<BaoHanhDTO> baoHanhs = baoHanhBUS.GetAllBaoHanhsByIMEI(tb_timkiem.Text);
            
            dataGridView2.DataSource = baoHanhs;

        }

        private void load_inforlap()
        {
            laptop = laptopBUS.GetLaptopByIMEI(tb_timkiem.Text);
            if (laptop == null)
            {
                MessageBox.Show("IMEI chưa trùng khớp");
                lb_imei.Text = "";
                lb_ten.Text = "";
                lb_tgianbh.Text = "";
                lb_nbd.Text = "";
                lb_nkt.Text = "";
                lb_tt.Text = "";
            }
            else
            {
                lb_imei.Text = laptop.IMEI;
                lb_tgianbh.Text = laptop.ThoiGianBaoHanh.ToString();
                lb_tt.Text = laptop.TrangThai.ToString();

                LoaiLaptopDTO loaiLaptopDTO = loaiLaptopBUS.GetLaptopByID(laptop.LoaiLaptop);
                lb_ten.Text = loaiLaptopDTO.TenSP;
            }

        }


        private void load_date_baohanh()
        {
            string imei = tb_timkiem.Text.Trim();

            HoaDonDTO hoadon = hoaDonBUS.GetHoaDonByIMEI(imei);

            if (hoadon != null)
            {
                lb_nbd.Text = hoadon.NgayLap.Value.ToString("yyyy-MM-dd");
            }


            DateTime? warrantyEndDate = hoaDonBUS.GetWarrantyEndDate(imei);

            if (warrantyEndDate.HasValue)
            {
                lb_nkt.Text = warrantyEndDate.Value.ToString("yyyy-MM-dd");
            }


        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            load_bh();
            load_inforlap();
            load_date_baohanh();
        }

        private void edittable()
        {

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            //dataGridView2.Columns["IMEI"].Visible = false;

            
        }

        private void reset()
        {
            tb_mabh.Text = "";
            tb_ghichu.Text = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chucnang = "update";
                tb_ghichu.ReadOnly = false;

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                tb_ghichu.Text = row.Cells["GhiChu"].Value.ToString();
                tb_mabh.Text = row.Cells["MaBaoHanh"].Value.ToString();

                guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayBaoHanh"].Value);
                guna2DateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            chucnang = "add";
            reset();
            tb_ghichu.ReadOnly = false;
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            if (chucnang == "add")
            {
                try
                {
                    // Lấy thông tin ngày kết thúc bảo hành
                    DateTime? warrantyEndDate = hoaDonBUS.GetWarrantyEndDate(tb_timkiem.Text);

                    // Kiểm tra nếu đã hết hạn bảo hành
                    if (warrantyEndDate.HasValue && DateTime.Now > warrantyEndDate.Value)
                    {
                        MessageBox.Show("Sản phẩm đã hết thời gian bảo hành, không thể thêm bảo hành mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Dừng thực hiện chức năng "add"
                    }

                    BaoHanhDTO baoHanh = new BaoHanhDTO
                    {
                        IMEI = tb_timkiem.Text,
                        NgayBaoHanh = guna2DateTimePicker1.Value,
                        NgayTra = guna2DateTimePicker2.Value,
                        GhiChu = tb_ghichu.Text
                    };

                    if (baoHanhBUS.AddBaoHanh(baoHanh))
                    {
                        MessageBox.Show("Thêm bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_inforlap();
                        reset();
                        load_bh();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bảo hành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                //MessageBox.Show("Update");
                try
                {
                    BaoHanhDTO baoHanh = new BaoHanhDTO
                    {
                        MaBaoHanh = long.Parse(tb_mabh.Text), // Ensure this is filled in correctly
                        IMEI = tb_timkiem.Text,
                        NgayBaoHanh = guna2DateTimePicker1.Value,
                        NgayTra = guna2DateTimePicker2.Value,
                        GhiChu = tb_ghichu.Text
                    };

                    if (baoHanhBUS.UpdateBaoHanh(baoHanh))
                    {
                        MessageBox.Show("Cập nhật bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_bh();
                        load_inforlap() ;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bảo hành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
