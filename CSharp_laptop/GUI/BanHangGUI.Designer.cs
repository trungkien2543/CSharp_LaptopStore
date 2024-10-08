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
            dateTimePicker1 = new DateTimePicker();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtFindHD = new TextBox();
            btnXemChiTiet = new FontAwesome.Sharp.IconButton();
            btnThemHD = new FontAwesome.Sharp.IconButton();
            tblHoaDon = new ListView();
            ThemHD_page = new TabPage();
            btnChuyenTrang = new FontAwesome.Sharp.IconButton();
            tabThemHoaDon = new TabControl();
            ChonSanPham_page = new TabPage();
            label2 = new Label();
            panel1 = new Panel();
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
            btnBack = new FontAwesome.Sharp.IconButton();
            tabHoaDon.SuspendLayout();
            QLHoaDon_page.SuspendLayout();
            ThemHD_page.SuspendLayout();
            tabThemHoaDon.SuspendLayout();
            ChonSanPham_page.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabHoaDon
            // 
            tabHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabHoaDon.Controls.Add(QLHoaDon_page);
            tabHoaDon.Controls.Add(ThemHD_page);
            tabHoaDon.Location = new Point(0, -25);
            tabHoaDon.Name = "tabHoaDon";
            tabHoaDon.SelectedIndex = 0;
            tabHoaDon.Size = new Size(1288, 722);
            tabHoaDon.TabIndex = 0;
            // 
            // QLHoaDon_page
            // 
            QLHoaDon_page.Controls.Add(dateTimePicker1);
            QLHoaDon_page.Controls.Add(btnRefresh);
            QLHoaDon_page.Controls.Add(txtFindHD);
            QLHoaDon_page.Controls.Add(btnXemChiTiet);
            QLHoaDon_page.Controls.Add(btnThemHD);
            QLHoaDon_page.Controls.Add(tblHoaDon);
            QLHoaDon_page.Location = new Point(4, 24);
            QLHoaDon_page.Name = "QLHoaDon_page";
            QLHoaDon_page.Padding = new Padding(3);
            QLHoaDon_page.Size = new Size(1280, 694);
            QLHoaDon_page.TabIndex = 0;
            QLHoaDon_page.Text = "Danh sách hóa đơn";
            QLHoaDon_page.UseVisualStyleBackColor = true;
            QLHoaDon_page.Click += tabPage1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 123, 255);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 40;
            btnRefresh.Location = new Point(348, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 57);
            btnRefresh.TabIndex = 4;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtFindHD
            // 
            txtFindHD.BorderStyle = BorderStyle.FixedSingle;
            txtFindHD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFindHD.Location = new Point(6, 6);
            txtFindHD.Name = "txtFindHD";
            txtFindHD.Size = new Size(336, 29);
            txtFindHD.TabIndex = 3;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.AllowDrop = true;
            btnXemChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXemChiTiet.BackColor = Color.FromArgb(23, 162, 184);
            btnXemChiTiet.ForeColor = Color.White;
            btnXemChiTiet.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnXemChiTiet.IconColor = Color.White;
            btnXemChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXemChiTiet.IconSize = 30;
            btnXemChiTiet.Location = new Point(1071, 3);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(108, 44);
            btnXemChiTiet.TabIndex = 2;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXemChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnThemHD
            // 
            btnThemHD.AllowDrop = true;
            btnThemHD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemHD.BackColor = Color.FromArgb(76, 175, 80);
            btnThemHD.ForeColor = Color.White;
            btnThemHD.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThemHD.IconColor = Color.White;
            btnThemHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemHD.IconSize = 30;
            btnThemHD.Location = new Point(1185, 3);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new Size(92, 44);
            btnThemHD.TabIndex = 1;
            btnThemHD.Text = "Thêm";
            btnThemHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // tblHoaDon
            // 
            tblHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblHoaDon.Location = new Point(0, 81);
            tblHoaDon.Name = "tblHoaDon";
            tblHoaDon.Size = new Size(1280, 613);
            tblHoaDon.TabIndex = 0;
            tblHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // ThemHD_page
            // 
            ThemHD_page.BackColor = Color.Transparent;
            ThemHD_page.Controls.Add(btnChuyenTrang);
            ThemHD_page.Controls.Add(tabThemHoaDon);
            ThemHD_page.Controls.Add(btnBack);
            ThemHD_page.Location = new Point(4, 24);
            ThemHD_page.Name = "ThemHD_page";
            ThemHD_page.Padding = new Padding(3);
            ThemHD_page.Size = new Size(1280, 694);
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
            btnChuyenTrang.Location = new Point(1011, 640);
            btnChuyenTrang.Name = "btnChuyenTrang";
            btnChuyenTrang.Padding = new Padding(3);
            btnChuyenTrang.Size = new Size(171, 52);
            btnChuyenTrang.TabIndex = 2;
            btnChuyenTrang.Text = "Nhập thông tin chi tiết";
            btnChuyenTrang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChuyenTrang.UseVisualStyleBackColor = false;
            btnChuyenTrang.Click += btnChuyenTrang_Click;
            // 
            // tabThemHoaDon
            // 
            tabThemHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabThemHoaDon.Controls.Add(ChonSanPham_page);
            tabThemHoaDon.Controls.Add(ThanhToan_page);
            tabThemHoaDon.Location = new Point(-4, -24);
            tabThemHoaDon.Name = "tabThemHoaDon";
            tabThemHoaDon.SelectedIndex = 0;
            tabThemHoaDon.Size = new Size(1288, 663);
            tabThemHoaDon.TabIndex = 1;
            // 
            // ChonSanPham_page
            // 
            ChonSanPham_page.BackColor = Color.White;
            ChonSanPham_page.Controls.Add(label2);
            ChonSanPham_page.Controls.Add(panel1);
            ChonSanPham_page.Controls.Add(listView1);
            ChonSanPham_page.Location = new Point(4, 24);
            ChonSanPham_page.Name = "ChonSanPham_page";
            ChonSanPham_page.Padding = new Padding(3);
            ChonSanPham_page.Size = new Size(1280, 635);
            ChonSanPham_page.TabIndex = 0;
            ChonSanPham_page.Text = "tabPage3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(219, 21);
            label2.TabIndex = 11;
            label2.Text = "Chọn sản phẩm cho đơn hàng";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(txtToGia);
            panel1.Controls.Add(txtFromGia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbxHang);
            panel1.Controls.Add(cbxSize);
            panel1.Controls.Add(cbxGPU);
            panel1.Controls.Add(cbxRAM);
            panel1.Controls.Add(cbxCPU);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 82);
            panel1.TabIndex = 10;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(0, 123, 255);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(1212, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(62, 77);
            iconButton1.TabIndex = 18;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtToGia
            // 
            txtToGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToGia.Location = new Point(464, 44);
            txtToGia.Name = "txtToGia";
            txtToGia.Size = new Size(162, 33);
            txtToGia.TabIndex = 17;
            // 
            // txtFromGia
            // 
            txtFromGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFromGia.Location = new Point(296, 46);
            txtFromGia.Name = "txtFromGia";
            txtFromGia.Size = new Size(162, 33);
            txtFromGia.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 47);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 15;
            label1.Text = "Khoảng giá";
            // 
            // cbxHang
            // 
            cbxHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxHang.FormattingEnabled = true;
            cbxHang.Location = new Point(6, 44);
            cbxHang.Name = "cbxHang";
            cbxHang.Size = new Size(162, 33);
            cbxHang.TabIndex = 14;
            // 
            // cbxSize
            // 
            cbxSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxSize.FormattingEnabled = true;
            cbxSize.Location = new Point(464, 5);
            cbxSize.Name = "cbxSize";
            cbxSize.Size = new Size(162, 33);
            cbxSize.TabIndex = 13;
            // 
            // cbxGPU
            // 
            cbxGPU.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxGPU.FormattingEnabled = true;
            cbxGPU.Location = new Point(296, 5);
            cbxGPU.Name = "cbxGPU";
            cbxGPU.Size = new Size(162, 33);
            cbxGPU.TabIndex = 12;
            // 
            // cbxRAM
            // 
            cbxRAM.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRAM.FormattingEnabled = true;
            cbxRAM.Location = new Point(174, 5);
            cbxRAM.Name = "cbxRAM";
            cbxRAM.Size = new Size(116, 33);
            cbxRAM.TabIndex = 11;
            // 
            // cbxCPU
            // 
            cbxCPU.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCPU.FormattingEnabled = true;
            cbxCPU.Location = new Point(6, 5);
            cbxCPU.Name = "cbxCPU";
            cbxCPU.Size = new Size(162, 33);
            cbxCPU.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(0, 114);
            listView1.Name = "listView1";
            listView1.Size = new Size(1280, 521);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ThanhToan_page
            // 
            ThanhToan_page.BackColor = Color.Orange;
            ThanhToan_page.Location = new Point(4, 24);
            ThanhToan_page.Name = "ThanhToan_page";
            ThanhToan_page.Padding = new Padding(3);
            ThanhToan_page.Size = new Size(1280, 635);
            ThanhToan_page.TabIndex = 1;
            ThanhToan_page.Text = "tabPage4";
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
            btnBack.Location = new Point(1188, 638);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 56);
            btnBack.TabIndex = 0;
            btnBack.Text = "Hủy bỏ";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BanHangGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 697);
            Controls.Add(tabHoaDon);
            Name = "BanHangGUI";
            Text = "BanHangGUI";
            Load += BanHangGUI_Load;
            tabHoaDon.ResumeLayout(false);
            QLHoaDon_page.ResumeLayout(false);
            QLHoaDon_page.PerformLayout();
            ThemHD_page.ResumeLayout(false);
            tabThemHoaDon.ResumeLayout(false);
            ChonSanPham_page.ResumeLayout(false);
            ChonSanPham_page.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabHoaDon;
        private TabPage QLHoaDon_page;
        private TabPage ThemHD_page;
        private ListView tblHoaDon;
        private FontAwesome.Sharp.IconButton btnThemHD;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnXemChiTiet;
        private TextBox txtFindHD;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DateTimePicker dateTimePicker1;
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
    }
}