using FontAwesome.Sharp;

namespace CSharp_laptop.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            iconButton1 = new IconButton();
            btnTaiKhoan = new IconButton();
            btnThongKe = new IconButton();
            btnNH_PN = new IconButton();
            btnKhuyenMai = new IconButton();
            btnKhachHang = new IconButton();
            btnNhanVien = new IconButton();
            btnHD_BH = new IconButton();
            btnNhaSanXuat = new IconButton();
            btnSanPham = new IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            iconCurrentChildForm = new IconPictureBox();
            lblTitleChildForm = new Label();
            btnExit = new IconButton();
            btnMini = new IconButton();
            btnZoom = new IconButton();
            artanPanel1 = new ArtanPanel();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            artanPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 70, 104);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btnTaiKhoan);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnNH_PN);
            panelMenu.Controls.Add(btnKhuyenMai);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnHD_BH);
            panelMenu.Controls.Add(btnNhaSanXuat);
            panelMenu.Controls.Add(btnSanPham);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 791);
            panelMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = IconChar.ShieldBlank;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 680);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 11;
            iconButton1.Text = "Bảo hành";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.ForeColor = Color.Gainsboro;
            btnTaiKhoan.IconChar = IconChar.AccessibleIcon;
            btnTaiKhoan.IconColor = Color.Gainsboro;
            btnTaiKhoan.IconFont = IconFont.Auto;
            btnTaiKhoan.IconSize = 32;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(0, 620);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(10, 0, 20, 0);
            btnTaiKhoan.Size = new Size(220, 60);
            btnTaiKhoan.TabIndex = 10;
            btnTaiKhoan.Text = "Tài Khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.ForeColor = Color.Gainsboro;
            btnThongKe.IconChar = IconChar.ChartLine;
            btnThongKe.IconColor = Color.Gainsboro;
            btnThongKe.IconFont = IconFont.Auto;
            btnThongKe.IconSize = 32;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 560);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 20, 0);
            btnThongKe.Size = new Size(220, 60);
            btnThongKe.TabIndex = 9;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnNH_PN
            // 
            btnNH_PN.Dock = DockStyle.Top;
            btnNH_PN.FlatAppearance.BorderSize = 0;
            btnNH_PN.FlatStyle = FlatStyle.Flat;
            btnNH_PN.ForeColor = Color.Gainsboro;
            btnNH_PN.IconChar = IconChar.DollyBox;
            btnNH_PN.IconColor = Color.Gainsboro;
            btnNH_PN.IconFont = IconFont.Auto;
            btnNH_PN.IconSize = 32;
            btnNH_PN.ImageAlign = ContentAlignment.MiddleLeft;
            btnNH_PN.Location = new Point(0, 500);
            btnNH_PN.Name = "btnNH_PN";
            btnNH_PN.Padding = new Padding(10, 0, 20, 0);
            btnNH_PN.Size = new Size(220, 60);
            btnNH_PN.TabIndex = 8;
            btnNH_PN.Text = "Nhập hàng / Phiếu nhập";
            btnNH_PN.TextAlign = ContentAlignment.MiddleLeft;
            btnNH_PN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNH_PN.UseVisualStyleBackColor = true;
            btnNH_PN.Click += btnNH_PN_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.Dock = DockStyle.Top;
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.ForeColor = Color.Gainsboro;
            btnKhuyenMai.IconChar = IconChar.Percentage;
            btnKhuyenMai.IconColor = Color.Gainsboro;
            btnKhuyenMai.IconFont = IconFont.Auto;
            btnKhuyenMai.IconSize = 32;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(0, 440);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(220, 60);
            btnKhuyenMai.TabIndex = 6;
            btnKhuyenMai.Text = "Khuyến mãi";
            btnKhuyenMai.TextAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = true;
            btnKhuyenMai.Click += iconButton6_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.ForeColor = Color.Gainsboro;
            btnKhachHang.IconChar = IconChar.ContactBook;
            btnKhachHang.IconColor = Color.Gainsboro;
            btnKhachHang.IconFont = IconFont.Auto;
            btnKhachHang.IconSize = 32;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 380);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 20, 0);
            btnKhachHang.Size = new Size(220, 60);
            btnKhachHang.TabIndex = 5;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += iconButton5_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.ForeColor = Color.Gainsboro;
            btnNhanVien.IconChar = IconChar.Vcard;
            btnNhanVien.IconColor = Color.Gainsboro;
            btnNhanVien.IconFont = IconFont.Auto;
            btnNhanVien.IconSize = 32;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 320);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 20, 0);
            btnNhanVien.Size = new Size(220, 60);
            btnNhanVien.TabIndex = 4;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += iconButton4_Click;
            // 
            // btnHD_BH
            // 
            btnHD_BH.Dock = DockStyle.Top;
            btnHD_BH.FlatAppearance.BorderSize = 0;
            btnHD_BH.FlatStyle = FlatStyle.Flat;
            btnHD_BH.ForeColor = Color.Gainsboro;
            btnHD_BH.IconChar = IconChar.HandHoldingUsd;
            btnHD_BH.IconColor = Color.Gainsboro;
            btnHD_BH.IconFont = IconFont.Auto;
            btnHD_BH.IconSize = 32;
            btnHD_BH.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD_BH.Location = new Point(0, 260);
            btnHD_BH.Name = "btnHD_BH";
            btnHD_BH.Padding = new Padding(10, 0, 20, 0);
            btnHD_BH.Size = new Size(220, 60);
            btnHD_BH.TabIndex = 3;
            btnHD_BH.Text = "Bán hàng / Hóa đơn ";
            btnHD_BH.TextAlign = ContentAlignment.MiddleLeft;
            btnHD_BH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHD_BH.UseVisualStyleBackColor = true;
            btnHD_BH.Click += iconButton3_Click;
            // 
            // btnNhaSanXuat
            // 
            btnNhaSanXuat.Dock = DockStyle.Top;
            btnNhaSanXuat.FlatAppearance.BorderSize = 0;
            btnNhaSanXuat.FlatStyle = FlatStyle.Flat;
            btnNhaSanXuat.ForeColor = Color.Gainsboro;
            btnNhaSanXuat.IconChar = IconChar.Handshake;
            btnNhaSanXuat.IconColor = Color.Gainsboro;
            btnNhaSanXuat.IconFont = IconFont.Auto;
            btnNhaSanXuat.IconSize = 32;
            btnNhaSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.Location = new Point(0, 200);
            btnNhaSanXuat.Name = "btnNhaSanXuat";
            btnNhaSanXuat.Padding = new Padding(10, 0, 20, 0);
            btnNhaSanXuat.Size = new Size(220, 60);
            btnNhaSanXuat.TabIndex = 2;
            btnNhaSanXuat.Text = "Nhà sản xuất";
            btnNhaSanXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaSanXuat.UseVisualStyleBackColor = true;
            btnNhaSanXuat.Click += iconButton2_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.ForeColor = Color.Gainsboro;
            btnSanPham.IconChar = IconChar.Laptop;
            btnSanPham.IconColor = Color.Gainsboro;
            btnSanPham.IconFont = IconFont.Auto;
            btnSanPham.IconSize = 32;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 140);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 20, 0);
            btnSanPham.Size = new Size(220, 60);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.logo_home_removebg;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 140);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(74, 80, 114);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 35);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1133, 756);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_home_removebg;
            pictureBox1.Location = new Point(248, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(btnMini);
            panelTitleBar.Controls.Add(btnZoom);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1133, 34);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.FromArgb(64, 70, 104);
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(64, 70, 104);
            iconCurrentChildForm.IconFont = IconFont.Auto;
            iconCurrentChildForm.IconSize = 26;
            iconCurrentChildForm.Location = new Point(16, 4);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(26, 27);
            iconCurrentChildForm.TabIndex = 8;
            iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.FromArgb(64, 70, 104);
            lblTitleChildForm.Location = new Point(48, 7);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(56, 21);
            lblTitleChildForm.TabIndex = 7;
            lblTitleChildForm.Text = "Home";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = IconChar.Close;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1099, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(1, 10, 0, 10);
            btnExit.Size = new Size(34, 34);
            btnExit.TabIndex = 6;
            btnExit.TabStop = false;
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMini
            // 
            btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.ForeColor = Color.Gainsboro;
            btnMini.IconChar = IconChar.Subtract;
            btnMini.IconColor = Color.Gainsboro;
            btnMini.IconFont = IconFont.Auto;
            btnMini.IconSize = 20;
            btnMini.ImageAlign = ContentAlignment.MiddleLeft;
            btnMini.Location = new Point(1030, 0);
            btnMini.Margin = new Padding(0);
            btnMini.Name = "btnMini";
            btnMini.Padding = new Padding(3, 10, 0, 10);
            btnMini.Size = new Size(34, 34);
            btnMini.TabIndex = 5;
            btnMini.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMini.UseVisualStyleBackColor = true;
            btnMini.Click += btnMini_Click;
            // 
            // btnZoom
            // 
            btnZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoom.FlatAppearance.BorderSize = 0;
            btnZoom.FlatStyle = FlatStyle.Flat;
            btnZoom.ForeColor = Color.Gainsboro;
            btnZoom.IconChar = IconChar.WindowMaximize;
            btnZoom.IconColor = Color.Gainsboro;
            btnZoom.IconFont = IconFont.Auto;
            btnZoom.IconSize = 20;
            btnZoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnZoom.Location = new Point(1064, 0);
            btnZoom.Margin = new Padding(0);
            btnZoom.Name = "btnZoom";
            btnZoom.Padding = new Padding(3, 10, 0, 10);
            btnZoom.Size = new Size(34, 34);
            btnZoom.TabIndex = 4;
            btnZoom.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
            artanPanel1.Controls.Add(panelTitleBar);
            artanPanel1.Dock = DockStyle.Top;
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(149, 147, 186);
            artanPanel1.GradientTopColor = Color.FromArgb(255, 192, 192);
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1133, 35);
            artanPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(panelDesktop);
            panel1.Controls.Add(artanPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 791);
            panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1353, 791);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            artanPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnHD_BH;
        private FontAwesome.Sharp.IconButton btnNhaSanXuat;
        private PictureBox btnHome;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnNH_PN;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnZoom;
        private ArtanPanel artanPanel1;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panel1;
    }
}