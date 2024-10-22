namespace CSharp_laptop.GUI
{
    partial class KhuyenMaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMaiGUI));
            dataGridView1 = new DataGridView();
            idKM_col = new DataGridViewTextBoxColumn();
            tenKM_col = new DataGridViewTextBoxColumn();
            mucGiamGiaKM_col = new DataGridViewTextBoxColumn();
            moTaKM_col = new DataGridViewTextBoxColumn();
            thoiGianBatDauKM_col = new DataGridViewTextBoxColumn();
            thoiGianKetThucKM_col = new DataGridViewTextBoxColumn();
            thoiGianTaoKM_col = new DataGridViewTextBoxColumn();
            them_but = new Button();
            xoa_but = new Button();
            sua_but = new Button();
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            textBox8 = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.TabIndex = 3;
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
            them_but.TabIndex = 5;
            them_but.Text = "Thêm";
            them_but.TextImageRelation = TextImageRelation.ImageBeforeText;
            them_but.UseVisualStyleBackColor = false;
            them_but.Click += button1_Click;
            // 
            // xoa_but
            // 
            xoa_but.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            xoa_but.BackColor = Color.FromArgb(60, 72, 144);
            xoa_but.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            xoa_but.ForeColor = Color.White;
            xoa_but.Image = (Image)resources.GetObject("xoa_but.Image");
            xoa_but.ImageAlign = ContentAlignment.MiddleLeft;
            xoa_but.Location = new Point(910, 312);
            xoa_but.Name = "xoa_but";
            xoa_but.Padding = new Padding(10, 0, 0, 0);
            xoa_but.Size = new Size(170, 60);
            xoa_but.TabIndex = 7;
            xoa_but.Text = "Xóa";
            xoa_but.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoa_but.UseVisualStyleBackColor = false;
            xoa_but.Click += xoa_but_Click;
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
            sua_but.TabIndex = 9;
            sua_but.Text = "Sửa";
            sua_but.TextImageRelation = TextImageRelation.ImageBeforeText;
            sua_but.UseVisualStyleBackColor = false;
            sua_but.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 100);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(372, 30);
            label1.Name = "label1";
            label1.Size = new Size(374, 54);
            label1.TabIndex = 13;
            label1.Text = "Quản lý khuyến mãi";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A - Z", "Z - A", "Mới nhất", "Cũ nhất" });
            comboBox1.Location = new Point(30, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Mới nhất";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 656);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(sua_but);
            tabPage1.Controls.Add(xoa_but);
            tabPage1.Controls.Add(them_but);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1110, 628);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = Color.FromArgb(67, 66, 111);
            button4.Font = new Font("Segoe UI", 15F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(861, 40);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(100, 34);
            button4.TabIndex = 11;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(255, 40);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 34);
            textBox1.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1110, 628);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(305, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 34);
            panel3.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Font = new Font("Segoe UI", 15F);
            textBox8.Location = new Point(50, 0);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(450, 34);
            textBox8.TabIndex = 8;
            textBox8.Text = "123456789";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(0, 3);
            label8.Name = "label8";
            label8.Size = new Size(35, 28);
            label8.TabIndex = 8;
            label8.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(305, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 559);
            panel2.TabIndex = 6;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Segoe UI", 15F);
            button6.Location = new Point(267, 500);
            button6.Name = "button6";
            button6.Size = new Size(120, 40);
            button6.TabIndex = 13;
            button6.Text = "Hủy";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(122, 500);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 12;
            button5.Text = "Đồng ý";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 15F);
            textBox7.Location = new Point(0, 450);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(500, 34);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Segoe UI", 15F);
            textBox6.Location = new Point(0, 370);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(500, 34);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 15F);
            textBox5.Location = new Point(0, 290);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(500, 34);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(0, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(500, 34);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(0, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(500, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(0, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 34);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên khuyến mãi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(0, 410);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 5;
            label7.Text = "Ngày tạo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(0, 90);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 1;
            label3.Text = "Mức giảm giá:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(0, 330);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 4;
            label6.Text = "Thời gian kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(0, 170);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 2;
            label4.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(0, 250);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 3;
            label5.Text = "Thời gian bắt đầu:";
            // 
            // KhuyenMaiGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 755);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KhuyenMaiGUI";
            Text = "KhuyenMaiGUI";
            Load += KhuyenMaiGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button them_but;
        private Button xoa_but;
        private Button sua_but;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn idKM_col;
        private DataGridViewTextBoxColumn tenKM_col;
        private DataGridViewTextBoxColumn mucGiamGiaKM_col;
        private DataGridViewTextBoxColumn moTaKM_col;
        private DataGridViewTextBoxColumn thoiGianBatDauKM_col;
        private DataGridViewTextBoxColumn thoiGianKetThucKM_col;
        private DataGridViewTextBoxColumn thoiGianTaoKM_col;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button4;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button button6;
        private Button button5;
        private TextBox textBox8;
    }
}