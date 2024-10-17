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
            btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnNH_PN = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            btnHD_BH = new FontAwesome.Sharp.IconButton();
            btnNhaSanXuat = new FontAwesome.Sharp.IconButton();
            btnSanPham = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMini = new FontAwesome.Sharp.IconButton();
            btnZoom = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
<<<<<<< HEAD
            panelMenu.Size = new Size(251, 980);
=======
            panelMenu.Size = new Size(220, 837);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            panelMenu.TabIndex = 0;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.ForeColor = Color.Gainsboro;
            btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.AccessibleIcon;
            btnTaiKhoan.IconColor = Color.Gainsboro;
            btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaiKhoan.IconSize = 32;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(0, 827);
            btnTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(11, 0, 23, 0);
            btnTaiKhoan.Size = new Size(251, 80);
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
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnThongKe.IconColor = Color.Gainsboro;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.IconSize = 32;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 747);
            btnThongKe.Margin = new Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(11, 0, 23, 0);
            btnThongKe.Size = new Size(251, 80);
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
            btnNH_PN.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            btnNH_PN.IconColor = Color.Gainsboro;
            btnNH_PN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNH_PN.IconSize = 32;
            btnNH_PN.ImageAlign = ContentAlignment.MiddleLeft;
            btnNH_PN.Location = new Point(0, 667);
            btnNH_PN.Margin = new Padding(3, 4, 3, 4);
            btnNH_PN.Name = "btnNH_PN";
            btnNH_PN.Padding = new Padding(11, 0, 23, 0);
            btnNH_PN.Size = new Size(251, 80);
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
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            btnKhuyenMai.IconColor = Color.Gainsboro;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.IconSize = 32;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(0, 587);
            btnKhuyenMai.Margin = new Padding(3, 4, 3, 4);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(11, 0, 23, 0);
            btnKhuyenMai.Size = new Size(251, 80);
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
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            btnKhachHang.IconColor = Color.Gainsboro;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.IconSize = 32;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 507);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(11, 0, 23, 0);
            btnKhachHang.Size = new Size(251, 80);
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
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnNhanVien.IconColor = Color.Gainsboro;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.IconSize = 32;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 427);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(11, 0, 23, 0);
            btnNhanVien.Size = new Size(251, 80);
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
            btnHD_BH.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnHD_BH.IconColor = Color.Gainsboro;
            btnHD_BH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHD_BH.IconSize = 32;
            btnHD_BH.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD_BH.Location = new Point(0, 347);
            btnHD_BH.Margin = new Padding(3, 4, 3, 4);
            btnHD_BH.Name = "btnHD_BH";
            btnHD_BH.Padding = new Padding(11, 0, 23, 0);
            btnHD_BH.Size = new Size(251, 80);
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
            btnNhaSanXuat.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            btnNhaSanXuat.IconColor = Color.Gainsboro;
            btnNhaSanXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaSanXuat.IconSize = 32;
            btnNhaSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.Location = new Point(0, 267);
            btnNhaSanXuat.Margin = new Padding(3, 4, 3, 4);
            btnNhaSanXuat.Name = "btnNhaSanXuat";
            btnNhaSanXuat.Padding = new Padding(11, 0, 23, 0);
            btnNhaSanXuat.Size = new Size(251, 80);
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
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            btnSanPham.IconColor = Color.Gainsboro;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.IconSize = 32;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 187);
            btnSanPham.Margin = new Padding(3, 4, 3, 4);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(11, 0, 23, 0);
            btnSanPham.Size = new Size(251, 80);
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
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(11, 0, 23, 0);
            panelLogo.Size = new Size(251, 187);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
<<<<<<< HEAD
            btnHome.Image = Properties.Resources.Jasper987_rrx6kw;
            btnHome.Location = new Point(15, 33);
            btnHome.Margin = new Padding(3, 4, 3, 4);
=======
            btnHome.Image = Properties.Resources.logo_home_removebg;
            btnHome.Location = new Point(13, 25);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(210, 112);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(btnMini);
            panelTitleBar.Controls.Add(btnZoom);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(251, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
<<<<<<< HEAD
            panelTitleBar.Size = new Size(1102, 69);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
=======
            panelTitleBar.Size = new Size(1133, 34);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1099, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(1, 10, 0, 10);
            btnExit.Size = new Size(34, 22);
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
            btnMini.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMini.IconColor = Color.Gainsboro;
            btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMini.IconSize = 20;
            btnMini.ImageAlign = ContentAlignment.MiddleLeft;
            btnMini.Location = new Point(1030, 0);
            btnMini.Margin = new Padding(0);
            btnMini.Name = "btnMini";
            btnMini.Padding = new Padding(3, 10, 0, 10);
            btnMini.Size = new Size(34, 22);
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
            btnZoom.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnZoom.IconColor = Color.Gainsboro;
            btnZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnZoom.IconSize = 20;
            btnZoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnZoom.Location = new Point(1064, 0);
            btnZoom.Margin = new Padding(0);
            btnZoom.Name = "btnZoom";
            btnZoom.Padding = new Padding(3, 10, 0, 10);
            btnZoom.Size = new Size(34, 22);
            btnZoom.TabIndex = 4;
            btnZoom.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
<<<<<<< HEAD
            lblTitleChildForm.Location = new Point(58, 24);
=======
            lblTitleChildForm.Location = new Point(51, 9);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(65, 28);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += label1_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
<<<<<<< HEAD
            iconCurrentChildForm.IconSize = 37;
            iconCurrentChildForm.Location = new Point(15, 16);
            iconCurrentChildForm.Margin = new Padding(3, 4, 3, 4);
=======
            iconCurrentChildForm.Location = new Point(13, 4);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(37, 43);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
<<<<<<< HEAD
            panelShadow.Location = new Point(251, 69);
            panelShadow.Margin = new Padding(3, 4, 3, 4);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1102, 12);
=======
            panelShadow.Location = new Point(220, 34);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1133, 9);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panelDesktop.Location = new Point(251, 81);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1102, 899);
=======
            panelDesktop.Location = new Point(220, 43);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1133, 794);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
<<<<<<< HEAD
            pictureBox1.Image = Properties.Resources.Jasper987_rrx6kw;
            pictureBox1.Location = new Point(313, 248);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
=======
            pictureBox1.Image = Properties.Resources.logo_home_removebg;
            pictureBox1.Location = new Point(358, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
<<<<<<< HEAD
            ClientSize = new Size(1353, 980);
=======
            ClientSize = new Size(1353, 837);
>>>>>>> 91b0426439fa0c68bf94ca2fc80679799218fa53
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnNH_PN;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnZoom;
        private FontAwesome.Sharp.IconButton btnMini;
    }
}