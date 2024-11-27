using CSharp_laptop.DTO;
using CSharp_laptop.BUS;
using FontAwesome.Sharp;
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
    public partial class DangNhapGUI : Form
    {
        string ma = "người theo hương hoa mây mù giăng lối";
        public DangNhapGUI()
        {
            InitializeComponent();

            rjTextBox2.PasswordChar = true;  // Ẩn mật khẩu khi nhập


            this.AcceptButton = vbButton1;

            rjTextBox1.Texts = "NV001";
            rjTextBox2.Focus();
            button1.FlatStyle = FlatStyle.Flat;  // Đặt style phẳng
            //button1.FlatAppearance.BorderSize = 0;  // Xóa viền
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //GUI.MainForm mf = new GUI.MainForm();
            //mf.Show();
            //this.Hide();

            //string tenDangNhap = textBox1.Text;
            //string matKhau = textBox2.Text;

            //TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            //bool isLoginSuccessful = taiKhoanDAO.CheckLogin(tenDangNhap, matKhau);

            //if (isLoginSuccessful)
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    GUI.MainForm mf = new GUI.MainForm();
            //    mf.Show();
            //    this.Hide(); // Ẩn form đăng nhập
            //}
            //else
            //{
            //    // Đăng nhập thất bại
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã nhấn nút Quên mk", "Quên MK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;  // Thu nhỏ form lại nếu đang phóng to
                btnZoom.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;  // Phóng to form
                btnZoom.IconChar = IconChar.WindowRestore;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            //GUI.MainForm mf = new GUI.MainForm();
            //mf.Show();
            //this.Hide();
            string tenDangNhap = rjTextBox1.Texts;
            string matKhau = rjTextBox2.Texts;

            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

            TaiKhoanDTO isLoginSuccessful = taiKhoanBUS.CheckLogin(tenDangNhap, matKhau);

            if (isLoginSuccessful != null)
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Ẩn form đăng nhập



                GUI.MainForm mf = new GUI.MainForm(isLoginSuccessful);
                mf.Show();


            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (rjTextBox2.PasswordChar)
            {
                // Nếu mật khẩu đang ẩn, thì hiển thị nó
                rjTextBox2.PasswordChar = false;

            }
            else
            {
                // Nếu mật khẩu đang hiển thị, thì ẩn nó
                rjTextBox2.PasswordChar = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ma = new VerificationCode().sendVerification(rjTextBox1.Texts);
            if (ma != "Errror")
            {
                xacnhanLabel.Visible = true;
                xacnhanTextBox.Visible = true;
            }
        }

        private void xacnhanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (xacnhanTextBox.Text.Length == 6)
            {
                if (xacnhanTextBox.Text == ma)
                {
                    this.Hide(); // Ẩn form đăng nhập

                    GUI.MainForm mf = new GUI.MainForm(new TaiKhoanBUS().GetTaiKhoanByID(rjTextBox1.Texts));
                    mf.Show();
                }
            }
        }
    }
}
