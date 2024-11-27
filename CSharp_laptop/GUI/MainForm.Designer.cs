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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new IconButton();
            btnMini = new IconButton();
            btnZoom = new IconButton();
            iconCurrentChildForm = new IconPictureBox();
            lblTitleChildForm = new Label();
            panelContainer = new Panel();
            MenuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            MenuChoice = new Panel();
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
            PictureBox1 = new PictureBox();
            panelTitleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            panelDesktop = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelContainer.SuspendLayout();
            MenuPanel.SuspendLayout();
            MenuChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.IconChar = IconChar.Close;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1096, 1);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(1, 10, 0, 10);
            btnExit.Size = new Size(34, 34);
            btnExit.TabIndex = 13;
            btnExit.TabStop = false;
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.Enter += btnExit_Enter;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMini
            // 
            btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMini.BackColor = Color.Transparent;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.ForeColor = Color.Gainsboro;
            btnMini.IconChar = IconChar.Subtract;
            btnMini.IconColor = Color.White;
            btnMini.IconFont = IconFont.Auto;
            btnMini.IconSize = 20;
            btnMini.ImageAlign = ContentAlignment.MiddleLeft;
            btnMini.Location = new Point(1028, 0);
            btnMini.Margin = new Padding(0);
            btnMini.Name = "btnMini";
            btnMini.Padding = new Padding(3, 10, 0, 10);
            btnMini.Size = new Size(34, 34);
            btnMini.TabIndex = 12;
            btnMini.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMini.UseVisualStyleBackColor = false;
            btnMini.Click += btnMini_Click;
            btnMini.MouseEnter += btnMini_MouseEnter;
            btnMini.MouseLeave += btnMini_MouseLeave;
            // 
            // btnZoom
            // 
            btnZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoom.BackColor = Color.Transparent;
            btnZoom.FlatAppearance.BorderSize = 0;
            btnZoom.FlatStyle = FlatStyle.Flat;
            btnZoom.ForeColor = Color.Gainsboro;
            btnZoom.IconChar = IconChar.WindowMaximize;
            btnZoom.IconColor = Color.White;
            btnZoom.IconFont = IconFont.Auto;
            btnZoom.IconSize = 20;
            btnZoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnZoom.Location = new Point(1062, 1);
            btnZoom.Margin = new Padding(0);
            btnZoom.Name = "btnZoom";
            btnZoom.Padding = new Padding(3, 10, 0, 10);
            btnZoom.Size = new Size(34, 34);
            btnZoom.TabIndex = 11;
            btnZoom.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnZoom.UseVisualStyleBackColor = false;
            btnZoom.Click += btnZoom_Click;
            btnZoom.MouseEnter += btnZoom_MouseEnter;
            btnZoom.MouseLeave += btnZoom_MouseLeave;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.FromArgb(64, 70, 104);
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(64, 70, 104);
            iconCurrentChildForm.IconFont = IconFont.Auto;
            iconCurrentChildForm.IconSize = 26;
            iconCurrentChildForm.Location = new Point(15, 5);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(26, 27);
            iconCurrentChildForm.TabIndex = 10;
            iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.BackColor = Color.Transparent;
            lblTitleChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.FromArgb(64, 70, 104);
            lblTitleChildForm.Location = new Point(47, 5);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(56, 21);
            lblTitleChildForm.TabIndex = 9;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += lblTitleChildForm_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(149, 147, 186);
            panelContainer.Controls.Add(MenuPanel);
            panelContainer.Controls.Add(panelTitleBar);
            panelContainer.Controls.Add(panelDesktop);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1353, 863);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint_1;
            // 
            // MenuPanel
            // 
            MenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MenuPanel.BorderRadius = 12;
            MenuPanel.Controls.Add(MenuChoice);
            MenuPanel.Controls.Add(PictureBox1);
            MenuPanel.CustomizableEdges = customizableEdges1;
            MenuPanel.FillColor = Color.FromArgb(144, 114, 170);
            MenuPanel.FillColor2 = Color.FromArgb(114, 114, 170);
            MenuPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            MenuPanel.Location = new Point(12, 7);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MenuPanel.Size = new Size(175, 844);
            MenuPanel.TabIndex = 8;
            // 
            // MenuChoice
            // 
            MenuChoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MenuChoice.BackColor = Color.Transparent;
            MenuChoice.Controls.Add(iconButton1);
            MenuChoice.Controls.Add(btnTaiKhoan);
            MenuChoice.Controls.Add(btnThongKe);
            MenuChoice.Controls.Add(btnNH_PN);
            MenuChoice.Controls.Add(btnKhuyenMai);
            MenuChoice.Controls.Add(btnKhachHang);
            MenuChoice.Controls.Add(btnNhanVien);
            MenuChoice.Controls.Add(btnHD_BH);
            MenuChoice.Controls.Add(btnNhaSanXuat);
            MenuChoice.Controls.Add(btnSanPham);
            MenuChoice.Location = new Point(0, 120);
            MenuChoice.Name = "MenuChoice";
            MenuChoice.Size = new Size(175, 610);
            MenuChoice.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 11.25F);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = IconChar.ShieldBlank;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 540);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(175, 60);
            iconButton1.TabIndex = 28;
            iconButton1.Text = "Bảo hành";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            iconButton1.MouseEnter += btnSanPham_MouseEnter;
            iconButton1.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Segoe UI", 11.25F);
            btnTaiKhoan.ForeColor = Color.Gainsboro;
            btnTaiKhoan.IconChar = IconChar.AccessibleIcon;
            btnTaiKhoan.IconColor = Color.Gainsboro;
            btnTaiKhoan.IconFont = IconFont.Auto;
            btnTaiKhoan.IconSize = 32;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(0, 480);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(10, 0, 20, 0);
            btnTaiKhoan.Size = new Size(175, 60);
            btnTaiKhoan.TabIndex = 27;
            btnTaiKhoan.Text = "Tài Khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            btnTaiKhoan.MouseEnter += btnSanPham_MouseEnter;
            btnTaiKhoan.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 11.25F);
            btnThongKe.ForeColor = Color.Gainsboro;
            btnThongKe.IconChar = IconChar.ChartLine;
            btnThongKe.IconColor = Color.Gainsboro;
            btnThongKe.IconFont = IconFont.Auto;
            btnThongKe.IconSize = 32;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 420);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 20, 0);
            btnThongKe.Size = new Size(175, 60);
            btnThongKe.TabIndex = 26;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            btnThongKe.MouseEnter += btnSanPham_MouseEnter;
            btnThongKe.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnNH_PN
            // 
            btnNH_PN.Dock = DockStyle.Top;
            btnNH_PN.FlatAppearance.BorderSize = 0;
            btnNH_PN.FlatStyle = FlatStyle.Flat;
            btnNH_PN.Font = new Font("Segoe UI", 11.25F);
            btnNH_PN.ForeColor = Color.Gainsboro;
            btnNH_PN.IconChar = IconChar.DollyBox;
            btnNH_PN.IconColor = Color.Gainsboro;
            btnNH_PN.IconFont = IconFont.Auto;
            btnNH_PN.IconSize = 32;
            btnNH_PN.ImageAlign = ContentAlignment.MiddleLeft;
            btnNH_PN.Location = new Point(0, 360);
            btnNH_PN.Name = "btnNH_PN";
            btnNH_PN.Padding = new Padding(10, 0, 20, 0);
            btnNH_PN.Size = new Size(175, 60);
            btnNH_PN.TabIndex = 25;
            btnNH_PN.Text = "Nhập hàng / Phiếu nhập";
            btnNH_PN.TextAlign = ContentAlignment.MiddleLeft;
            btnNH_PN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNH_PN.UseVisualStyleBackColor = true;
            btnNH_PN.Click += btnNH_PH_Click;
            btnNH_PN.MouseEnter += btnSanPham_MouseEnter;
            btnNH_PN.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.Dock = DockStyle.Top;
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.Font = new Font("Segoe UI", 11.25F);
            btnKhuyenMai.ForeColor = Color.Gainsboro;
            btnKhuyenMai.IconChar = IconChar.Percentage;
            btnKhuyenMai.IconColor = Color.Gainsboro;
            btnKhuyenMai.IconFont = IconFont.Auto;
            btnKhuyenMai.IconSize = 32;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(0, 300);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(175, 60);
            btnKhuyenMai.TabIndex = 24;
            btnKhuyenMai.Text = "Khuyến mãi";
            btnKhuyenMai.TextAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = true;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            btnKhuyenMai.MouseEnter += btnSanPham_MouseEnter;
            btnKhuyenMai.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 11.25F);
            btnKhachHang.ForeColor = Color.Gainsboro;
            btnKhachHang.IconChar = IconChar.ContactBook;
            btnKhachHang.IconColor = Color.Gainsboro;
            btnKhachHang.IconFont = IconFont.Auto;
            btnKhachHang.IconSize = 32;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 240);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 20, 0);
            btnKhachHang.Size = new Size(175, 60);
            btnKhachHang.TabIndex = 23;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            btnKhachHang.MouseEnter += btnSanPham_MouseEnter;
            btnKhachHang.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 11.25F);
            btnNhanVien.ForeColor = Color.Gainsboro;
            btnNhanVien.IconChar = IconChar.Vcard;
            btnNhanVien.IconColor = Color.Gainsboro;
            btnNhanVien.IconFont = IconFont.Auto;
            btnNhanVien.IconSize = 32;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 180);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 20, 0);
            btnNhanVien.Size = new Size(175, 60);
            btnNhanVien.TabIndex = 22;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            btnNhanVien.MouseEnter += btnSanPham_MouseEnter;
            btnNhanVien.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnHD_BH
            // 
            btnHD_BH.Dock = DockStyle.Top;
            btnHD_BH.FlatAppearance.BorderSize = 0;
            btnHD_BH.FlatStyle = FlatStyle.Flat;
            btnHD_BH.Font = new Font("Segoe UI", 11.25F);
            btnHD_BH.ForeColor = Color.Gainsboro;
            btnHD_BH.IconChar = IconChar.HandHoldingUsd;
            btnHD_BH.IconColor = Color.Gainsboro;
            btnHD_BH.IconFont = IconFont.Auto;
            btnHD_BH.IconSize = 32;
            btnHD_BH.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD_BH.Location = new Point(0, 120);
            btnHD_BH.Name = "btnHD_BH";
            btnHD_BH.Padding = new Padding(10, 0, 20, 0);
            btnHD_BH.Size = new Size(175, 60);
            btnHD_BH.TabIndex = 21;
            btnHD_BH.Text = "Bán hàng / Hóa đơn ";
            btnHD_BH.TextAlign = ContentAlignment.MiddleLeft;
            btnHD_BH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHD_BH.UseVisualStyleBackColor = true;
            btnHD_BH.Click += btnHD_BH_Click;
            btnHD_BH.MouseEnter += btnSanPham_MouseEnter;
            btnHD_BH.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnNhaSanXuat
            // 
            btnNhaSanXuat.Dock = DockStyle.Top;
            btnNhaSanXuat.FlatAppearance.BorderSize = 0;
            btnNhaSanXuat.FlatStyle = FlatStyle.Flat;
            btnNhaSanXuat.Font = new Font("Segoe UI", 11.25F);
            btnNhaSanXuat.ForeColor = Color.Gainsboro;
            btnNhaSanXuat.IconChar = IconChar.Handshake;
            btnNhaSanXuat.IconColor = Color.Gainsboro;
            btnNhaSanXuat.IconFont = IconFont.Auto;
            btnNhaSanXuat.IconSize = 32;
            btnNhaSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.Location = new Point(0, 60);
            btnNhaSanXuat.Name = "btnNhaSanXuat";
            btnNhaSanXuat.Padding = new Padding(10, 0, 20, 0);
            btnNhaSanXuat.Size = new Size(175, 60);
            btnNhaSanXuat.TabIndex = 20;
            btnNhaSanXuat.Text = "Nhà sản xuất";
            btnNhaSanXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaSanXuat.UseVisualStyleBackColor = true;
            btnNhaSanXuat.Click += btnNhaSanXuat_Click;
            btnNhaSanXuat.MouseEnter += btnSanPham_MouseEnter;
            btnNhaSanXuat.MouseLeave += btnSanPham_MouseLeave;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Transparent;
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 11.25F);
            btnSanPham.ForeColor = Color.Gainsboro;
            btnSanPham.IconChar = IconChar.Laptop;
            btnSanPham.IconColor = Color.Gainsboro;
            btnSanPham.IconFont = IconFont.Auto;
            btnSanPham.IconSize = 32;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 0);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 20, 0);
            btnSanPham.Size = new Size(175, 60);
            btnSanPham.TabIndex = 19;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            btnSanPham.MouseEnter += btnSanPham_MouseEnter;
            btnSanPham.MouseLeave += btnSanPham_MouseLeave;
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.Image = Properties.Resources.logo_home_but_zoom1;
            PictureBox1.Location = new Point(0, 4);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(175, 116);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            PictureBox1.Click += PictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.BorderRadius = 12;
            panelTitleBar.Controls.Add(guna2ImageButton2);
            panelTitleBar.Controls.Add(guna2ImageButton1);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(btnZoom);
            panelTitleBar.Controls.Add(btnMini);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.CustomizableEdges = customizableEdges5;
            panelTitleBar.FillColor = Color.FromArgb(202, 209, 234);
            panelTitleBar.FillColor2 = Color.FromArgb(94, 94, 170);
            panelTitleBar.Location = new Point(193, 7);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelTitleBar.Size = new Size(1150, 35);
            panelTitleBar.TabIndex = 7;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.BackColor = Color.Transparent;
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.HoverState.ImageSize = new Size(26, 26);
            guna2ImageButton2.Image = Properties.Resources.bot;
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.ImageSize = new Size(24, 24);
            guna2ImageButton2.Location = new Point(869, 3);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(26, 26);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton2.Size = new Size(30, 30);
            guna2ImageButton2.TabIndex = 16;
            guna2ImageButton2.Click += guna2ImageButton2_Click;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackColor = Color.Transparent;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(26, 26);
            guna2ImageButton1.Image = Properties.Resources.logout;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(24, 24);
            guna2ImageButton1.Location = new Point(915, 3);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(26, 26);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ImageButton1.Size = new Size(30, 30);
            guna2ImageButton1.TabIndex = 15;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.AutoSize = true;
            panelDesktop.BackColor = Color.FromArgb(149, 147, 186);
            panelDesktop.Controls.Add(label1);
            panelDesktop.Location = new Point(193, 50);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1157, 810);
            panelDesktop.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 174);
            label1.Name = "label1";
            label1.Size = new Size(155, 65);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 863);
            Controls.Add(panelContainer);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm_N";
            Activated += MainForm_N_Activated;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            ResizeEnd += MainForm_N_ResizeEnd;
            SizeChanged += MainForm_N_SizeChanged;
            Paint += MainForm_N_Paint;
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            MenuPanel.ResumeLayout(false);
            MenuChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContainer;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnZoom;
        private System.Windows.Forms.Timer timer1;
        private Panel panelDesktop;
        private ArtanPanel artanPanel1;
        private PictureBox PictureBox1;
        private Panel MenuChoice;
        private IconButton iconButton1;
        private IconButton btnTaiKhoan;
        private IconButton btnThongKe;
        private IconButton btnNH_PN;
        private IconButton btnKhuyenMai;
        private IconButton btnKhachHang;
        private IconButton btnNhanVien;
        private IconButton btnHD_BH;
        private IconButton btnNhaSanXuat;
        private IconButton btnSanPham;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTitleBar;
        private Guna.UI2.WinForms.Guna2GradientPanel MenuPanel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
    }
}