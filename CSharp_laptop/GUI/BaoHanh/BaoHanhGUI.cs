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
            

            tb_ghichu.ReadOnly = true;
            tb_mabh.ReadOnly = true;
        }

        private void load_bh()      // lấy thông tin bảo hành từ imei
        {
            List<BaoHanhDTO> baoHanhs = baoHanhBUS.GetAllBaoHanhsByIMEI(lb_imei.Text);

            dataGridView2.DataSource = baoHanhs;

        }

        private void load_inforlap()        // lấy thông tin laptop từ imei
        {
            laptop = laptopBUS.GetLaptopByIMEI(tb_IMEI.Text);
            if (laptop == null)                 // nếu không tìm được bảo hành
            {
                lb_imei.Text = "";
                lb_ten.Text = "";
                lb_tgianbh.Text = "";
                lb_nbd.Text = "";
                lb_nkt.Text = "";
                lb_tt.Text = "";
                reset_textbox();
                tb_chucnang.Text = "Chưa chọn";
                btn_luu.Enabled = false;
                btn_them.Enabled = false;
                btn_edit.Enabled = false;
            }
            else
            {                                       // nếu tìm được
                lb_imei.Text = laptop.IMEI;
                lb_tgianbh.Text = laptop.ThoiGianBaoHanh.ToString();

                LoaiLaptopDTO loaiLaptopDTO = loaiLaptopBUS.GetLaptopByID(laptop.LoaiLaptop); // tìm tên laptop từ loại laptop
                lb_ten.Text = loaiLaptopDTO.TenSP;

                lb_tt.Text = (laptop.TrangThai == 0) ? "Đã bán" : "Chưa bán";
                reset_textbox();
                tb_chucnang.Text = "Chưa chọn";
                btn_luu.Enabled = false;
                btn_them.Enabled = true;
                btn_edit.Enabled = true;
            }

        }


        private void load_date_baohanh()        // tính hạn bảo hành
        {
            string imei = lb_imei.Text.Trim();

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

        private void vbButton2_Click(object sender, EventArgs e)        // nút tìm kiếm
        {
            load_inforlap();
            load_bh();
            load_date_baohanh();
            edittable();
            
        }

        private void edittable()
        {

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            dataGridView2.Columns["IMEI"].Visible = false;

            dataGridView2.Columns["MaBaoHanh"].HeaderText = "Mã bảo hành";
            dataGridView2.Columns["IMEI"].HeaderText = "Mã IMEI";
            dataGridView2.Columns["NgayBaoHanh"].HeaderText = "Ngày bảo hành";
            dataGridView2.Columns["NgayTra"].HeaderText = "Ngày trả";
            dataGridView2.Columns["GhiChu"].HeaderText = "Chi chú";

        }

        private void reset_textbox()
        {
            tb_mabh.Text = "";
            tb_ghichu.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chucnang = "update";
                tb_chucnang.Text = "Chỉnh sửa thông tin bảo hành";
                tb_ghichu.ReadOnly = false;
                btn_luu.Enabled = true;

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                tb_ghichu.Text = row.Cells["GhiChu"].Value.ToString();
                tb_mabh.Text = row.Cells["MaBaoHanh"].Value.ToString();

                guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayBaoHanh"].Value);
                guna2DateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)        // kích hoạt chức năng thêm
        {
            chucnang = "add";
            tb_chucnang.Text = "Thêm bảo hành mới";
            reset_textbox();
            tb_ghichu.ReadOnly = false;
            btn_luu.Enabled = true;
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            if (chucnang == "add")
            {
                try
                {
                    DateTime? warrantyEndDate = hoaDonBUS.GetWarrantyEndDate(lb_imei.Text);     // Lấy thông tin ngày kết thúc bảo hành

                    if (warrantyEndDate.HasValue && DateTime.Now > warrantyEndDate.Value)       // Kiểm tra nếu đã hết hạn bảo hành
                    {
                        MessageBox.Show("Sản phẩm đã hết thời gian bảo hành, không thể thêm bảo hành mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Dừng thực hiện chức năng "add"
                    }

                    if (tb_ghichu.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin bảo hành đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ;
                    }

                    DialogResult confirmResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn thêm bảo hành?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        BaoHanhDTO baoHanh = new BaoHanhDTO
                        {
                            IMEI = lb_imei.Text,
                            NgayBaoHanh = guna2DateTimePicker1.Value,
                            NgayTra = guna2DateTimePicker2.Value,
                            GhiChu = tb_ghichu.Text
                        };

                        if (baoHanhBUS.AddBaoHanh(baoHanh))
                        {
                            MessageBox.Show("Thêm bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_inforlap();
                            reset_textbox();
                            load_bh();
                        }
                        else
                        {
                            MessageBox.Show("Thêm bảo hành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thao tác đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        IMEI = lb_imei.Text,
                        NgayBaoHanh = guna2DateTimePicker1.Value,
                        NgayTra = guna2DateTimePicker2.Value,
                        GhiChu = tb_ghichu.Text
                    };

                    if (baoHanhBUS.UpdateBaoHanh(baoHanh))
                    {
                        MessageBox.Show("Cập nhật bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_bh();
                        load_inforlap();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bảo hành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn 1 thông tin bảo hành trong bảng rồi mới cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vbButton4_Click(object sender, EventArgs e)        // nút edit
        {
            chucnang = "update";
            tb_chucnang.Text = "Chỉnh sửa thông tin bảo hành";
            btn_luu.Enabled = true;
        }
    }
}
