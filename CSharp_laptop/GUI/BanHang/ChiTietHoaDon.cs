using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace CSharp_laptop.GUI.BanHang
{
    public partial class ChiTietHoaDon : Form
    {

        MainForm mainForm;


        HoaDonBUS HoaDonBUS;

        ChiTietHoaDonBUS ChiTietHoaDonBUS;

        HoaDonDTO HoaDon;

        List<ChiTietHoaDonDTO> ChiTietHoaDonList;

        public ChiTietHoaDon(MainForm mainForm, HoaDonDTO hoaDon)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            this.HoaDon = hoaDon;

            ChiTietHoaDonBUS = new ChiTietHoaDonBUS();

            lblMaHD.Text = "Mã hóa đơn: " + HoaDon.ID_HoaDon;

            lblNV.Text = "Mã nhân viên: " + HoaDon.MaNV;

            lblKH.Text = "Mã khách hàng: " + HoaDon.MaKH;

            lblNgayLap.Text = "Ngày lập: " + HoaDon.NgayLap;

            lblTongTien.Text = "Tổng tiền: " + HoaDon.TongTien;

            LoadHoaDons();

            edittable();

        }

        private void LoadHoaDons()
        {
            ChiTietHoaDonList = ChiTietHoaDonBUS.GetChiTietHoaDonWithIdHD(HoaDon.ID_HoaDon);


            dataGridView2.DataSource = ChiTietHoaDonList;
        }

        private void edittable()
        {
            dataGridView2.Columns["IMEI"].HeaderText = "Mã sản phẩm";


            dataGridView2.Columns["Id_HoaDon"].Visible = false;


            dataGridView2.Columns["GiaBan"].HeaderText = "Giá bán";




            dataGridView2.RowTemplate.Height = 40; // Điều chỉnh chiều cao của hàng

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", "CTHD_"+HoaDon.ID_HoaDon) ;



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LOAIPHIEU", "RECEIPT");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MAHD", HoaDon.ID_HoaDon + "");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", HoaDon.NgayLap + "");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", HoaDon.MaNV);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", HoaDon.MaKH);

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                filas += "<tr>";
                filas += "<td align=\"center\">" + row.Cells["IMEI"].Value.ToString() + "</td>";
                filas += "<td align=\"center\">" + row.Cells["GiaBan"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", HoaDon.TongTien + "");



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
