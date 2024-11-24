using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            guna2TextBoxID.Text = "";
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

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (nameprocess.Text == "Thêm Khách Hàng")
            {
                ThemKhachHang();
            } else
            {

            }
        }

        private void ThemKhachHang()
        {
            
        }
        private bool checkTextBox()
        {
            if (string.IsNullOrEmpty(guna2TextBoxID.Text))
            {
                MessageBox.Show("Mã Nhân Viên chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxTen.Text))
            {
                MessageBox.Show("Tên Nhân Viên chưa được nhập!", "Lỗi!"); return true;
            }
            if (string.IsNullOrEmpty(guna2TextBoxDC.Text))
            {
                MessageBox.Show("Email chưa được nhập!", "Lỗi!"); return true;
            }
            return false;
        }


    }
}
