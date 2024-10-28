namespace CSharp_laptop.GUI
{
    partial class PhieuNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapGUI));
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            sua_but = new Button();
            them_but = new Button();
            sapXep_cbb = new ComboBox();
            dataGridView1 = new DataGridView();
            idKM_col = new DataGridViewTextBoxColumn();
            tenKM_col = new DataGridViewTextBoxColumn();
            mucGiamGiaKM_col = new DataGridViewTextBoxColumn();
            moTaKM_col = new DataGridViewTextBoxColumn();
            thoiGianBatDauKM_col = new DataGridViewTextBoxColumn();
            thoiGianKetThucKM_col = new DataGridViewTextBoxColumn();
            thoiGianTaoKM_col = new DataGridViewTextBoxColumn();
            tim_but = new Button();
            timKiem_tb = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(373, 30);
            label1.Name = "label1";
            label1.Size = new Size(372, 54);
            label1.TabIndex = 1;
            label1.Text = "Quản lý phiếu nhập";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.CausesValidation = false;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(61, 20);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 656);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(sua_but);
            tabPage1.Controls.Add(them_but);
            tabPage1.Controls.Add(sapXep_cbb);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(tim_but);
            tabPage1.Controls.Add(timKiem_tb);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1110, 628);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // sua_but
            // 
            sua_but.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sua_but.BackColor = Color.FromArgb(60, 72, 144);
            sua_but.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            sua_but.ForeColor = Color.White;
            sua_but.Image = (Image)resources.GetObject("sua_but.Image");
            sua_but.ImageAlign = ContentAlignment.MiddleLeft;
            sua_but.Location = new Point(910, 246);
            sua_but.Name = "sua_but";
            sua_but.Padding = new Padding(10, 0, 0, 0);
            sua_but.Size = new Size(170, 60);
            sua_but.TabIndex = 10;
            sua_but.Text = "Sửa";
            sua_but.TextImageRelation = TextImageRelation.ImageBeforeText;
            sua_but.UseVisualStyleBackColor = false;
            sua_but.Click += sua_but_Click;
            // 
            // them_but
            // 
            them_but.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            them_but.BackColor = Color.FromArgb(60, 72, 144);
            them_but.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            them_but.ForeColor = Color.White;
            them_but.Image = (Image)resources.GetObject("them_but.Image");
            them_but.ImageAlign = ContentAlignment.MiddleLeft;
            them_but.Location = new Point(910, 180);
            them_but.Name = "them_but";
            them_but.Padding = new Padding(10, 0, 0, 0);
            them_but.Size = new Size(170, 60);
            them_but.TabIndex = 8;
            them_but.Text = "Thêm";
            them_but.TextImageRelation = TextImageRelation.ImageBeforeText;
            them_but.UseVisualStyleBackColor = false;
            them_but.Click += them_but_Click;
            // 
            // sapXep_cbb
            // 
            sapXep_cbb.AutoCompleteCustomSource.AddRange(new string[] { "A - Z", "Z - A", "Mới nhất", "Cũ nhất" });
            sapXep_cbb.Font = new Font("Segoe UI", 12F);
            sapXep_cbb.FormattingEnabled = true;
            sapXep_cbb.Location = new Point(30, 90);
            sapXep_cbb.Name = "sapXep_cbb";
            sapXep_cbb.Size = new Size(121, 29);
            sapXep_cbb.TabIndex = 5;
            sapXep_cbb.Text = "Mới nhất";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idKM_col, tenKM_col, mucGiamGiaKM_col, moTaKM_col, thoiGianBatDauKM_col, thoiGianKetThucKM_col, thoiGianTaoKM_col });
            dataGridView1.Location = new Point(30, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 455);
            dataGridView1.TabIndex = 4;
            // 
            // idKM_col
            // 
            idKM_col.HeaderText = "ID";
            idKM_col.Name = "idKM_col";
            // 
            // tenKM_col
            // 
            tenKM_col.HeaderText = "Tên khuyến mãi";
            tenKM_col.Name = "tenKM_col";
            // 
            // mucGiamGiaKM_col
            // 
            mucGiamGiaKM_col.HeaderText = "Mức giảm giá";
            mucGiamGiaKM_col.Name = "mucGiamGiaKM_col";
            // 
            // moTaKM_col
            // 
            moTaKM_col.HeaderText = "Mô tả";
            moTaKM_col.Name = "moTaKM_col";
            // 
            // thoiGianBatDauKM_col
            // 
            thoiGianBatDauKM_col.HeaderText = "Thời gian bắt đầu";
            thoiGianBatDauKM_col.Name = "thoiGianBatDauKM_col";
            // 
            // thoiGianKetThucKM_col
            // 
            thoiGianKetThucKM_col.HeaderText = "Thời gian kết thúc";
            thoiGianKetThucKM_col.Name = "thoiGianKetThucKM_col";
            // 
            // thoiGianTaoKM_col
            // 
            thoiGianTaoKM_col.HeaderText = "Thời gian tạo";
            thoiGianTaoKM_col.Name = "thoiGianTaoKM_col";
            // 
            // tim_but
            // 
            tim_but.Anchor = AnchorStyles.Top;
            tim_but.BackColor = Color.Transparent;
            tim_but.Font = new Font("Segoe UI", 15F);
            tim_but.ForeColor = SystemColors.ControlText;
            tim_but.Image = (Image)resources.GetObject("tim_but.Image");
            tim_but.Location = new Point(861, 40);
            tim_but.Name = "tim_but";
            tim_but.Size = new Size(34, 34);
            tim_but.TabIndex = 1;
            tim_but.UseVisualStyleBackColor = false;
            tim_but.Click += tim_but_Click;
            // 
            // timKiem_tb
            // 
            timKiem_tb.Anchor = AnchorStyles.Top;
            timKiem_tb.Font = new Font("Segoe UI", 15F);
            timKiem_tb.Location = new Point(255, 40);
            timKiem_tb.Name = "timKiem_tb";
            timKiem_tb.Size = new Size(600, 34);
            timKiem_tb.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1110, 628);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1110, 628);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // PhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 755);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PhieuNhapGUI";
            Text = "PhieuNhapGUI";
            Load += PhieuNhapGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox timKiem_tb;
        private Button tim_but;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idKM_col;
        private DataGridViewTextBoxColumn tenKM_col;
        private DataGridViewTextBoxColumn mucGiamGiaKM_col;
        private DataGridViewTextBoxColumn moTaKM_col;
        private DataGridViewTextBoxColumn thoiGianBatDauKM_col;
        private DataGridViewTextBoxColumn thoiGianKetThucKM_col;
        private DataGridViewTextBoxColumn thoiGianTaoKM_col;
        private ComboBox sapXep_cbb;
        private Button them_but;
        private Button sua_but;
        private TabPage tabPage3;
    }
}