using CSharp_laptop.UI_cos;

namespace CSharp_laptop.GUI.BanHang
{
    partial class BanHangForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabGioHang = new TabPage();
            artanPanel1 = new ArtanPanel();
            lblSoTien = new Label();
            lblSoSanPham = new Label();
            btnQuayLai = new VBButton();
            btnThemThongTin = new VBButton();
            cbxKichThuoc = new ComboBox();
            tbGia = new TrackBar();
            cbxRAM = new ComboBox();
            cbxHang = new ComboBox();
            cbxGPU = new ComboBox();
            cbxCPU = new ComboBox();
            rjTextBox1 = new RJTextBox();
            artanPanel2 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tabThanhToan = new TabPage();
            artanPanel4 = new ArtanPanel();
            txtTichDiem = new RJTextBox();
            label4 = new Label();
            txtMaKH = new RJTextBox();
            label3 = new Label();
            txtMaNV = new RJTextBox();
            label2 = new Label();
            dtpNgayLap = new RJDateTimePicker.RJDatePicker();
            label1 = new Label();
            btnHuy = new VBButton();
            btnGioHang = new VBButton();
            vbButton3 = new VBButton();
            vbButton1 = new VBButton();
            vbButton2 = new VBButton();
            artanPanel3 = new ArtanPanel();
            dataGridView2 = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            txtTienGiam = new RJTextBox();
            label5 = new Label();
            txtTienNhan = new RJTextBox();
            label6 = new Label();
            txtTongTien = new RJTextBox();
            label7 = new Label();
            txtTienThoi = new RJTextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabGioHang.SuspendLayout();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbGia).BeginInit();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabThanhToan.SuspendLayout();
            artanPanel4.SuspendLayout();
            artanPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabGioHang);
            tabControl1.Controls.Add(tabThanhToan);
            tabControl1.Location = new Point(-3, -23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1122, 742);
            tabControl1.TabIndex = 0;
            // 
            // tabGioHang
            // 
            tabGioHang.Controls.Add(artanPanel1);
            tabGioHang.Controls.Add(artanPanel2);
            tabGioHang.Location = new Point(4, 24);
            tabGioHang.Name = "tabGioHang";
            tabGioHang.Padding = new Padding(3);
            tabGioHang.Size = new Size(1114, 714);
            tabGioHang.TabIndex = 0;
            tabGioHang.Text = "tabPage1";
            tabGioHang.UseVisualStyleBackColor = true;
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
            artanPanel1.Controls.Add(lblSoTien);
            artanPanel1.Controls.Add(lblSoSanPham);
            artanPanel1.Controls.Add(btnQuayLai);
            artanPanel1.Controls.Add(btnThemThongTin);
            artanPanel1.Controls.Add(cbxKichThuoc);
            artanPanel1.Controls.Add(tbGia);
            artanPanel1.Controls.Add(cbxRAM);
            artanPanel1.Controls.Add(cbxHang);
            artanPanel1.Controls.Add(cbxGPU);
            artanPanel1.Controls.Add(cbxCPU);
            artanPanel1.Controls.Add(rjTextBox1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(244, 107, 69);
            artanPanel1.GradientTopColor = Color.FromArgb(238, 168, 73);
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1114, 173);
            artanPanel1.TabIndex = 40;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.BackColor = Color.Transparent;
            lblSoTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoTien.ForeColor = Color.White;
            lblSoTien.Location = new Point(544, 102);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(130, 25);
            lblSoTien.TabIndex = 48;
            lblSoTien.Text = "Tổng số tiền:  ";
            // 
            // lblSoSanPham
            // 
            lblSoSanPham.AutoSize = true;
            lblSoSanPham.BackColor = Color.Transparent;
            lblSoSanPham.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoSanPham.ForeColor = Color.White;
            lblSoSanPham.Location = new Point(544, 45);
            lblSoSanPham.Name = "lblSoSanPham";
            lblSoSanPham.Size = new Size(249, 25);
            lblSoSanPham.TabIndex = 47;
            lblSoSanPham.Text = "Tổng số sản phẩm đã thêm: ";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuayLai.BackColor = Color.Gray;
            btnQuayLai.BackgroundColor = Color.Gray;
            btnQuayLai.BorderColor = Color.PaleVioletRed;
            btnQuayLai.BorderRadius = 15;
            btnQuayLai.BorderSize = 0;
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = Color.White;
            btnQuayLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuayLai.Location = new Point(965, 102);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(145, 56);
            btnQuayLai.TabIndex = 46;
            btnQuayLai.Text = "Hủy";
            btnQuayLai.TextColor = Color.White;
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnThemThongTin
            // 
            btnThemThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemThongTin.BackColor = Color.CornflowerBlue;
            btnThemThongTin.BackgroundColor = Color.CornflowerBlue;
            btnThemThongTin.BorderColor = Color.PaleVioletRed;
            btnThemThongTin.BorderRadius = 15;
            btnThemThongTin.BorderSize = 0;
            btnThemThongTin.FlatAppearance.BorderSize = 0;
            btnThemThongTin.FlatStyle = FlatStyle.Flat;
            btnThemThongTin.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemThongTin.ForeColor = Color.White;
            btnThemThongTin.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemThongTin.Location = new Point(965, 25);
            btnThemThongTin.Name = "btnThemThongTin";
            btnThemThongTin.Size = new Size(145, 56);
            btnThemThongTin.TabIndex = 45;
            btnThemThongTin.Text = "Thanh toán";
            btnThemThongTin.TextColor = Color.White;
            btnThemThongTin.UseVisualStyleBackColor = false;
            btnThemThongTin.Click += btnThemThongTin_Click;
            // 
            // cbxKichThuoc
            // 
            cbxKichThuoc.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxKichThuoc.FormattingEnabled = true;
            cbxKichThuoc.Location = new Point(253, 122);
            cbxKichThuoc.Name = "cbxKichThuoc";
            cbxKichThuoc.Size = new Size(237, 46);
            cbxKichThuoc.TabIndex = 44;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(8, 122);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(239, 45);
            tbGia.TabIndex = 43;
            // 
            // cbxRAM
            // 
            cbxRAM.FormattingEnabled = true;
            cbxRAM.Location = new Point(253, 83);
            cbxRAM.Name = "cbxRAM";
            cbxRAM.Size = new Size(237, 23);
            cbxRAM.TabIndex = 42;
            // 
            // cbxHang
            // 
            cbxHang.FormattingEnabled = true;
            cbxHang.Location = new Point(253, 45);
            cbxHang.Name = "cbxHang";
            cbxHang.Size = new Size(237, 23);
            cbxHang.TabIndex = 41;
            // 
            // cbxGPU
            // 
            cbxGPU.FormattingEnabled = true;
            cbxGPU.Location = new Point(8, 83);
            cbxGPU.Name = "cbxGPU";
            cbxGPU.Size = new Size(239, 23);
            cbxGPU.TabIndex = 40;
            // 
            // cbxCPU
            // 
            cbxCPU.FormattingEnabled = true;
            cbxCPU.Location = new Point(8, 45);
            cbxCPU.Name = "cbxCPU";
            cbxCPU.Size = new Size(239, 23);
            cbxCPU.TabIndex = 39;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(238, 168, 73);
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(8, 7);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(482, 31);
            rjTextBox1.TabIndex = 38;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 10;
            artanPanel2.Controls.Add(dataGridView1);
            artanPanel2.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.FromArgb(238, 168, 73);
            artanPanel2.GradientTopColor = Color.FromArgb(238, 168, 73);
            artanPanel2.Location = new Point(0, 179);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Padding = new Padding(4, 0, 4, 15);
            artanPanel2.Size = new Size(1114, 535);
            artanPanel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(238, 168, 73);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(238, 168, 73);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(4, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1106, 520);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Giá bán";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Hãng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 74;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "CPU";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "RAM";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 69;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "GPU";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Kích thước";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Khuyến mãi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // tabThanhToan
            // 
            tabThanhToan.Controls.Add(artanPanel4);
            tabThanhToan.Controls.Add(artanPanel3);
            tabThanhToan.Location = new Point(4, 24);
            tabThanhToan.Name = "tabThanhToan";
            tabThanhToan.Padding = new Padding(3);
            tabThanhToan.Size = new Size(1114, 714);
            tabThanhToan.TabIndex = 1;
            tabThanhToan.Text = "tabPage2";
            tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // artanPanel4
            // 
            artanPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            artanPanel4.BackColor = Color.White;
            artanPanel4.BorderRadius = 20;
            artanPanel4.CausesValidation = false;
            artanPanel4.Controls.Add(txtTienThoi);
            artanPanel4.Controls.Add(label8);
            artanPanel4.Controls.Add(txtTongTien);
            artanPanel4.Controls.Add(label7);
            artanPanel4.Controls.Add(txtTienNhan);
            artanPanel4.Controls.Add(label6);
            artanPanel4.Controls.Add(txtTienGiam);
            artanPanel4.Controls.Add(label5);
            artanPanel4.Controls.Add(txtTichDiem);
            artanPanel4.Controls.Add(label4);
            artanPanel4.Controls.Add(txtMaKH);
            artanPanel4.Controls.Add(label3);
            artanPanel4.Controls.Add(txtMaNV);
            artanPanel4.Controls.Add(label2);
            artanPanel4.Controls.Add(dtpNgayLap);
            artanPanel4.Controls.Add(label1);
            artanPanel4.Controls.Add(btnHuy);
            artanPanel4.Controls.Add(btnGioHang);
            artanPanel4.Controls.Add(vbButton3);
            artanPanel4.Controls.Add(vbButton1);
            artanPanel4.Controls.Add(vbButton2);
            artanPanel4.ForeColor = Color.Black;
            artanPanel4.GradientAngle = 30F;
            artanPanel4.GradientBottomColor = Color.FromArgb(238, 168, 73);
            artanPanel4.GradientTopColor = Color.FromArgb(244, 107, 69);
            artanPanel4.Location = new Point(693, 0);
            artanPanel4.Name = "artanPanel4";
            artanPanel4.Size = new Size(421, 708);
            artanPanel4.TabIndex = 41;
            // 
            // txtTichDiem
            // 
            txtTichDiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTichDiem.BackColor = SystemColors.Window;
            txtTichDiem.BorderColor = Color.FromArgb(244, 107, 69);
            txtTichDiem.BorderFocusColor = Color.HotPink;
            txtTichDiem.BorderRadius = 0;
            txtTichDiem.BorderSize = 2;
            txtTichDiem.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTichDiem.ForeColor = Color.FromArgb(64, 64, 64);
            txtTichDiem.Location = new Point(183, 271);
            txtTichDiem.Margin = new Padding(4);
            txtTichDiem.Multiline = false;
            txtTichDiem.Name = "txtTichDiem";
            txtTichDiem.Padding = new Padding(10, 7, 10, 7);
            txtTichDiem.PasswordChar = false;
            txtTichDiem.PlaceholderColor = Color.DarkGray;
            txtTichDiem.PlaceholderText = "";
            txtTichDiem.Size = new Size(228, 31);
            txtTichDiem.TabIndex = 57;
            txtTichDiem.Texts = "";
            txtTichDiem.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 271);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 56;
            label4.Text = "Tích điểm:";
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaKH.BackColor = SystemColors.Window;
            txtMaKH.BorderColor = Color.FromArgb(244, 107, 69);
            txtMaKH.BorderFocusColor = Color.HotPink;
            txtMaKH.BorderRadius = 0;
            txtMaKH.BorderSize = 2;
            txtMaKH.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.ForeColor = Color.FromArgb(64, 64, 64);
            txtMaKH.Location = new Point(183, 197);
            txtMaKH.Margin = new Padding(4);
            txtMaKH.Multiline = false;
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Padding = new Padding(10, 7, 10, 7);
            txtMaKH.PasswordChar = false;
            txtMaKH.PlaceholderColor = Color.DarkGray;
            txtMaKH.PlaceholderText = "";
            txtMaKH.Size = new Size(229, 31);
            txtMaKH.TabIndex = 55;
            txtMaKH.Texts = "";
            txtMaKH.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 197);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 54;
            label3.Text = "Mã khách hàng:";
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaNV.BackColor = SystemColors.Window;
            txtMaNV.BorderColor = Color.FromArgb(244, 107, 69);
            txtMaNV.BorderFocusColor = Color.HotPink;
            txtMaNV.BorderRadius = 0;
            txtMaNV.BorderSize = 2;
            txtMaNV.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.ForeColor = Color.FromArgb(64, 64, 64);
            txtMaNV.Location = new Point(183, 114);
            txtMaNV.Margin = new Padding(4);
            txtMaNV.Multiline = false;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Padding = new Padding(10, 7, 10, 7);
            txtMaNV.PasswordChar = false;
            txtMaNV.PlaceholderColor = Color.DarkGray;
            txtMaNV.PlaceholderText = "";
            txtMaNV.Size = new Size(228, 31);
            txtMaNV.TabIndex = 53;
            txtMaNV.Texts = "";
            txtMaNV.UnderlinedStyle = false;
            txtMaNV._TextChanged += rjTextBox2__TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 114);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 52;
            label2.Text = "Mã nhân viên:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayLap.BorderColor = Color.PaleVioletRed;
            dtpNgayLap.BorderSize = 0;
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(183, 30);
            dtpNgayLap.MinimumSize = new Size(4, 40);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(228, 40);
            dtpNgayLap.SkinColor = Color.FromArgb(238, 168, 73);
            dtpNgayLap.TabIndex = 51;
            dtpNgayLap.TextColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 50;
            label1.Text = "Ngày lập:";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHuy.BackColor = Color.Gray;
            btnHuy.BackgroundColor = Color.Gray;
            btnHuy.BorderColor = Color.PaleVioletRed;
            btnHuy.BorderRadius = 15;
            btnHuy.BorderSize = 0;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(3, 649);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(113, 56);
            btnHuy.TabIndex = 49;
            btnHuy.Text = "Hủy";
            btnHuy.TextColor = Color.White;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnGioHang
            // 
            btnGioHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGioHang.BackColor = Color.CornflowerBlue;
            btnGioHang.BackgroundColor = Color.CornflowerBlue;
            btnGioHang.BorderColor = Color.PaleVioletRed;
            btnGioHang.BorderRadius = 15;
            btnGioHang.BorderSize = 0;
            btnGioHang.FlatAppearance.BorderSize = 0;
            btnGioHang.FlatStyle = FlatStyle.Flat;
            btnGioHang.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGioHang.ForeColor = Color.White;
            btnGioHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnGioHang.Location = new Point(122, 649);
            btnGioHang.Name = "btnGioHang";
            btnGioHang.Size = new Size(145, 56);
            btnGioHang.TabIndex = 48;
            btnGioHang.Text = "Giỏ hàng";
            btnGioHang.TextColor = Color.White;
            btnGioHang.UseVisualStyleBackColor = false;
            btnGioHang.Click += btnGioHang_Click;
            // 
            // vbButton3
            // 
            vbButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vbButton3.BackColor = Color.DarkSeaGreen;
            vbButton3.BackgroundColor = Color.DarkSeaGreen;
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 15;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton3.ForeColor = Color.White;
            vbButton3.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton3.Location = new Point(273, 649);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(145, 56);
            vbButton3.TabIndex = 47;
            vbButton3.Text = "Thanh toán";
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            vbButton3.Click += vbButton3_Click;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.Gray;
            vbButton1.BackgroundColor = Color.Gray;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 15;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(1036, 102);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(145, 56);
            vbButton1.TabIndex = 46;
            vbButton1.Text = "Quay lại hóa đơn";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton2.BackColor = Color.CornflowerBlue;
            vbButton2.BackgroundColor = Color.CornflowerBlue;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 15;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton2.Location = new Point(1036, 25);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(145, 56);
            vbButton2.TabIndex = 45;
            vbButton2.Text = "Thanh toán";
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // artanPanel3
            // 
            artanPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 20;
            artanPanel3.Controls.Add(dataGridView2);
            artanPanel3.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel3.GradientAngle = 30F;
            artanPanel3.GradientBottomColor = Color.FromArgb(238, 168, 73);
            artanPanel3.GradientTopColor = Color.FromArgb(238, 168, 73);
            artanPanel3.Location = new Point(0, 0);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Padding = new Padding(4, 0, 4, 15);
            artanPanel3.Size = new Size(687, 708);
            artanPanel3.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(238, 168, 73);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(238, 168, 73);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column9, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn8 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(4, 0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(679, 693);
            dataGridView2.TabIndex = 0;
            // 
            // Column9
            // 
            Column9.HeaderText = "Mã IMEI";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Giá bán";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Hãng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.HeaderText = "Khuyến mãi";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // txtTienGiam
            // 
            txtTienGiam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTienGiam.BackColor = SystemColors.Window;
            txtTienGiam.BorderColor = Color.FromArgb(244, 107, 69);
            txtTienGiam.BorderFocusColor = Color.HotPink;
            txtTienGiam.BorderRadius = 0;
            txtTienGiam.BorderSize = 2;
            txtTienGiam.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienGiam.ForeColor = Color.FromArgb(64, 64, 64);
            txtTienGiam.Location = new Point(184, 431);
            txtTienGiam.Margin = new Padding(4);
            txtTienGiam.Multiline = false;
            txtTienGiam.Name = "txtTienGiam";
            txtTienGiam.Padding = new Padding(10, 7, 10, 7);
            txtTienGiam.PasswordChar = false;
            txtTienGiam.PlaceholderColor = Color.DarkGray;
            txtTienGiam.PlaceholderText = "";
            txtTienGiam.Size = new Size(228, 31);
            txtTienGiam.TabIndex = 59;
            txtTienGiam.Texts = "";
            txtTienGiam.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 437);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 58;
            label5.Text = "Tiền giảm do điểm:";
            label5.Click += label5_Click;
            // 
            // txtTienNhan
            // 
            txtTienNhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTienNhan.BackColor = SystemColors.Window;
            txtTienNhan.BorderColor = Color.FromArgb(244, 107, 69);
            txtTienNhan.BorderFocusColor = Color.HotPink;
            txtTienNhan.BorderRadius = 0;
            txtTienNhan.BorderSize = 2;
            txtTienNhan.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienNhan.ForeColor = Color.FromArgb(64, 64, 64);
            txtTienNhan.Location = new Point(184, 514);
            txtTienNhan.Margin = new Padding(4);
            txtTienNhan.Multiline = false;
            txtTienNhan.Name = "txtTienNhan";
            txtTienNhan.Padding = new Padding(10, 7, 10, 7);
            txtTienNhan.PasswordChar = false;
            txtTienNhan.PlaceholderColor = Color.DarkGray;
            txtTienNhan.PlaceholderText = "";
            txtTienNhan.Size = new Size(228, 31);
            txtTienNhan.TabIndex = 61;
            txtTienNhan.Texts = "";
            txtTienNhan.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 520);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 60;
            label6.Text = "Tiền nhận:";
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTongTien.BackColor = SystemColors.Window;
            txtTongTien.BorderColor = Color.FromArgb(244, 107, 69);
            txtTongTien.BorderFocusColor = Color.HotPink;
            txtTongTien.BorderRadius = 0;
            txtTongTien.BorderSize = 2;
            txtTongTien.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.ForeColor = Color.FromArgb(64, 64, 64);
            txtTongTien.Location = new Point(184, 349);
            txtTongTien.Margin = new Padding(4);
            txtTongTien.Multiline = false;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Padding = new Padding(10, 7, 10, 7);
            txtTongTien.PasswordChar = false;
            txtTongTien.PlaceholderColor = Color.DarkGray;
            txtTongTien.PlaceholderText = "";
            txtTongTien.Size = new Size(228, 31);
            txtTongTien.TabIndex = 63;
            txtTongTien.Texts = "";
            txtTongTien.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 349);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 62;
            label7.Text = "Tổng tiền:";
            label7.Click += label7_Click;
            // 
            // txtTienThoi
            // 
            txtTienThoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTienThoi.BackColor = SystemColors.Window;
            txtTienThoi.BorderColor = Color.FromArgb(244, 107, 69);
            txtTienThoi.BorderFocusColor = Color.HotPink;
            txtTienThoi.BorderRadius = 0;
            txtTienThoi.BorderSize = 2;
            txtTienThoi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienThoi.ForeColor = Color.FromArgb(64, 64, 64);
            txtTienThoi.Location = new Point(184, 578);
            txtTienThoi.Margin = new Padding(4);
            txtTienThoi.Multiline = false;
            txtTienThoi.Name = "txtTienThoi";
            txtTienThoi.Padding = new Padding(10, 7, 10, 7);
            txtTienThoi.PasswordChar = false;
            txtTienThoi.PlaceholderColor = Color.DarkGray;
            txtTienThoi.PlaceholderText = "";
            txtTienThoi.Size = new Size(228, 31);
            txtTienThoi.TabIndex = 65;
            txtTienThoi.Texts = "";
            txtTienThoi.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(4, 584);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 64;
            label8.Text = "Tiền thối:";
            // 
            // BanHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 713);
            Controls.Add(tabControl1);
            Name = "BanHangForm";
            Text = "BanHang";
            tabControl1.ResumeLayout(false);
            tabGioHang.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbGia).EndInit();
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabThanhToan.ResumeLayout(false);
            artanPanel4.ResumeLayout(false);
            artanPanel4.PerformLayout();
            artanPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabGioHang;
        private TabPage tabThanhToan;
        private ArtanPanel artanPanel2;
        private DataGridView dataGridView1;
        private ArtanPanel artanPanel1;
        private ComboBox cbxKichThuoc;
        private TrackBar tbGia;
        private ComboBox cbxRAM;
        private ComboBox cbxHang;
        private ComboBox cbxGPU;
        private ComboBox cbxCPU;
        private RJTextBox rjTextBox1;
        private VBButton btnThemThongTin;
        private VBButton btnQuayLai;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private Label lblSoSanPham;
        private Label lblSoTien;
        private ArtanPanel artanPanel4;
        private VBButton vbButton1;
        private VBButton vbButton2;
        private ArtanPanel artanPanel3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label1;
        private VBButton btnHuy;
        private VBButton btnGioHang;
        private VBButton vbButton3;
        private RJTextBox txtMaKH;
        private Label label3;
        private RJTextBox txtMaNV;
        private Label label2;
        private RJDateTimePicker.RJDatePicker dtpNgayLap;
        private RJTextBox txtTichDiem;
        private Label label4;
        private RJTextBox txtTongTien;
        private Label label7;
        private RJTextBox txtTienNhan;
        private Label label6;
        private RJTextBox txtTienGiam;
        private Label label5;
        private RJTextBox txtTienThoi;
        private Label label8;
    }
}