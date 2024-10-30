using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using RJComboBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.TaiKhoan
{
    public partial class CreateTaiKhoanGUI : Form
    {

        MainForm mainForm;
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public CreateTaiKhoanGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            TaiDuLieuComboBoxQuyen();
        }

        private void InitializeComponent()
        {
            rjTextBox1 = new RJTextBox();
            rjTextBox2 = new RJTextBox();
            artanPanel1 = new ArtanPanel();
            label1 = new Label();
            artanPanel2 = new ArtanPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            vbButton4 = new VBButton();
            vbButton3 = new VBButton();
            rjComboBox2 = new RJComboBox.RJComboBox();
            artanPanel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(54, 180);
            rjTextBox1.Margin = new Padding(5);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(11, 9, 11, 9);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(646, 50);
            rjTextBox1.TabIndex = 10;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(54, 63);
            rjTextBox2.Margin = new Padding(5);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(11, 9, 11, 9);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(646, 50);
            rjTextBox2.TabIndex = 11;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            rjTextBox2._TextChanged += rjTextBox2__TextChanged;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.MediumPurple;
            artanPanel1.GradientTopColor = Color.DodgerBlue;
            artanPanel1.Location = new Point(12, 13);
            artanPanel1.Margin = new Padding(3, 4, 3, 4);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1019, 156);
            artanPanel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 55);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 10;
            label1.Text = "Tạo tài khoản";
            // 
            // artanPanel2
            // 
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 30;
            artanPanel2.Controls.Add(label4);
            artanPanel2.Controls.Add(label3);
            artanPanel2.Controls.Add(label2);
            artanPanel2.Controls.Add(vbButton4);
            artanPanel2.Controls.Add(vbButton3);
            artanPanel2.Controls.Add(rjComboBox2);
            artanPanel2.Controls.Add(rjTextBox1);
            artanPanel2.Controls.Add(rjTextBox2);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.MediumPurple;
            artanPanel2.GradientTopColor = Color.DodgerBlue;
            artanPanel2.Location = new Point(12, 177);
            artanPanel2.Margin = new Padding(3, 4, 3, 4);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(1019, 399);
            artanPanel2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 143);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 43;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 267);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 42;
            label3.Text = "Quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 26);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 41;
            label2.Text = "Tên tài khoản";
            // 
            // vbButton4
            // 
            vbButton4.BackColor = Color.DodgerBlue;
            vbButton4.BackgroundColor = Color.DodgerBlue;
            vbButton4.BorderColor = Color.PaleVioletRed;
            vbButton4.BorderRadius = 20;
            vbButton4.BorderSize = 0;
            vbButton4.FlatAppearance.BorderSize = 0;
            vbButton4.FlatStyle = FlatStyle.Flat;
            vbButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton4.ForeColor = Color.White;
            vbButton4.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton4.Location = new Point(817, 302);
            vbButton4.Margin = new Padding(3, 4, 3, 4);
            vbButton4.Name = "vbButton4";
            vbButton4.Padding = new Padding(8, 0, 0, 0);
            vbButton4.Size = new Size(141, 50);
            vbButton4.TabIndex = 40;
            vbButton4.Text = "Hủy";
            vbButton4.TextColor = Color.White;
            vbButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton4.UseVisualStyleBackColor = false;
            vbButton4.Click += vbButton4_Click;
            // 
            // vbButton3
            // 
            vbButton3.BackColor = Color.DodgerBlue;
            vbButton3.BackgroundColor = Color.DodgerBlue;
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 20;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton3.ForeColor = Color.White;
            vbButton3.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton3.Location = new Point(817, 180);
            vbButton3.Margin = new Padding(3, 4, 3, 4);
            vbButton3.Name = "vbButton3";
            vbButton3.Padding = new Padding(8, 0, 0, 0);
            vbButton3.Size = new Size(141, 50);
            vbButton3.TabIndex = 39;
            vbButton3.Text = "Tạo";
            vbButton3.TextColor = Color.White;
            vbButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton3.UseVisualStyleBackColor = false;
            vbButton3.Click += vbButton3_Click;
            // 
            // rjComboBox2
            // 
            rjComboBox2.BackColor = Color.WhiteSmoke;
            rjComboBox2.BorderColor = Color.MediumSlateBlue;
            rjComboBox2.BorderSize = 1;
            rjComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox2.Font = new Font("Segoe UI", 10F);
            rjComboBox2.ForeColor = Color.DimGray;
            rjComboBox2.IconColor = Color.MediumSlateBlue;
            rjComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox2.ListTextColor = Color.DimGray;
            rjComboBox2.Location = new Point(54, 312);
            rjComboBox2.Margin = new Padding(3, 4, 3, 4);
            rjComboBox2.MinimumSize = new Size(229, 40);
            rjComboBox2.Name = "rjComboBox2";
            rjComboBox2.Padding = new Padding(1);
            rjComboBox2.Size = new Size(646, 40);
            rjComboBox2.TabIndex = 38;
            rjComboBox2.Texts = "";
            rjComboBox2.OnSelectedIndexChanged += rjComboBox2_OnSelectedIndexChanged;
            rjComboBox2.Load += Form_Load;
            // 
            // CreateTaiKhoanGUI
            // 
            ClientSize = new Size(1043, 589);
            Controls.Add(artanPanel2);
            Controls.Add(artanPanel1);
            Name = "CreateTaiKhoanGUI";
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            artanPanel2.ResumeLayout(false);
            artanPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            mainForm.OpenChildForm(new QuanLyTaiKhoanGUI(mainForm));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private RJTextBox rjTextBox1;
        private RJTextBox rjTextBox2;
        private ArtanPanel artanPanel1;
        private Label label1;
        private ArtanPanel artanPanel2;
        private VBButton vbButton4;
        private VBButton vbButton3;
        private Label label4;
        private Label label3;
        private Label label2;
        private RJComboBox.RJComboBox rjComboBox2;

        private void rjComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {
            //rjComboBox2.Items.Clear();
            //rjComboBox2.Items.Add("Nhân viên");
            //rjComboBox2.Items.Add("Quản lý");

            //// Đặt "Quản lý" làm lựa chọn mặc định
            //rjComboBox2.SelectedIndex = 0;
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new QuanLyTaiKhoanGUI(mainForm));
        }
        private void TaiDuLieuComboBoxQuyen()
        {
            Dictionary<string, string> quyen = taiKhoanBUS.GetAllQuyen();
            rjComboBox2.DataSource = new BindingSource(quyen, null);
            rjComboBox2.DisplayMember = "Value";  // Hiển thị tên khuyến mãi
            rjComboBox2.ValueMember = "Key";      // Giá trị là mã khuyến mãi
        }
        private void vbButton3_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và ComboBox
            string tenDN = rjTextBox2.Texts; // Lấy tên đăng nhập và loại bỏ khoảng trắng
            string matKhau = rjTextBox1.Texts; // Lấy mật khẩu và loại bỏ khoảng trắng
            string quyen = ((KeyValuePair<string, string>)rjComboBox2.SelectedItem).Key; // Lấy quyền từ ComboBox

            // Tạo một đối tượng TaiKhoanDTO
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO
            {
                TenDN = tenDN,
                MatKhau = matKhau,
                Quyen = quyen
            };
            
            bool isAdded = taiKhoanBUS.AddTaiKhoan(taiKhoan);

            if (isAdded)
            {
                MessageBox.Show("Tài khoản đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rjTextBox1.Text = "";
                rjTextBox2.Text = ""; // Sử dụng Clear() để xóa nội dung
                rjComboBox2.SelectedIndex = 0; // Hoặc chọn một giá trị mặc định
            }
            else
            {
                // Thêm tài khoản thất bại
                MessageBox.Show("Có lỗi xảy ra khi thêm tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
