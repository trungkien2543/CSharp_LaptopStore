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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class PhieuNhapGUI : Form
    {
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        private BindingList<PhieuNhapDTO> phieuNhapList;

        private List<ChiTietPhieuNhapDTO> ctPNList = new List<ChiTietPhieuNhapDTO>();

        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private HangBUS hangBUS = new HangBUS();
        private LoaiLaptopBUS loaiLaptopBUS = new LoaiLaptopBUS();
        public PhieuNhapGUI()
        {
            InitializeComponent();

        }

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

            LoadPhieuNhapData();
        }

        private void them_but_Click(object sender, EventArgs e)
        {

        }

        private void sua_but_Click(object sender, EventArgs e)
        {

        }

        private void tim_but_Click(object sender, EventArgs e)
        {

        }

        private void But_them_Click(object sender, EventArgs e)
        {


            sp_box.Visible = false;
            idPN = phieuNhapBUS.GetMaxID();
            text_IDPN.Texts = idPN;
            AddNhanVienCBB();
            AddNccCBB();
            tabControl1.SelectedIndex = 1;
        }

        private void AddNhanVienCBB()
        {
            List<NhanVienDTO> nhanVienList = nhanVienBUS.getAllNhanVien();
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int i = 0; i < nhanVienList.Count; i++)
            {
                string id = nhanVienList[i].ID_NhanVien;
                string name = nhanVienList[i].ID_NhanVien + " - " + nhanVienList[i].TenNV;
                items.Add(id, name);
            }

            comboBox_nv.DataSource = new BindingSource(items, null);
            comboBox_nv.DisplayMember = "Value";
            comboBox_nv.ValueMember = "Key";
            comboBox_nv.Text = "Chọn";
        }

        private void AddNccCBB()
        {
            List<HangDTO> hangList = hangBUS.GetHangs();
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int i = 0; i < hangList.Count; i++)
            {
                string id = hangList[i].ID_Hang;
                string name = hangList[i].ID_Hang + " - " + hangList[i].TenHang;
                items.Add(id, name);
            }

            comboBox_ncc.Text = "Chọn";
            comboBox_ncc.DataSource = new BindingSource(items, null);
            comboBox_ncc.DisplayMember = "Value";
            comboBox_ncc.ValueMember = "Key";
        }

        private void AddLoaiLaptopCBB(string hang)
        {
            List<LoaiLaptopDTO> loaiLaptopList = loaiLaptopBUS.GetLoaiLaptopByHang(hang);
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int i = 0; i < loaiLaptopList.Count; i++)
            {
                string id = loaiLaptopList[i].IDLoaiLaptop;
                string name = loaiLaptopList[i].IDLoaiLaptop + " - " + loaiLaptopList[i].TenSP;
                items.Add(id, name);
            }
            combohox_ll.Text = "Chọn";
            combohox_ll.DataSource = new BindingSource(items, null);
            combohox_ll.DisplayMember = "Value";
            combohox_ll.ValueMember = "Key";
        }

        private void huy_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void them_sp_pn_but_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        //private void tabControl1_Resize(object sender, EventArgs e)
        //{
        //    panel6.Width = (int)(tabPage2.Width * 0.4); // 40% của Panel Main
        //    panel7.Width = (int)(tabPage2.Width * 0.6); // 60% của Panel Main
        //}

        private void tabPage2_Resize(object sender, EventArgs e)
        {

            panel6.Width = (int)(tabPage2.Width * 0.4); // 40% của Panel Main
            panel7.Width = (int)(tabPage2.Width * 0.6); // 60% của Panel Main
            //km_pan.Width = 600;

        }

        private void huy_but_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void them_sp_but_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox_ncc.SelectedValue.ToString();
            text_hang.Texts = selectedValue;
            AddLoaiLaptopCBB(selectedValue);
            sp_box.Visible = true;
        }

        private void but_trolai_Click(object sender, EventArgs e)
        {
            sp_box.Visible = false;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPhieuNhapData()
        {
            phieuNhapList = phieuNhapBUS.GetAllPhieuNhap();
            //MessageBox.Show("abc" + phieuNhapList[0].ID);
            dataGridView_PN.DataSource = phieuNhapList;
        }

        private string idPN;
        private void But_sp_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhapDTO ctPN = new ChiTietPhieuNhapDTO()
            {
                IMEI = text_IMEI.Texts,
                GiaNhap = int.Parse(text_gia.Texts),
                IDPN = idPN
            };
            ctPNList.Add(ctPN);
            dataGridView_ctpn1.DataSource = ctPNList;
            //MessageBox.Show("abc: " + ctPN.IMEI + " " + ctPN.GiaNhap + " " + ctPN.IDPN);
        }
    }
}
