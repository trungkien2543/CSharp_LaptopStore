using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI.BanHang;
using CSharp_laptop.GUI.Laptop;
using CustomTabControl;
using FontAwesome.Sharp;
using static OpenTK.Graphics.OpenGL.GL;
using Color = System.Drawing.Color;
using Matrix = System.Drawing.Drawing2D.Matrix;
using Pen = System.Drawing.Pen;


namespace CSharp_laptop.GUI
{
    public partial class MainForm : Form
    {
        int PW;
        bool hided;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private Form currentChildForm;

        private LoaiLaptopGUI loaiLaptopGUI;

        private HangGUI hangGUI;

        private BanHangForm banHangForm;

        private NhanVienGUI nhanVienGUI;

        private KhachHangGUI khachHangGUI;

        private KhuyenMaiGUI khuyenMaiGUI;

        private ThongKeGUI thongKeGUI;

        private QuanLyTaiKhoanGUI quanLyTaiKhoanGUI;

        private BaoHanhGUI baoHanhGUI;

        private PhieuNhapGUI phieuNhapGUI;

        public String NhanVienDangNhap;

        public MainForm(String nhanVienDangNhap)
        {

            InitializeComponent();

            this.NhanVienDangNhap = nhanVienDangNhap;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;

            PW = MenuPanel.Width;

            hided = false;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            MenuChoice.Controls.Add(leftBorderBtn);

            this.loaiLaptopGUI = new LoaiLaptopGUI(this);

            this.hangGUI = new HangGUI(this);

            this.banHangForm = new BanHangForm(this);

            this.nhanVienGUI = new NhanVienGUI(this);

            this.khachHangGUI = new KhachHangGUI(this);

            this.khuyenMaiGUI = new KhuyenMaiGUI();

            this.thongKeGUI = new ThongKeGUI();

            this.quanLyTaiKhoanGUI = new QuanLyTaiKhoanGUI(this);

            this.baoHanhGUI = new BaoHanhGUI(this);

            this.phieuNhapGUI = new PhieuNhapGUI(this);


            KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();
            khuyenMaiBUS.KiemTraKhuyenMaiHetHan();

        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Visible = false;
            }
            currentChildForm = childForm;
            //End
            childForm.Visible = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            //iconCurrentChildForm.ForeColor = currentBtn.IconColor;
            childForm.Show();
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.Transparent;
                if (hided)
                {
                    currentBtn.ForeColor = Color.FromArgb(144, 114, 170);
                }
                else
                    currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(255, 235, 205); // Màu xanh tím
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(123, 237, 159); // Màu xanh nhạt
            public static Color color8 = Color.FromArgb(255, 195, 113); // Màu cam nhạt
            public static Color color9 = Color.FromArgb(204, 229, 255);
            public static Color color10 = Color.FromArgb(205, 133, 63);
            public static Color color0 = Color.FromArgb(247, 176, 118);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.IconColor = color;
                if (!hided)
                {
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                }

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;

                lblTitleChildForm.Text = currentBtn.Text;

                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        private void MainForm_N_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void MainForm_N_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void MainForm_N_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void MainForm_N_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(119, 119, 182);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {

            btnExit.BackColor = Color.Transparent;
        }

        private void btnZoom_MouseEnter(object sender, EventArgs e)
        {
            btnZoom.BackColor = Color.FromArgb(119, 119, 182);
        }

        private void btnZoom_MouseLeave(object sender, EventArgs e)
        {
            btnZoom.BackColor = Color.Transparent;
        }

        private void btnMini_MouseEnter(object sender, EventArgs e)
        {
            btnMini.BackColor = Color.FromArgb(119, 119, 182);
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackColor = Color.Transparent;
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
                this.borderRadius = 20;
            }
            else
            {
                WindowState = FormWindowState.Maximized;  // Phóng to form
                btnZoom.IconChar = IconChar.WindowRestore;
                this.borderRadius = 2;
            }
            this.Refresh();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                MenuPanel.Size = new Size(MenuPanel.Width + 5, MenuPanel.Height);
                panelTitleBar.Size = new Size(panelTitleBar.Width - 5, panelTitleBar.Height);
                panelTitleBar.Location = new Point(panelTitleBar.Location.X + 5, panelTitleBar.Location.Y);
                panelDesktop.Size = new Size(panelDesktop.Width - 5, panelDesktop.Height);
                panelDesktop.Location = new Point(panelDesktop.Location.X + 5, panelDesktop.Location.Y);
                PictureBox1.Size = new Size(PictureBox1.Width, PictureBox1.Height + 2);
                MenuChoice.Location = new Point(MenuChoice.Location.X, MenuChoice.Location.Y + 2);
                if (MenuPanel.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();

                    if (currentBtn != null)
                    {
                        currentBtn.ForeColor = currentBtn.IconColor;
                        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    }
                }
            }
            else
            {
                MenuPanel.Size = new Size(MenuPanel.Width - 5, MenuPanel.Height);
                panelTitleBar.Size = new Size(panelTitleBar.Width + 5, panelTitleBar.Height);
                panelTitleBar.Location = new Point(panelTitleBar.Location.X - 5, panelTitleBar.Location.Y);
                panelDesktop.Size = new Size(panelDesktop.Width + 5, panelDesktop.Height);
                panelDesktop.Location = new Point(panelDesktop.Location.X - 5, panelDesktop.Location.Y);
                PictureBox1.Size = new Size(PictureBox1.Width, PictureBox1.Height - 2);
                MenuChoice.Location = new Point(MenuChoice.Location.X, MenuChoice.Location.Y - 2);
                if (MenuPanel.Width <= 60)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();

                }
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (btnSanPham.ForeColor == Color.Gainsboro) btnSanPham.ForeColor = Color.FromArgb(144, 114, 170);
            else btnSanPham.ForeColor = Color.Gainsboro;

            if (btnNhaSanXuat.ForeColor == Color.Gainsboro) btnNhaSanXuat.ForeColor = Color.FromArgb(144, 114, 170);
            else btnNhaSanXuat.ForeColor = Color.Gainsboro;

            if (btnHD_BH.ForeColor == Color.Gainsboro) btnHD_BH.ForeColor = Color.FromArgb(144, 114, 170);
            else btnHD_BH.ForeColor = Color.Gainsboro;

            if (btnNhanVien.ForeColor == Color.Gainsboro) btnNhanVien.ForeColor = Color.FromArgb(144, 114, 170);
            else btnNhanVien.ForeColor = Color.Gainsboro;

            if (btnKhachHang.ForeColor == Color.Gainsboro) btnKhachHang.ForeColor = Color.FromArgb(144, 114, 170);
            else btnKhachHang.ForeColor = Color.Gainsboro;

            if (btnKhuyenMai.ForeColor == Color.Gainsboro) btnKhuyenMai.ForeColor = Color.FromArgb(144, 114, 170);
            else btnKhuyenMai.ForeColor = Color.Gainsboro;

            if (btnNH_PN.ForeColor == Color.Gainsboro) btnNH_PN.ForeColor = Color.FromArgb(144, 114, 170);
            else btnNH_PN.ForeColor = Color.Gainsboro;

            if (btnThongKe.ForeColor == Color.Gainsboro) btnThongKe.ForeColor = Color.FromArgb(144, 114, 170);
            else btnThongKe.ForeColor = Color.Gainsboro;

            if (btnTaiKhoan.ForeColor == Color.Gainsboro) btnTaiKhoan.ForeColor = Color.FromArgb(144, 114, 170);
            else btnTaiKhoan.ForeColor = Color.Gainsboro;

            if (iconButton1.ForeColor == Color.Gainsboro) iconButton1.ForeColor = Color.FromArgb(144, 114, 170);
            else iconButton1.ForeColor = Color.Gainsboro;

            if (currentBtn != null)
            {
                if (!hided)
                {
                    currentBtn.ForeColor = Color.FromArgb(144, 114, 170);
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        private void btnSanPham_MouseEnter(object sender, EventArgs e)
        {

            IconButton hoverbb = (IconButton)sender;
            hoverbb.BackColor = Color.FromArgb(124, 124, 232);
        }

        private void btnSanPham_MouseLeave(object sender, EventArgs e)
        {

            IconButton hoverbb = (IconButton)sender;
            hoverbb.BackColor = Color.Transparent;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(loaiLaptopGUI);
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(hangGUI);
        }

        private void btnHD_BH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(banHangForm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(nhanVienGUI);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(khachHangGUI);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(khuyenMaiGUI);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(thongKeGUI);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(quanLyTaiKhoanGUI);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(baoHanhGUI);
        }

        private void btnNH_PH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color0);
            OpenChildForm(phieuNhapGUI);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActivateButton(btnSanPham, RGBColors.color1);
            OpenChildForm(loaiLaptopGUI);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        public void moChucNang(int i)
        {
            switch(i)
            {
                case 1:
                    ActivateButton(btnSanPham, RGBColors.color1);
                    OpenChildForm(loaiLaptopGUI); break;
                case 2:
                    ActivateButton(btnNhaSanXuat, RGBColors.color2);
                    OpenChildForm(hangGUI); break;
                case 3:
                    ActivateButton(btnHD_BH, RGBColors.color3);
                    OpenChildForm(banHangForm); break;
                case 4:
                    ActivateButton(btnNhanVien, RGBColors.color4);
                    OpenChildForm(nhanVienGUI); break;
                case 5:
                    ActivateButton(btnKhachHang, RGBColors.color5);
                    OpenChildForm(khachHangGUI); break;
                case 6:
                    ActivateButton(btnKhuyenMai, RGBColors.color6);
                    OpenChildForm(khuyenMaiGUI); break;
                case 7:
                    ActivateButton(btnThongKe, RGBColors.color7);
                    OpenChildForm(thongKeGUI); break;
                case 8:
                    ActivateButton(btnTaiKhoan, RGBColors.color9);
                    OpenChildForm(quanLyTaiKhoanGUI); break;
                case 9:
                    ActivateButton(iconButton1, RGBColors.color8);
                    OpenChildForm(baoHanhGUI); break;
                case 10:
                    ActivateButton(btnNH_PN, RGBColors.color0);
                    OpenChildForm(phieuNhapGUI); break;
                default:
                    break;
            }
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            ChatGPT chatGPT = new ChatGPT(this);
            chatGPT.Show();
        }
    }
}
