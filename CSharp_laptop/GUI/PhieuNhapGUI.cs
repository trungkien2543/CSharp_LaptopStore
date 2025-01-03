﻿using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using Google.Protobuf.Collections;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using LaptopStore.DTO;
using Microsoft.VisualBasic;
using OfficeOpenXml;
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

        private ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();

        private BindingList<PhieuNhapDTO> phieuNhapList;

        private BindingList<ChiTietPhieuNhapDTO> chiTietPhieuNhapDTOs = new BindingList<ChiTietPhieuNhapDTO>();


        private NhanVienBUS nhanVienBUS = new NhanVienBUS();

        private HangBUS hangBUS = new HangBUS();

        private LoaiLaptopBUS loaiLaptopBUS = new LoaiLaptopBUS();

        private MainForm mainForm;

        public PhieuNhapGUI(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            btnPDF.Visible = false;

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

        //private void them_but_Click(object sender, EventArgs e)
        //{

        //}

        //private void sua_but_Click(object sender, EventArgs e)
        //{

        //}

        //private void tim_but_Click(object sender, EventArgs e)
        //{

        //}

        private void But_them_Click(object sender, EventArgs e)
        {
            funcion = "add";
            sp_box.Visible = false;
            idPN = phieuNhapBUS.GetMaxID();
            text_IDPN.Texts = idPN.ToString();
            text_nv.Texts = mainForm.NhanVienDangNhap.TenDN;
            AddNccCBB();
            dataGridView_ctpn.Columns["btnDelete"].Visible = true;
            dataGridView_sp.Columns["btnDelete"].Visible = true;

            tabControl1.SelectedIndex = 1;

            btnPDF.Visible = false;
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

        string funcion = "";
        private void huy_but_Click_1(object sender, EventArgs e)
        {
            if (funcion == "add")
            {
                if (lltList.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Thoát sẽ xóa hết dữ liệu đã nhập", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        ChonHang = false;
                        text_tongtien.Texts = "";
                        ctPNList.Clear();
                        lltList.Clear();
                        but_them_sp.Visible = true;
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {

                    }
                }
                else
                {
                    tabControl1.SelectedIndex = 0;
                }
            }
            else
            {
                ChonHang = false;
                text_tongtien.Texts = "";
                ctPNList.Clear();
                lltList.Clear();
                but_them_sp.Visible = true;
                tabControl1.SelectedIndex = 0;
            }
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

            chiTietPhieuNhapDTOs = chiTietPhieuNhapBUS.GetChiTietPhieuNhapWithPhieuNhap("");
            //MessageBox.Show("abc" + phieuNhapList[0].ID);
            dataGridView_PN.DataSource = phieuNhapList;
        }

        //--------------------------//
        //tabControl2

        private int idPN;
        int tgBaoHanh;
        private PhieuNhapDTO phieuNhap;
        private BindingList<ChiTietPhieuNhap> ctPNList = new BindingList<ChiTietPhieuNhap>();
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
                ChiTietPhieuNhap ctPN = new ChiTietPhieuNhap()
                {
                    IMEI = imei,
                    IDLoaiLaptop = idLoaiLap,
                    GiaNhap = int.Parse(text_gia.Texts),
                    ThoiGianBaoHanh = int.Parse(comboBox_tgbh.Text.ToString())
                };
                ctPNList.Add(ctPN);
                dataGridView_ctpn.DataSource = ctPNList;

                if (lltList.Count > 0)
                {
                    int d = 0;
                    for (int i = 0; i < lltList.Count; i++)
                    {
                        if (idLoaiLap == lltList[i].IDLoaiLaptop)
                        {
                            lltList[i].ThoiGianBaoHanh = int.Parse(comboBox_tgbh.Text.ToString());
                            lltList[i].GiaNhap = int.Parse(text_gia.Texts.ToString());
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
                            ThoiGianBaoHanh = int.Parse(comboBox_tgbh.Text.ToString()),
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
                        ThoiGianBaoHanh = int.Parse(comboBox_tgbh.Text.ToString()),
                        GiaNhap = int.Parse(text_gia.Texts.ToString()),
                        SoLuong = 1,
                        ThanhTien = int.Parse(text_gia.Texts.ToString())
                    };
                    lltList.Add(llt);
                }
                UpdateGiaNhap();
                text_IMEI.Texts = "";
                dataGridView_ctpn.DataSource = ctPNList;
                dataGridView_sp.DataSource = lltList;
                TongTIen();
            }
        }
        private void UpdateGiaNhap()
        {
            for (int i = 0; i < ctPNList.Count; i++)
            {
                if (combobox_ll.SelectedValue.ToString() == ctPNList[i].IDLoaiLaptop)
                {
                    ctPNList[i].ThoiGianBaoHanh = int.Parse(comboBox_tgbh.Text.ToString());
                    ctPNList[i].GiaNhap = int.Parse(text_gia.Texts.ToString());
                }
            }
        }

        private void TongTIen()
        {
            Int128 tt = 0;
            if (lltList.Count > 0)
            {
                for (int i = 0; i < lltList.Count; i++)
                {
                    tt += lltList[i].ThanhTien;
                }
            }
            text_tongtien.Texts = string.Format("{0:N0} VND", tt);
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
            if (Int32.TryParse(input, out int result))
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
            if (funcion == "add")
            {
                ChonHang = false;
                if (lltList.Count > 0)
                {
                    int tt = 0;
                    for (int i = 0; i < lltList.Count; i++)
                    {
                        tt += lltList[i].ThanhTien;
                    }
                    PhieuNhapDTO phieuNhap1 = new PhieuNhapDTO()
                    {
                        ID = idPN,
                        IDNV = mainForm.NhanVienDangNhap.TenDN,
                        IDNCC = comboBox_ncc.SelectedValue.ToString(),
                        TongTien = tt,
                        NgayTao = dateTimePicker1.Value.Date
                    };
                    phieuNhapBUS.AddPhieuNhap(phieuNhap1, ctPNList, lltList);

                    LoadPhieuNhapData();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Bạn chưa thêm sản phẩm!!!");
                }
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void comboBox_ncc_Click(object sender, EventArgs e)
        {
            if (ChonHang == true)
            {
                if (lltList.Count > 0)
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
                    }
                }
            }
        }

        void Customtable()
        {
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

                ctPNList.Remove((ChiTietPhieuNhap)row.DataBoundItem);
                for (int i = 0; i < lltList.Count; i++)
                {
                    if (lltList[i].IDLoaiLaptop == idLoaiLaptop)
                    {
                        lltList[i].SoLuong--;
                        lltList[i].ThanhTien -= lltList[i].GiaNhap;
                        lltList.ResetBindings();
                        break;
                    }
                }
                TongTIen();
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
                TongTIen();
            }
        }

        private void dataGridView_PN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            funcion = "view";
            DataGridViewRow row = dataGridView_PN.Rows[e.RowIndex];
            int id = int.Parse(row.Cells["ID"].Value.ToString());

            but_them_sp.Visible = false;
            phieuNhap = phieuNhapBUS.GetPhieuNhapByID(id);
            ctPNList = phieuNhapBUS.GetChiTietPhieuNhap1(id);
            lltList = phieuNhapBUS.GetChiTietPhieuNhap2(id);

            text_IDPN.Texts = phieuNhap.ID.ToString();
            text_nv.Texts = phieuNhap.IDNV.ToString();
            comboBox_ncc.DataSource = null;
            comboBox_ncc.Items.Clear();
            comboBox_ncc.Text = phieuNhap.IDNCC.ToString();
            dateTimePicker1.Value = phieuNhap.NgayTao;

            TongTIen();

            dataGridView_ctpn.DataSource = ctPNList;
            dataGridView_sp.DataSource = lltList;

            dataGridView_ctpn.Columns["btnDelete"].Visible = false;
            dataGridView_sp.Columns["btnDelete"].Visible = false;

            tabControl1.SelectedIndex = 1;

            btnPDF.Visible = true;
        }


        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()  // export excel
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add("Danh sách phiếu nhập");

                // Thêm tiêu đề ở dòng đầu tiên
                worksheet.Cells["A1:E1"].Merge = true; // Hợp nhất các ô từ A1 đến G1
                worksheet.Cells["A1"].Value = "DANH SÁCH PHIẾU NHẬP"; // Nội dung tiêu đề
                worksheet.Cells["A1"].Style.Font.Size = 18; // Font chữ lớn
                worksheet.Cells["A1"].Style.Font.Bold = true; // In đậm
                worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                worksheet.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa theo chiều dọc
                worksheet.Row(1).Height = 40; // Tăng chiều cao dòng tiêu đề

                // Thêm header vào Excel (dòng thứ hai)
                worksheet.Cells[2, 1].Value = "ID phiếu nhập";
                worksheet.Cells[2, 2].Value = "ID nhân viên";
                worksheet.Cells[2, 3].Value = "ID nhà cung cấp";
                worksheet.Cells[2, 4].Value = "Tổng tiền";
                worksheet.Cells[2, 5].Value = "Ngày tạo";

                // Định dạng header
                using (var range = worksheet.Cells[2, 1, 2, 5]) // Phạm vi các ô header
                {
                    range.Style.Font.Bold = true; // In đậm
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                    range.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid; // Nền solid
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Màu nền xám nhạt
                    range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin); // Viền
                }

                // Đổ dữ liệu từ danh sách vào Excel (bắt đầu từ dòng 3)
                for (int i = 0; i < phieuNhapList.Count; i++)
                {
                    var PN = phieuNhapList[i];
                    worksheet.Cells[i + 3, 1].Value = PN.ID;
                    worksheet.Cells[i + 3, 2].Value = PN.IDNV;
                    worksheet.Cells[i + 3, 3].Value = PN.IDNCC;
                    worksheet.Cells[i + 3, 4].Value = PN.TongTien;
                    worksheet.Cells[i + 3, 5].Value = PN.NgayTao.ToString("yyyy-MM-dd HH:mm:ss");

                }

                // Kẻ bảng và căn giữa dữ liệu
                var dataRange = worksheet.Cells[2, 1, phieuNhapList.Count + 2, 5]; // Phạm vi bảng (bao gồm header và dữ liệu)
                dataRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                dataRange.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                dataRange.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc

                // Tự động căn chỉnh kích thước cột
                worksheet.Cells.AutoFitColumns();



                // Thêm chi tiết hóa đơn
                // Tạo một worksheet
                var worksheet1 = package.Workbook.Worksheets.Add("Chi tiết phiếu nhập");

                // Thêm tiêu đề ở dòng đầu tiên
                worksheet1.Cells["A1:C1"].Merge = true; 
                worksheet1.Cells["A1"].Value = "DANH SÁCH CHI TIẾT PHIẾU NHẬP"; // Nội dung tiêu đề
                worksheet1.Cells["A1"].Style.Font.Size = 14; // Font chữ lớn
                worksheet1.Cells["A1"].Style.Font.Bold = true; // In đậm
                worksheet1.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                worksheet1.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa theo chiều dọc
                worksheet1.Row(1).Height = 40; // Tăng chiều cao dòng tiêu đề

                // Thêm header vào Excel
                worksheet1.Cells[2, 1].Value = "Mã IMEI";
                worksheet1.Cells[2, 2].Value = "Mã phiếu nhập";
                worksheet1.Cells[2, 3].Value = "Giá bán";

                // Định dạng header
                using (var range = worksheet1.Cells[2, 1, 2, 3]) // Phạm vi các ô header
                {
                    range.Style.Font.Bold = true; // In đậm
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                    range.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid; // Nền solid
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Màu nền xám nhạt
                    range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin); // Viền
                }

                // Đổ dữ liệu từ danh sách vào Excel
                for (int i = 0; i < chiTietPhieuNhapDTOs.Count; i++)
                {
                    var chiTietHoaDon = chiTietPhieuNhapDTOs[i];
                    worksheet1.Cells[i + 3, 1].Value = chiTietHoaDon.IMEI;
                    worksheet1.Cells[i + 3, 2].Value = chiTietHoaDon.ID_PhieuNhap;
                    worksheet1.Cells[i + 3, 3].Value = chiTietHoaDon.GiaNhap;
                }

                // Kẻ bảng và căn giữa dữ liệu
                var dataRange1 = worksheet1.Cells[2, 1, chiTietPhieuNhapDTOs.Count + 2, 3]; // Phạm vi bảng (bao gồm header và dữ liệu)
                dataRange1.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange1.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange1.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                dataRange1.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                dataRange1.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa
                dataRange1.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center; // Căn giữa dọc

                // Tự động căn chỉnh kích thước cột
                worksheet1.Cells.AutoFitColumns();

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DanhSachPhieuNhap.xlsx"; // Tên file mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file Excel tại vị trí người dùng chọn
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Xuất Excel thành công! File đã được lưu tại: " + Path.GetFullPath(filePath));
                }
            }
        }
        private void combobox_ll_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_gia.Texts = "";
            for (int i = 0; i < lltList.Count; i++)
            {
                if (combobox_ll.SelectedValue.ToString() == lltList[i].IDLoaiLaptop)
                {
                    comboBox_tgbh.Text = lltList[i].ThoiGianBaoHanh.ToString();
                    text_gia.Texts = lltList[i].GiaNhap.ToString();
                    break;

                }
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string searchTerm = rjTextBox1.Texts.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            if (searchTerm != "")
            {
                phieuNhapList = phieuNhapBUS.TimKiem(searchTerm); // Gọi BUS để tìm kiếm
                chiTietPhieuNhapDTOs = chiTietPhieuNhapBUS.GetChiTietPhieuNhapWithPhieuNhap(searchTerm);
                dataGridView_PN.DataSource = phieuNhapList; // Hiển thị dữ liệu lên DataGridView
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            rjTextBox1.Texts = "";
            LoadPhieuNhapData();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", "CTHD_" + phieuNhap.ID);



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LOAIPHIEU", "IMPORT RECEIPT");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MAHD", phieuNhap.ID + "");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", phieuNhap.NgayTao + "");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LABEL", "Manufacturer: ");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", phieuNhap.IDNV);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", phieuNhap.IDNCC);

            string filas = string.Empty;
            decimal total = 0;
            foreach (ChiTietPhieuNhap ctpn in ctPNList)
            {
                filas += "<tr>";
                filas += "<td align=\"center\">" + ctpn.IMEI + "</td>";
                filas += "<td align=\"center\">" + ctpn.GiaNhap + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", phieuNhap.TongTien + "");



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_home, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                        MessageBox.Show("Đã xuất file pdf thành công");
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
