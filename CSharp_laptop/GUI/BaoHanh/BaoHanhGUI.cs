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

        public BaoHanhGUI(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            edittable();

        }

        private void vbButton3_Click_1(object sender, EventArgs e)
        {
            vbButton1.Enabled = true;
        }

        private void vbButton1_Click(object sender, EventArgs e)        // Thêm bảo hành mới
        {
            MessageBox.Show("đã nhấn");
        }

        private void check_bh()
        {
            List<BaoHanhDTO> baoHanhs = baoHanhBUS.GetAllBaoHanhsByIMEI(rjTextBox1.Texts);
            if (baoHanhs.Count == 0)
            {
                Console.WriteLine("No warranty records found for this IMEI.");
            }
            else
            {
                dataGridView2.DataSource = baoHanhs;
            }

        }

        private void load_inforlap()
        {
            LaptopDTO laptop = laptopBUS.GetLaptopByIMEI(rjTextBox1.Texts);
            if (laptop == null)
            {
                Console.WriteLine("No laptop found with this IMEI.");
            }
            else
            {
                label10.Text = laptop.IMEI;
                label12.Text = laptop.ThoiGianBaoHanh.ToString();
                label9.Text = laptop.TrangThai;

                LoaiLaptopDTO loaiLaptopDTO = loaiLaptopBUS.GetLaptopByID(laptop.LoaiLaptop);
                label13.Text = loaiLaptopDTO.TenSP;
            }

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            check_bh();
            load_inforlap();
        }

        private void edittable()
        {

            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            //dataGridView2.Columns["IMEI"].Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chucnang = "update";

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                rjTextBox2.Texts = row.Cells["NgayBaoHanh"].Value.ToString();
                rjTextBox3.Texts = row.Cells["NgayTra"].Value.ToString();
                rjTextBox4.Texts = row.Cells["GhiChu"].Value.ToString();


            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            chucnang = "add";
            rjTextBox2.Texts = "";
            rjTextBox3.Texts = "";
            rjTextBox4.Texts = "";
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            if (chucnang == "add")
            {
                MessageBox.Show("Thêm");
            } 
            else 
            {
                MessageBox.Show("Update");
            }
        }
    }
}
