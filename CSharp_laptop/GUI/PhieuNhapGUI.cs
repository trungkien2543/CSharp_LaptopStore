using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using Google.Protobuf.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_laptop.GUI
{
    public partial class PhieuNhapGUI : Form
    {
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        private BindingList<PhieuNhapDTO> phieuNhapList;

        private BindingList<ChiTietPhieuNhapDTO> ctPNList = new BindingList<ChiTietPhieuNhapDTO>();

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
            text_IDPN.Texts = idPN.ToString();
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
            combobox_ll.Text = "Chọn";
            combobox_ll.DataSource = new BindingSource(items, null);
            combobox_ll.DisplayMember = "Value";
            combobox_ll.ValueMember = "Key";
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
            text_mess1.Text = "";
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

        private bool CheckIMEI(string imei)
        {
            for (int i = 0; i < ctPNList.Count; i++)
            {
                if (imei == ctPNList[i].IMEI)
                {
                    text_mess1.Text = "IMEI đã tồn tại";
                    return false;
                }
            }
            LaptopBUS abc = new LaptopBUS();
            List<LaptopDTO> lltArr = new List<LaptopDTO>();
            //lltArr = abc.get();
            for (int i = 0; i < lltArr.Count; i++)
            {
                //if (imei == lltArr[i].)
                //{
                //    text_mess1.Text = "IMEI đã tồn tại";
                //    return false;
                //}
            }
            //Thiếu kiểm tra IMEI ở laptop
            text_mess1.Text = "";
            return true;
        }

        //--------------------------//
        //tabControl2

        private int idPN;
        int tgBaoHanh;
        private PhieuNhapDTO phieuNhap;
        private BindingList<LoaiLapPnDTO> lltList = new BindingList<LoaiLapPnDTO>();

        private void But_sp_Click(object sender, EventArgs e)
        {
            string selectedValue = combobox_ll.SelectedValue.ToString();
            text_hang.Texts = selectedValue;
            ChiTietPhieuNhapDTO ctPN = new ChiTietPhieuNhapDTO()
            {
                IMEI = text_hang.Texts + selectedValue + text_IMEI.Texts,
                IDLoaiLaptop = selectedValue,
                GiaNhap = int.Parse(text_gia.Texts),
                ThoiGianBaoHanh = 12
            };
            int kt = 0;
            if (KiemTraGiaNhap())
            {
                kt--;
            }
            if (CheckIMEI(ctPN.IMEI))
            {
                kt--;
            }

            if(kt==0)
            {
                ctPNList.Add(ctPN);
                dataGridView_ctpn1.DataSource = ctPNList;

                if (lltList.Count > 0)
                {
                    int d = 0;
                    for (int i = 0; i < lltList.Count; i++)
                    {
                        if (selectedValue == lltList[i].IDLoaiLaptop)
                        {
                            lltList[i].SoLuong++;
                            lltList.ResetBindings();
                            break;
                        }
                        else
                        {
                            d++;
                        }
                    }
                    if (d == lltList.Count)
                    {
                        string selectedText = combobox_ll.SelectedItem.ToString();
                        string[] parts = selectedText.Split('-');
                        string result = parts[1].Trim();
                        LoaiLapPnDTO llt = new LoaiLapPnDTO()
                        {
                            IDLoaiLaptop = selectedValue,
                            TenSanPham = result,
                            SoLuong = 1
                        };
                        lltList.Add(llt);

                    }
                }
                else
                {
                    string selectedText = combobox_ll.SelectedItem.ToString();
                    string[] parts = selectedText.Split('-');
                    string result = parts[1].Trim();
                    LoaiLapPnDTO llt = new LoaiLapPnDTO()
                    {
                        IDLoaiLaptop = selectedValue,
                        TenSanPham = result,
                        SoLuong = 1
                    };
                    lltList.Add(llt);

                }
                dataGridView_sp.DataSource = lltList;
            }
        }

        private bool KiemTraGiaNhap()
        {
            string input = text_gia.Texts;
            if (int.TryParse(input, out int result))
            {
                if (result > 0)
                {
                    text_mes2.Text = "";
                    return true;
                }
                text_mes2.Text = "Giá phải lớn hơn 0.";
            }
            text_mes2.Text = "Vui lòng nhập giá hợp lệ.";
            return false; 
        }
        private void vbButton3_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO phieuNhap = new PhieuNhapDTO()
            {
                ID = idPN,
                IDNV = comboBox_nv.SelectedValue.ToString(),
                IDNCC = comboBox_ncc.SelectedValue.ToString(),
                TongTien = 0,
                NgayTao = dateTimePicker1.Value.Date
            };
            //MessageBox.Show("value: " + phieuNhap.ID + phieuNhap.IDNCC + phieuNhap.IDNV +" "+ phieuNhap.TongTien + phieuNhap.NgayTao);
            //phieuNhapBUS.AddPhieuNhap(idPN, phieuNhap, ctPNList);
        }
    }
}
