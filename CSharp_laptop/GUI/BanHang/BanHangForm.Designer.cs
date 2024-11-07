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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            artanPanel1 = new ArtanPanel();
            rjTextBox2 = new RJTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            vbButton1 = new VBButton();
            lblSoTien = new Label();
            lblSoSanPham = new Label();
            btnQuayLai = new VBButton();
            btnThemThongTin = new VBButton();
            cbxKichThuoc = new ComboBox();
            cbxRAM = new ComboBox();
            cbxCPU = new ComboBox();
            cbxGPU = new ComboBox();
            cbxHang = new ComboBox();
            txtTenSP = new RJTextBox();
            dataGridView2 = new DataGridView();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
            artanPanel1.Controls.Add(rjTextBox2);
            artanPanel1.Controls.Add(label6);
            artanPanel1.Controls.Add(label5);
            artanPanel1.Controls.Add(label4);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(label1);
            artanPanel1.Controls.Add(vbButton1);
            artanPanel1.Controls.Add(lblSoTien);
            artanPanel1.Controls.Add(lblSoSanPham);
            artanPanel1.Controls.Add(btnQuayLai);
            artanPanel1.Controls.Add(btnThemThongTin);
            artanPanel1.Controls.Add(cbxKichThuoc);
            artanPanel1.Controls.Add(cbxRAM);
            artanPanel1.Controls.Add(cbxCPU);
            artanPanel1.Controls.Add(cbxGPU);
            artanPanel1.Controls.Add(cbxHang);
            artanPanel1.Controls.Add(txtTenSP);
            artanPanel1.Dock = DockStyle.Top;
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(249, 118, 176);
            artanPanel1.GradientTopColor = Color.PaleTurquoise;
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Margin = new Padding(3, 4, 3, 4);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1277, 298);
            artanPanel1.TabIndex = 41;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.FromArgb(249, 118, 176);
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(141, 211);
            rjTextBox2.Margin = new Padding(5, 5, 5, 5);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(11, 9, 11, 9);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(250, 44);
            rjTextBox2.TabIndex = 56;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 224);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 55;
            label6.Text = "Giới hạn giá:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(419, 224);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 54;
            label5.Text = "Kích thước:";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(477, 135);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 53;
            label4.Text = "RAM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(477, 71);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 52;
            label3.Text = "CPU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(73, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 51;
            label2.Text = "GPU:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(73, 71);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 50;
            label1.Text = "Hãng:";
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.FromArgb(249, 118, 176);
            vbButton1.BackgroundColor = Color.FromArgb(249, 118, 176);
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 26;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = (Image)resources.GetObject("vbButton1.Image");
            vbButton1.Location = new Point(885, 117);
            vbButton1.Margin = new Padding(3, 4, 3, 4);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(67, 81);
            vbButton1.TabIndex = 49;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // lblSoTien
            // 
            lblSoTien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSoTien.AutoSize = true;
            lblSoTien.BackColor = Color.Transparent;
            lblSoTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoTien.ForeColor = Color.White;
            lblSoTien.Location = new Point(1001, 101);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(178, 32);
            lblSoTien.TabIndex = 48;
            lblSoTien.Text = "Tổng số tiền:  ";
            lblSoTien.Click += lblSoTien_Click;
            // 
            // lblSoSanPham
            // 
            lblSoSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSoSanPham.AutoSize = true;
            lblSoSanPham.BackColor = Color.Transparent;
            lblSoSanPham.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoSanPham.ForeColor = Color.White;
            lblSoSanPham.Location = new Point(1001, 17);
            lblSoSanPham.Name = "lblSoSanPham";
            lblSoSanPham.Size = new Size(237, 32);
            lblSoSanPham.TabIndex = 47;
            lblSoSanPham.Text = "Tổng số sản phẩm: ";
            lblSoSanPham.Click += lblSoSanPham_Click;
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
            btnQuayLai.Location = new Point(1980, 136);
            btnQuayLai.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(166, 75);
            btnQuayLai.TabIndex = 46;
            btnQuayLai.Text = "Hủy";
            btnQuayLai.TextColor = Color.White;
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Visible = false;
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
            btnThemThongTin.Location = new Point(1980, 33);
            btnThemThongTin.Margin = new Padding(3, 4, 3, 4);
            btnThemThongTin.Name = "btnThemThongTin";
            btnThemThongTin.Size = new Size(166, 75);
            btnThemThongTin.TabIndex = 45;
            btnThemThongTin.Text = "Thanh toán";
            btnThemThongTin.TextColor = Color.White;
            btnThemThongTin.UseVisualStyleBackColor = false;
            // 
            // cbxKichThuoc
            // 
            cbxKichThuoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKichThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxKichThuoc.FormattingEnabled = true;
            cbxKichThuoc.Location = new Point(546, 213);
            cbxKichThuoc.Margin = new Padding(3, 4, 3, 4);
            cbxKichThuoc.Name = "cbxKichThuoc";
            cbxKichThuoc.Size = new Size(318, 36);
            cbxKichThuoc.TabIndex = 44;
            cbxKichThuoc.SelectedIndexChanged += cbxKichThuoc_SelectedIndexChanged;
            // 
            // cbxRAM
            // 
            cbxRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRAM.FormattingEnabled = true;
            cbxRAM.Location = new Point(546, 131);
            cbxRAM.Margin = new Padding(3, 4, 3, 4);
            cbxRAM.Name = "cbxRAM";
            cbxRAM.Size = new Size(318, 36);
            cbxRAM.TabIndex = 42;
            // 
            // cbxCPU
            // 
            cbxCPU.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCPU.FormattingEnabled = true;
            cbxCPU.Location = new Point(546, 67);
            cbxCPU.Margin = new Padding(3, 4, 3, 4);
            cbxCPU.Name = "cbxCPU";
            cbxCPU.Size = new Size(318, 36);
            cbxCPU.TabIndex = 41;
            // 
            // cbxGPU
            // 
            cbxGPU.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxGPU.FormattingEnabled = true;
            cbxGPU.Location = new Point(143, 131);
            cbxGPU.Margin = new Padding(3, 4, 3, 4);
            cbxGPU.Name = "cbxGPU";
            cbxGPU.Size = new Size(247, 36);
            cbxGPU.TabIndex = 40;
            // 
            // cbxHang
            // 
            cbxHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxHang.FormattingEnabled = true;
            cbxHang.Location = new Point(143, 67);
            cbxHang.Margin = new Padding(3, 4, 3, 4);
            cbxHang.Name = "cbxHang";
            cbxHang.Size = new Size(247, 36);
            cbxHang.TabIndex = 39;
            // 
            // txtTenSP
            // 
            txtTenSP.BackColor = SystemColors.Window;
            txtTenSP.BorderColor = Color.FromArgb(249, 118, 176);
            txtTenSP.BorderFocusColor = Color.HotPink;
            txtTenSP.BorderRadius = 5;
            txtTenSP.BorderSize = 2;
            txtTenSP.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenSP.ForeColor = Color.Gray;
            txtTenSP.Location = new Point(9, 9);
            txtTenSP.Margin = new Padding(5, 5, 5, 5);
            txtTenSP.Multiline = false;
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Padding = new Padding(11, 9, 11, 9);
            txtTenSP.PasswordChar = false;
            txtTenSP.PlaceholderColor = Color.DarkGray;
            txtTenSP.PlaceholderText = "";
            txtTenSP.Size = new Size(856, 39);
            txtTenSP.TabIndex = 38;
            txtTenSP.Texts = "Nhập tên sản phẩm";
            txtTenSP.UnderlinedStyle = false;
            txtTenSP._TextChanged += rjTextBox1__TextChanged;
            txtTenSP.Enter += TextBox_Enter;
            txtTenSP.Leave += TextBox_Leave;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 118, 176);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 118, 176);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(0, 298);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1277, 653);
            dataGridView2.TabIndex = 50;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BanHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 951);
            Controls.Add(dataGridView2);
            Controls.Add(artanPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BanHangForm";
            Text = "BanHang";
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ArtanPanel artanPanel1;
        private Label lblSoTien;
        private Label lblSoSanPham;
        private VBButton btnQuayLai;
        private VBButton btnThemThongTin;
        private ComboBox cbxKichThuoc;
        private ComboBox cbxRAM;
        private ComboBox cbxCPU;
        private ComboBox cbxGPU;
        private ComboBox cbxHang;
        private RJTextBox txtTenSP;
        private VBButton vbButton1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private RJTextBox rjTextBox2;
    }
}