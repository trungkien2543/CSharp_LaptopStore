﻿using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using Google.Protobuf.Collections;
using LaptopStore.DTO;
using Microsoft.VisualBasic;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_laptop.GUI
{
    public partial class PhieuNhapGUI : Form
    {
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();

        private BindingList<PhieuNhapDTO> phieuNhapList;


        private NhanVienBUS nhanVienBUS = new NhanVienBUS();

        private HangBUS hangBUS = new HangBUS();

        private LoaiLaptopBUS loaiLaptopBUS = new LoaiLaptopBUS();

        private MainForm mainForm;

        public PhieuNhapGUI(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

        }

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
            // Ẩn header của tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;// Đặt chế độ hiển thị các tab thành dạng phẳng
            tabControl1.ItemSize = new Size(0, 1);// Đặt chiều cao của các tab headers thành 1 pixel để ẩn chúng
            tabControl1.SizeMode = TabSizeMode.Fixed;// Đảm bảo kích thước các tab được cố định, không tự thay đổi

            LoadPhieuNhapData();
            Customtable();
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
            //items.Add(id, name);

            for (int i = 0; i < nhanVienList.Count; i++)
            {
                string id = nhanVienList[i].ID_NhanVien;
                string name = nhanVienList[i].ID_NhanVien + " - " + nhanVienList[i].TenNV;
                items.Add(id, name);
            }

            comboBox_nv.DataSource = new BindingSource(items, null);
            comboBox_nv.DisplayMember = "Value";
            comboBox_nv.ValueMember = "Key";
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

        // Thêm sp vào phiếu nè
        bool ChonHang = false;
        int sttHang;

        private void them_sp_but_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox_ncc.SelectedValue.ToString();
            text_hang.Texts = selectedValue;
            text_kt_gia.Text = "";
            text_kt_IMEI.Text = "";
            AddLoaiLaptopCBB(selectedValue);
            sp_box.Visible = true;
            ChonHang = true;
            sttHang = comboBox_ncc.SelectedIndex;
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
        //private bool CheckIMEI(string imei)
        //{
        //    for (int i = 0; i < ctPNList.Count; i++)
        //    {
        //        if (imei == ctPNList[i].IMEI)
        //        {
        //            text_mess1.Text = "IMEI đã tồn tại";
        //            return false;
        //        }
        //    }
        //    LaptopBUS abc = new LaptopBUS();
        //    List<LaptopDTO> lltArr = new List<LaptopDTO>();
        //    //lltArr = abc.get();
        //    for (int i = 0; i < lltArr.Count; i++)
        //    {
        //        //if (imei == lltArr[i].)
        //        //{
        //        //    text_mess1.Text = "IMEI đã tồn tại";
        //        //    return false;
        //        //}
        //    }
        //    //Thiếu kiểm tra IMEI ở laptop
        //    text_mess1.Text = "";
        //    return true;
        //}

        //--------------------------//
        //tabControl2

        private int idPN;
        int tgBaoHanh;
        private PhieuNhapDTO phieuNhap;
        private BindingList<ChiTietPhieuNhapDTO> ctPNList = new BindingList<ChiTietPhieuNhapDTO>();
        private BindingList<LoaiLapPnDTO> lltList = new BindingList<LoaiLapPnDTO>();

        private void But_sp_Click(object sender, EventArgs e)
        {
            int kt = 0;
            string idLoaiLap = combobox_ll.SelectedValue.ToString();
            string imei = text_hang.Texts + idLoaiLap + text_IMEI.Texts;

            if (KiemTraGiaNhap())
            {
                kt++;
            }

            if (CheckIMEI(imei))
            {
                kt++;
            }

            if (kt == 2)
            {
                ChiTietPhieuNhapDTO ctPN = new ChiTietPhieuNhapDTO()
                {
                    IMEI = imei,
                    IDLoaiLaptop = idLoaiLap,
                    GiaNhap = int.Parse(text_gia.Texts),
                    ThoiGianBaoHanh = comboBox_tgbh.SelectedIndex
                };
                //MessageBox.Show("kq: " + ctPN.IMEI + ctPN.IDLoaiLaptop + ctPN.GiaNhap + ctPN.ThoiGianBaoHanh);
                ctPNList.Add(ctPN);
                dataGridView_ctpn.DataSource = ctPNList;

                if (lltList.Count > 0)
                {
                    int d = 0;
                    for (int i = 0; i < lltList.Count; i++)
                    {
                        if (idLoaiLap == lltList[i].IDLoaiLaptop)
                        {
                            lltList[i].SoLuong++;
                            lltList[i].ThanhTien = lltList[i].GiaNhap * lltList[i].SoLuong;
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
                            IDLoaiLaptop = idLoaiLap,
                            TenSanPham = result,
                            ThoiGianBaoHanh = int.Parse(comboBox_tgbh.SelectedIndex.ToString()),
                            GiaNhap = int.Parse(text_gia.Texts.ToString()),
                            SoLuong = 1,
                            ThanhTien = int.Parse(text_gia.Texts.ToString())
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
                        IDLoaiLaptop = idLoaiLap,
                        TenSanPham = result,
                        ThoiGianBaoHanh = int.Parse(comboBox_tgbh.SelectedIndex.ToString()),
                        GiaNhap = int.Parse(text_gia.Texts.ToString()),
                        SoLuong = 1,
                        ThanhTien = int.Parse(text_gia.Texts.ToString())
                    };
                    lltList.Add(llt);

                }
                dataGridView_sp.DataSource = lltList;
            }

            text_tongtien.Texts = TongTIen().ToString();
        }

        private int TongTIen()
        {
            int tt = 0;
            for (int i = 0; i < lltList.Count; i++)
            {
                tt += lltList[i].ThanhTien;
            }
            return tt;
        }
        private bool CheckIMEI(string imei)// Kiểm tra IMEI
        {
            if (text_IMEI.Texts == "")
            {
                text_kt_IMEI.Text = "Vui lòng nhập IMEI.";
                return false;
            }

            for (int i = 0; i < ctPNList.Count; i++)
            {
                if (imei == ctPNList[i].IMEI)
                {
                    text_kt_IMEI.Text = "IMEI đã tồn tại";
                    return false;
                }
            }

            if (phieuNhapBUS.CheckIMEI(imei))
            {
                text_kt_IMEI.Text = "IMEI đã tồn tại trong DB";
                return false;
            }

            text_kt_IMEI.Text = "";
            return true;
        }

        private bool KiemTraGiaNhap()
        {
            string input = text_gia.Texts;
            if (int.TryParse(input, out int result))
            {
                if (result > 0)
                {
                    text_kt_gia.Text = "";
                    return true;
                }
                text_kt_gia.Text = "Giá phải lớn hơn 0.";
            }
            text_kt_gia.Text = "Vui lòng nhập giá hợp lệ.";
            return false;
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO phieuNhap = new PhieuNhapDTO()
            {
                ID = idPN,
                IDNV = mainForm.NhanVienDangNhap,
                IDNCC = comboBox_ncc.SelectedValue.ToString(),
                TongTien = 0,
                NgayTao = dateTimePicker1.Value.Date
            };
            //MessageBox.Show("value: " + phieuNhap.ID + phieuNhap.IDNCC + phieuNhap.IDNV +" "+ phieuNhap.TongTien + phieuNhap.NgayTao);
            phieuNhapBUS.AddPhieuNhap(phieuNhap, ctPNList, lltList);
        }

        private void comboBox_ncc_Click(object sender, EventArgs e)
        {
            if (ChonHang == true)
            {
                DialogResult result = MessageBox.Show("Thay đổi nhà cung cấp sẽ mất dữ liệu?", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ChonHang = false;
                    ctPNList.Clear();
                    lltList.Clear();
                }
                else
                {
                    ChonHang = false;
                    comboBox_ncc.SelectedIndex = sttHang;
                    ChonHang = true;
                }
            }
            //if (ChonHang == true)
            //{
            //    MessageBox.Show("thay NCC");
            //    ctPNList.Clear();
            //    lltList.Clear();
            //}
            //phieuNhapBUS.AddPhieuNhap(idPN, phieuNhap, ctPNList);
        }

        void Customtable()
        {
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏️";
            btnEdit.Width = 60;
            btnEdit.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView_PN.Columns.Add(btnEdit);

            // Thêm cột nút "Xóa"
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.Width = 60;
            btnDelete.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView_PN.Columns.Add(btnDelete);

            DataGridViewButtonColumn btnDelete1 = new DataGridViewButtonColumn();
            btnDelete1.Name = "btnDelete";
            btnDelete1.HeaderText = "Xóa";
            btnDelete1.Text = "❌";
            btnDelete1.Width = 60;
            btnDelete1.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView_ctpn.Columns.Add(btnDelete1);

            DataGridViewButtonColumn btnDelete3 = new DataGridViewButtonColumn();
            btnDelete3.Name = "btnDelete";
            btnDelete3.HeaderText = "Xóa";
            btnDelete3.Text = "❌";
            btnDelete3.Width = 60;
            btnDelete3.UseColumnTextForButtonValue = true; // Hiển thị text thay vì giá trị của ô
            btnDelete3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView_sp.Columns.Add(btnDelete3);
        }

        private void dataGridView_ctpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_ctpn.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_ctpn.Rows[e.RowIndex];
                string idLoaiLaptop = row.Cells["IDllt"].Value.ToString();

                ctPNList.Remove((ChiTietPhieuNhapDTO)row.DataBoundItem);
                for (int i = 0; i < lltList.Count; i++)
                {
                    if (lltList[i].IDLoaiLaptop == idLoaiLaptop)
                    {
                        lltList[i].SoLuong--;
                        lltList.ResetBindings();
                        break;
                    }
                }
            }
        }

        private void dataGridView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_sp.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_sp.Rows[e.RowIndex];
                string idLoaiLaptop = row.Cells["IDllt2"].Value.ToString();

                lltList.Remove((LoaiLapPnDTO)row.DataBoundItem);
                for (int i = ctPNList.Count - 1; i >= 0; i--)
                {
                    if (idLoaiLaptop == ctPNList[i].IDLoaiLaptop)
                    {
                        ctPNList.RemoveAt(i);
                    }
                }

            }
        }

        private void dataGridView_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_PN.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_PN.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                if(phieuNhapBUS.CheckSPPN(id))
                {

                }
                else
                {
                    MessageBox.Show("Không thể sửa Phiếu nhập vì có sản phẩm đã bán");
                }
            }
            //if (e.ColumnIndex == dataGridView_PN.Columns["btnDelete"].Index && e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = KM_dataGridView.Rows[e.RowIndex];

            //    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận",
            //                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (result == DialogResult.Yes)
            //    {
            //        //string id = row.Cells["ID"].Value.ToString();
            //        //khuyenMaiBUS.DeleteKhuyenMai(id);

            //        khuyenMaiList.Remove((KhuyenMaiDTO)row.DataBoundItem);
            //    }
            //    else
            //    {

            //    }
            //}
        }
    }
}
