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
            tbGia = new TrackBar();
            cbxRAM = new ComboBox();
            cbxHang = new ComboBox();
            cbxGPU = new ComboBox();
            cbxCPU = new ComboBox();
            rjTextBox1 = new RJTextBox();
            dataGridView2 = new DataGridView();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
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
            artanPanel1.Controls.Add(tbGia);
            artanPanel1.Controls.Add(cbxRAM);
            artanPanel1.Controls.Add(cbxHang);
            artanPanel1.Controls.Add(cbxGPU);
            artanPanel1.Controls.Add(cbxCPU);
            artanPanel1.Controls.Add(rjTextBox1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(249, 118, 176);
            artanPanel1.GradientTopColor = Color.PaleTurquoise;
            artanPanel1.Location = new Point(1, 1);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1114, 224);
            artanPanel1.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(72, 168);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 55;
            label6.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(367, 168);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
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
            label4.Location = new Point(417, 101);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 53;
            label4.Text = "RAM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(417, 53);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 52;
            label3.Text = "CPU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(64, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 51;
            label2.Text = "GPU:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 53);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
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
            vbButton1.Location = new Point(774, 88);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(59, 61);
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
            lblSoTien.Location = new Point(872, 76);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(138, 25);
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
            lblSoSanPham.Location = new Point(872, 13);
            lblSoSanPham.Name = "lblSoSanPham";
            lblSoSanPham.Size = new Size(184, 25);
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
            btnQuayLai.Location = new Point(1729, 102);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(145, 56);
            btnQuayLai.TabIndex = 46;
            btnQuayLai.Text = "Hủy";
            btnQuayLai.TextColor = Color.White;
            btnQuayLai.UseVisualStyleBackColor = false;
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
            btnThemThongTin.Location = new Point(1729, 25);
            btnThemThongTin.Name = "btnThemThongTin";
            btnThemThongTin.Size = new Size(145, 56);
            btnThemThongTin.TabIndex = 45;
            btnThemThongTin.Text = "Thanh toán";
            btnThemThongTin.TextColor = Color.White;
            btnThemThongTin.UseVisualStyleBackColor = false;
            // 
            // cbxKichThuoc
            // 
            cbxKichThuoc.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxKichThuoc.FormattingEnabled = true;
            cbxKichThuoc.Location = new Point(478, 151);
            cbxKichThuoc.Name = "cbxKichThuoc";
            cbxKichThuoc.Size = new Size(279, 46);
            cbxKichThuoc.TabIndex = 44;
            cbxKichThuoc.SelectedIndexChanged += cbxKichThuoc_SelectedIndexChanged;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(125, 151);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(217, 45);
            tbGia.TabIndex = 43;
            // 
            // cbxRAM
            // 
            cbxRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRAM.FormattingEnabled = true;
            cbxRAM.Location = new Point(478, 98);
            cbxRAM.Name = "cbxRAM";
            cbxRAM.Size = new Size(279, 29);
            cbxRAM.TabIndex = 42;
            // 
            // cbxHang
            // 
            cbxHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxHang.FormattingEnabled = true;
            cbxHang.Location = new Point(478, 50);
            cbxHang.Name = "cbxHang";
            cbxHang.Size = new Size(279, 29);
            cbxHang.TabIndex = 41;
            // 
            // cbxGPU
            // 
            cbxGPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxGPU.FormattingEnabled = true;
            cbxGPU.Location = new Point(125, 98);
            cbxGPU.Name = "cbxGPU";
            cbxGPU.Size = new Size(217, 29);
            cbxGPU.TabIndex = 40;
            // 
            // cbxCPU
            // 
            cbxCPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCPU.FormattingEnabled = true;
            cbxCPU.Location = new Point(125, 50);
            cbxCPU.Name = "cbxCPU";
            cbxCPU.Size = new Size(217, 29);
            cbxCPU.TabIndex = 39;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(249, 118, 176);
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
            rjTextBox1.Size = new Size(749, 31);
            rjTextBox1.TabIndex = 38;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(1, 231);
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
            dataGridView2.Size = new Size(1114, 482);
            dataGridView2.TabIndex = 50;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BanHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 713);
            Controls.Add(dataGridView2);
            Controls.Add(artanPanel1);
            Name = "BanHangForm";
            Text = "BanHang";
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbGia).EndInit();
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
        private TrackBar tbGia;
        private ComboBox cbxRAM;
        private ComboBox cbxHang;
        private ComboBox cbxGPU;
        private ComboBox cbxCPU;
        private RJTextBox rjTextBox1;
        private VBButton vbButton1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}