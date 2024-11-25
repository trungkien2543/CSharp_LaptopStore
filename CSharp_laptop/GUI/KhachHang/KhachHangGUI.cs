using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.KhachHang;
using iTextSharp.text.pdf;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;

namespace CSharp_laptop.GUI
{
    public partial class KhachHangGUI : Form
    {
        int PH;
        bool hided;
        MainForm mainForm;
        KhachHangBUS bus;
        List<KhachHangDTO> dtos;

        List<VBButton> btnEditList;
        List<VBButton> btnDelList;
        public KhachHangGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            bus = new KhachHangBUS();
            dtos = bus.getAllKhachHang();

            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();
            InitializeComponent();

            PH = editpanel.Location.Y;

            editpanel.Location = new Point(editpanel.Location.X, this.Height - 10);
            hided = true;
        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            LoadTable();


        }
        private void LoadTable()
        {
            btnEditList = new List<VBButton>();
            btnDelList = new List<VBButton>();
            dataGridView1.Rows.Clear();
            dataGridView1.Controls.Clear();
            dataGridView1.Refresh();

            dtos = bus.getAllKhachHang();
            for (int i = 0; i < dtos.Count; i++)
            {
                KhachHangDTO kh = dtos[i];
                dataGridView1.Rows.Add(new object[] { kh.ID_KhachHang, kh.TenKH, kh.DiaChiKH, kh.SDT, kh.TichDiem });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private bool IsbtnEditListNameExist(string name)
        {
            // Kiểm tra xem có Button nào trong danh sách có Name khớp với tên cần tìm không
            return btnEditList.Any(btn => btn.Name == name);
        }
        private bool IsbtnDelListNameExist(string name)
        {
            // Kiểm tra xem có Button nào trong danh sách có Name khớp với tên cần tìm không
            return btnDelList.Any(btn => btn.Name == name);
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {

                nameprocess.Text = "Sủa Khách Hàng";
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;
                int rowIndex = int.Parse(clickedButton.Name);

                guna2TextBoxID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                guna2TextBoxTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                guna2TextBoxDC.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                guna2TextBoxSDT.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                guna2TextBoxDiem.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

                if (hided)
                {
                    button1.Text = "HIDE";
                    timer1.Start();
                }
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                dataGridView1.Rows[int.Parse(clickedButton.Name)].Selected = true;

                int rowIndex = int.Parse(clickedButton.Name);

                String ma = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + ma, "Xóa Khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (bus.DeleteKhachHang(ma))
                    {
                        MessageBox.Show("Xóa Thành Công!");
                    }
                    else
                    {

                        MessageBox.Show("Xóa Ko Thành Công!");
                    }
                    LoadTable();
                }
                else if (result == DialogResult.Cancel)
                {

                }

            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column7"].Index && e.RowIndex >= 0)
            {
                if (!IsbtnEditListNameExist(e.RowIndex.ToString()))
                {
                    // Tạo nút VBButton cho mỗi hàng
                    VBButton btn = new VBButton();
                    btn.Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btn.Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                    btn.BackgroundColor = Color.FromArgb(233, 203, 157);
                    btn.BorderRadius = 10;

                    btn.Name = e.RowIndex.ToString();
                    btn.Text = "✏️";

                    // Thêm sự kiện click cho VBButton nếu cần
                    btn.Click += BtnEdit_Click;

                    // Thêm nút vào control của DataGridView
                    dataGridView1.Controls.Add(btn);
                    btnEditList.Add(btn);

                    // Đánh dấu đã vẽ ô để tránh vẽ đè
                    e.Handled = true;
                }
                else
                {
                    btnEditList[e.RowIndex].Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btnEditList[e.RowIndex].Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                }

            }
            if (e.ColumnIndex == dataGridView1.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                if (!IsbtnDelListNameExist(e.RowIndex.ToString()))
                {
                    // Tạo nút VBButton cho mỗi hàng
                    VBButton btn = new VBButton();
                    btn.Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btn.Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                    btn.BackgroundColor = Color.FromArgb(233, 203, 157);
                    btn.BorderRadius = 10;

                    btn.Name = e.RowIndex.ToString();
                    btn.Text = "❌";

                    // Thêm sự kiện click cho VBButton nếu cần
                    btn.Click += BtnDel_Click;

                    // Thêm nút vào control của DataGridView
                    dataGridView1.Controls.Add(btn);
                    btnDelList.Add(btn);

                    // Đánh dấu đã vẽ ô để tránh vẽ đè
                    e.Handled = true;
                }
                else
                {
                    btnDelList[e.RowIndex].Size = new Size(e.CellBounds.Width, e.CellBounds.Height);
                    btnDelList[e.RowIndex].Location = new Point(e.CellBounds.X, e.CellBounds.Y);
                }

            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateKhachHangGUI(mainForm));
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateKhachHangGUI(mainForm));
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                editpanel.Location = new Point(editpanel.Location.X, editpanel.Location.Y - 5);
                if (editpanel.Location.Y <= this.Height - editpanel.Height)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                editpanel.Location = new Point(editpanel.Location.X, editpanel.Location.Y + 5);
                if (editpanel.Location.Y >= this.Height)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void guna2CircleButton3_Click_1(object sender, EventArgs e)
        {
            button1.Text = "SHOW";
            timer1.Start();
        }

        private void vbButton2_Click_1(object sender, EventArgs e)
        {
            nameprocess.Text = "Thêm Khách Hàng";
            guna2TextBoxID.Text = TaoMaKH(bus.getAllKhachHang().Count);
            guna2TextBoxTen.Text = "";
            guna2TextBoxDC.Text = "";
            guna2TextBoxSDT.Text = "";
            guna2TextBoxDiem.Text = "";
            if (hided)
            {
                button1.Text = "HIDE";
                timer1.Start();
            }
        }
        private string TaoMaKH(int danhSach)
        {
            int doDai = danhSach + 1;
            string soChuoi = doDai.ToString("D3");
            return "KH" + soChuoi;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (nameprocess.Text == "Thêm Khách Hàng")
            {
                ThemKhachHang();
            }
            else
            {
                SuaKhachHang();
            }

            LoadTable();
        }
        private void SuaKhachHang()
        {
            if (checkTextBox())
                return;
            if (bus.GetKhachHangById(guna2TextBoxID.Text) == null)
            {
                MessageBox.Show("Mã Khách hàng không tồn tại!", "Lỗi!");
                return;
            }
            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string DC = guna2TextBoxDC.Text;
            string sdt = guna2TextBoxSDT.Text;
            int diem = int.Parse(guna2TextBoxDiem.Text);
            KhachHangDTO kh = new KhachHangDTO(id, ten, DC, sdt, diem);

            if (bus.UpdateKhachHang(kh))
            {
                MessageBox.Show("Sửa khách hàng thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Sửa khách thất bại!", "Thông Báo");

            }
        }

        private void ThemKhachHang()
        {
            if (checkTextBox())
                return;
            if (bus.GetKhachHangById(guna2TextBoxID.Text) != null)
            {
                MessageBox.Show("Mã Khách hàng đã tồn tại!", "Lỗi!");
                return;
            }
            string id = guna2TextBoxID.Text;
            string ten = guna2TextBoxTen.Text;
            string DC = guna2TextBoxDC.Text;
            string sdt = guna2TextBoxSDT.Text;
            int diem = int.Parse(guna2TextBoxDiem.Text);
            KhachHangDTO kh = new KhachHangDTO(id, ten, DC, sdt, diem);

            if (bus.AddKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Thêm khách thất bại!", "Thông Báo");

            }

        }
        private bool checkTextBox()
        {
            if (string.IsNullOrEmpty(guna2TextBoxID.Text))
            {
                MessageBox.Show("Mã Khách hàng chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxTen.Text))
            {
                MessageBox.Show("Tên Khách hàng chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxDC.Text))
            {
                MessageBox.Show("Email chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxSDT.Text))
            {
                MessageBox.Show("Số Điện thoại chưa được nhập!", "Lỗi!"); return true;
            }
            return false;
        }

        private void guna2TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void guna2TextBoxDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", "con cak");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "con cak2");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Column1"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Column2"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Column3"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Column4"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Column5"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



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
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
    }
}
