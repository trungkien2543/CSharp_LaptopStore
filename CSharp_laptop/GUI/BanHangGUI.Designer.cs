namespace CSharp_laptop.GUI
{
    partial class BanHangGUI
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
            tabHoaDon = new TabControl();
            QLHoaDon_page = new TabPage();
            ThemHD_page = new TabPage();
            btnChuyenTrang = new FontAwesome.Sharp.IconButton();
            tabThemHoaDon = new TabControl();
            ChonSanPham_page = new TabPage();
            label2 = new Label();
            panel1 = new Panel();
            lblTongTien = new Label();
            lblSoSanPhamDaChon = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtToGia = new TextBox();
            txtFromGia = new TextBox();
            label1 = new Label();
            cbxHang = new ComboBox();
            cbxSize = new ComboBox();
            cbxGPU = new ComboBox();
            cbxRAM = new ComboBox();
            cbxCPU = new ComboBox();
            listView1 = new ListView();
            ThanhToan_page = new TabPage();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnThanhToan = new FontAwesome.Sharp.IconButton();
            txtTienThoi = new TextBox();
            label12 = new Label();
            txtTienKhach = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            txtGiamGia = new TextBox();
            label9 = new Label();
            txtThanhTien = new TextBox();
            label8 = new Label();
            txtMaKH = new TextBox();
            label7 = new Label();
            txtMaNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtMaHD = new TextBox();
            label4 = new Label();
            label3 = new Label();
            listView2 = new ListView();
            btnBack = new FontAwesome.Sharp.IconButton();
            tabHoaDon.SuspendLayout();
            ThemHD_page.SuspendLayout();
            tabThemHoaDon.SuspendLayout();
            ChonSanPham_page.SuspendLayout();
            panel1.SuspendLayout();
            ThanhToan_page.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabHoaDon
            // 
            tabHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabHoaDon.Controls.Add(QLHoaDon_page);
            tabHoaDon.Controls.Add(ThemHD_page);
            tabHoaDon.Location = new Point(0, -33);
            tabHoaDon.Margin = new Padding(3, 4, 3, 4);
            tabHoaDon.Name = "tabHoaDon";
            tabHoaDon.SelectedIndex = 0;
            tabHoaDon.Size = new Size(1343, 963);
            tabHoaDon.TabIndex = 0;
            // 
            // QLHoaDon_page
            // 
            QLHoaDon_page.Location = new Point(4, 29);
            QLHoaDon_page.Margin = new Padding(3, 4, 3, 4);
            QLHoaDon_page.Name = "QLHoaDon_page";
            QLHoaDon_page.Padding = new Padding(3, 4, 3, 4);
            QLHoaDon_page.Size = new Size(1335, 930);
            QLHoaDon_page.TabIndex = 0;
            QLHoaDon_page.Text = "Danh sách hóa đơn";
            QLHoaDon_page.UseVisualStyleBackColor = true;
            // 
            // ThemHD_page
            // 
            ThemHD_page.BackColor = Color.Transparent;
            ThemHD_page.Controls.Add(btnChuyenTrang);
            ThemHD_page.Controls.Add(tabThemHoaDon);
            ThemHD_page.Controls.Add(btnBack);
            ThemHD_page.Location = new Point(4, 29);
            ThemHD_page.Margin = new Padding(3, 4, 3, 4);
            ThemHD_page.Name = "ThemHD_page";
            ThemHD_page.Padding = new Padding(3, 4, 3, 4);
            ThemHD_page.Size = new Size(1335, 930);
            ThemHD_page.TabIndex = 1;
            ThemHD_page.Text = "Thêm hóa đơn";
            // 
            // btnChuyenTrang
            // 
            btnChuyenTrang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChuyenTrang.BackColor = Color.FromArgb(0, 123, 255);
            btnChuyenTrang.ForeColor = Color.White;
            btnChuyenTrang.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnChuyenTrang.IconColor = Color.White;
            btnChuyenTrang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChuyenTrang.IconSize = 30;
            btnChuyenTrang.Location = new Point(1018, 852);
            btnChuyenTrang.Margin = new Padding(3, 4, 3, 4);
            btnChuyenTrang.Name = "btnChuyenTrang";
            btnChuyenTrang.Padding = new Padding(3, 4, 3, 4);
            btnChuyenTrang.Size = new Size(195, 69);
            btnChuyenTrang.TabIndex = 2;
            btnChuyenTrang.Text = "Nhập thông tin chi tiết";
            btnChuyenTrang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChuyenTrang.UseVisualStyleBackColor = false;
            // 
            // tabThemHoaDon
            // 
            tabThemHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabThemHoaDon.Controls.Add(ChonSanPham_page);
            tabThemHoaDon.Controls.Add(ThanhToan_page);
            tabThemHoaDon.Location = new Point(-5, -32);
            tabThemHoaDon.Margin = new Padding(3, 4, 3, 4);
            tabThemHoaDon.Name = "tabThemHoaDon";
            tabThemHoaDon.SelectedIndex = 0;
            tabThemHoaDon.Size = new Size(1338, 884);
            tabThemHoaDon.TabIndex = 1;
            // 
            // ChonSanPham_page
            // 
            ChonSanPham_page.BackColor = Color.White;
            ChonSanPham_page.Controls.Add(label2);
            ChonSanPham_page.Controls.Add(panel1);
            ChonSanPham_page.Controls.Add(listView1);
            ChonSanPham_page.Location = new Point(4, 29);
            ChonSanPham_page.Margin = new Padding(3, 4, 3, 4);
            ChonSanPham_page.Name = "ChonSanPham_page";
            ChonSanPham_page.Padding = new Padding(3, 4, 3, 4);
            ChonSanPham_page.Size = new Size(1330, 851);
            ChonSanPham_page.TabIndex = 0;
            ChonSanPham_page.Text = "tabPage3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(273, 28);
            label2.TabIndex = 11;
            label2.Text = "Chọn sản phẩm cho đơn hàng";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(lblSoSanPhamDaChon);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(txtToGia);
            panel1.Controls.Add(txtFromGia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbxHang);
            panel1.Controls.Add(cbxSize);
            panel1.Controls.Add(cbxGPU);
            panel1.Controls.Add(cbxRAM);
            panel1.Controls.Add(cbxCPU);
            panel1.Location = new Point(0, 36);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 109);
            panel1.TabIndex = 10;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(834, 59);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(167, 32);
            lblTongTien.TabIndex = 20;
            lblTongTien.Text = "Tổng số tiền:  ";
            // 
            // lblSoSanPhamDaChon
            // 
            lblSoSanPhamDaChon.AutoSize = true;
            lblSoSanPhamDaChon.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoSanPhamDaChon.Location = new Point(834, 7);
            lblSoSanPhamDaChon.Name = "lblSoSanPhamDaChon";
            lblSoSanPhamDaChon.Size = new Size(316, 32);
            lblSoSanPhamDaChon.TabIndex = 19;
            lblSoSanPhamDaChon.Text = "Tổng số sản phẩm đã chọn: ";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(0, 123, 255);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(1251, 3);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(71, 103);
            iconButton1.TabIndex = 18;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtToGia
            // 
            txtToGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToGia.Location = new Point(530, 59);
            txtToGia.Margin = new Padding(3, 4, 3, 4);
            txtToGia.Name = "txtToGia";
            txtToGia.Size = new Size(185, 39);
            txtToGia.TabIndex = 17;
            // 
            // txtFromGia
            // 
            txtFromGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFromGia.Location = new Point(338, 61);
            txtFromGia.Margin = new Padding(3, 4, 3, 4);
            txtFromGia.Name = "txtFromGia";
            txtFromGia.Size = new Size(185, 39);
            txtFromGia.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 63);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 15;
            label1.Text = "Khoảng giá";
            // 
            // cbxHang
            // 
            cbxHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxHang.FormattingEnabled = true;
            cbxHang.Location = new Point(7, 59);
            cbxHang.Margin = new Padding(3, 4, 3, 4);
            cbxHang.Name = "cbxHang";
            cbxHang.Size = new Size(185, 40);
            cbxHang.TabIndex = 14;
            // 
            // cbxSize
            // 
            cbxSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxSize.FormattingEnabled = true;
            cbxSize.Location = new Point(530, 7);
            cbxSize.Margin = new Padding(3, 4, 3, 4);
            cbxSize.Name = "cbxSize";
            cbxSize.Size = new Size(185, 40);
            cbxSize.TabIndex = 13;
            // 
            // cbxGPU
            // 
            cbxGPU.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxGPU.FormattingEnabled = true;
            cbxGPU.Location = new Point(338, 7);
            cbxGPU.Margin = new Padding(3, 4, 3, 4);
            cbxGPU.Name = "cbxGPU";
            cbxGPU.Size = new Size(185, 40);
            cbxGPU.TabIndex = 12;
            // 
            // cbxRAM
            // 
            cbxRAM.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRAM.FormattingEnabled = true;
            cbxRAM.Location = new Point(199, 7);
            cbxRAM.Margin = new Padding(3, 4, 3, 4);
            cbxRAM.Name = "cbxRAM";
            cbxRAM.Size = new Size(132, 40);
            cbxRAM.TabIndex = 11;
            // 
            // cbxCPU
            // 
            cbxCPU.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCPU.FormattingEnabled = true;
            cbxCPU.Location = new Point(7, 7);
            cbxCPU.Margin = new Padding(3, 4, 3, 4);
            cbxCPU.Name = "cbxCPU";
            cbxCPU.Size = new Size(185, 40);
            cbxCPU.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(0, 152);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1325, 685);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ThanhToan_page
            // 
            ThanhToan_page.BackColor = Color.White;
            ThanhToan_page.Controls.Add(panel2);
            ThanhToan_page.Controls.Add(label3);
            ThanhToan_page.Controls.Add(listView2);
            ThanhToan_page.Location = new Point(4, 29);
            ThanhToan_page.Margin = new Padding(3, 4, 3, 4);
            ThanhToan_page.Name = "ThanhToan_page";
            ThanhToan_page.Padding = new Padding(3, 4, 3, 4);
            ThanhToan_page.Size = new Size(1330, 851);
            ThanhToan_page.TabIndex = 1;
            ThanhToan_page.Text = "tabPage4";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnThanhToan);
            panel2.Controls.Add(txtTienThoi);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtTienKhach);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtGiamGia);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtThanhTien);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtMaKH);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMaNV);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtMaHD);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(583, 53);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 786);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.thank_you;
            pictureBox1.Location = new Point(473, 309);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 269);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LawnGreen;
            btnThanhToan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnThanhToan.IconColor = Color.Black;
            btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThanhToan.Location = new Point(10, 701);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Padding = new Padding(57, 0, 0, 0);
            btnThanhToan.Size = new Size(397, 60);
            btnThanhToan.TabIndex = 18;
            btnThanhToan.Text = "Thanh toán hóa đơn";
            btnThanhToan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // txtTienThoi
            // 
            txtTienThoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienThoi.Location = new Point(187, 627);
            txtTienThoi.Margin = new Padding(3, 4, 3, 4);
            txtTienThoi.Name = "txtTienThoi";
            txtTienThoi.Size = new Size(220, 34);
            txtTienThoi.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 631);
            label12.Name = "label12";
            label12.Size = new Size(97, 28);
            label12.TabIndex = 16;
            label12.Text = "Tiền thối: ";
            // 
            // txtTienKhach
            // 
            txtTienKhach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienKhach.Location = new Point(187, 527);
            txtTienKhach.Margin = new Padding(3, 4, 3, 4);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(220, 34);
            txtTienKhach.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 531);
            label11.Name = "label11";
            label11.Size = new Size(152, 28);
            label11.TabIndex = 14;
            label11.Text = "Tiền khách đưa: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(187, 437);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 34);
            textBox1.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 441);
            label10.Name = "label10";
            label10.Size = new Size(187, 28);
            label10.TabIndex = 12;
            label10.Text = "Tổng tiền sau giảm: ";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiamGia.Location = new Point(187, 339);
            txtGiamGia.Margin = new Padding(3, 4, 3, 4);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(220, 34);
            txtGiamGia.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 343);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 10;
            label9.Text = "Giảm giá: ";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThanhTien.Location = new Point(187, 259);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(220, 34);
            txtThanhTien.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 263);
            label8.Name = "label8";
            label8.Size = new Size(153, 28);
            label8.TabIndex = 8;
            label8.Text = "Tổng tiền hàng: ";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(187, 176);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(220, 34);
            txtMaKH.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 180);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 6;
            label7.Text = "Mã khách hàng: ";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(187, 101);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(220, 34);
            txtMaNV.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 105);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 4;
            label6.Text = "Mã nhân viên: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(439, 20);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 2;
            label5.Text = "Ngày lập: ";
            // 
            // txtMaHD
            // 
            txtMaHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaHD.Location = new Point(187, 16);
            txtMaHD.Margin = new Padding(3, 4, 3, 4);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(219, 34);
            txtMaHD.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 13);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 0;
            label4.Text = "Mã hóa đơn: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 1;
            label3.Text = "Chi tiết hóa đơn";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Location = new Point(0, 55);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(575, 783);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(108, 117, 125);
            btnBack.ForeColor = Color.White;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnBack.IconColor = Color.White;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 30;
            btnBack.Location = new Point(1221, 849);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 75);
            btnBack.TabIndex = 0;
            btnBack.Text = "Hủy bỏ";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // BanHangGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 929);
            Controls.Add(tabHoaDon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BanHangGUI";
            Text = "BanHangGUI";
            tabHoaDon.ResumeLayout(false);
            ThemHD_page.ResumeLayout(false);
            tabThemHoaDon.ResumeLayout(false);
            ChonSanPham_page.ResumeLayout(false);
            ChonSanPham_page.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ThanhToan_page.ResumeLayout(false);
            ThanhToan_page.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabHoaDon;
        private TabPage QLHoaDon_page;
        private TabPage ThemHD_page;
        private FontAwesome.Sharp.IconButton btnBack;
        private TabControl tabThemHoaDon;
        private TabPage ChonSanPham_page;
        private TabPage ThanhToan_page;
        private FontAwesome.Sharp.IconButton btnChuyenTrang;
        private ListView listView1;
        private Panel panel1;
        private TextBox txtToGia;
        private TextBox txtFromGia;
        private Label label1;
        private ComboBox cbxHang;
        private ComboBox cbxSize;
        private ComboBox cbxGPU;
        private ComboBox cbxRAM;
        private ComboBox cbxCPU;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblSoSanPhamDaChon;
        private Label lblTongTien;
        private ListView listView2;
        private Label label3;
        private Panel panel2;
        private TextBox txtMaHD;
        private Label label4;
        private Label label5;
        private TextBox txtMaNV;
        private Label label6;
        private TextBox textBox1;
        private Label label10;
        private TextBox txtGiamGia;
        private Label label9;
        private TextBox txtThanhTien;
        private Label label8;
        private TextBox txtMaKH;
        private Label label7;
        private TextBox txtTienThoi;
        private Label label12;
        private TextBox txtTienKhach;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private PictureBox pictureBox1;
    }
}