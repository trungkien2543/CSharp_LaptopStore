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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            vbButton2 = new VBButton();
            tk_panel = new Panel();
            rjTextBox1 = new RJTextBox();
            vbButton1 = new VBButton();
            artanPanel3 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            km_pan = new ArtanPanel();
            label15 = new Label();
            panel2 = new Panel();
            rjDatePicker6 = new RJDateTimePicker.RJDatePicker();
            artanPanel7 = new ArtanPanel();
            rjDatePicker4 = new RJDateTimePicker.RJDatePicker();
            artanPanel8 = new ArtanPanel();
            rjDatePicker5 = new RJDateTimePicker.RJDatePicker();
            artanPanel9 = new ArtanPanel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            vbButton3 = new VBButton();
            huy_but = new VBButton();
            label14 = new Label();
            rjTextBox5 = new RJTextBox();
            rjTextBox6 = new RJTextBox();
            rjTextBox7 = new RJTextBox();
            artanPanel1 = new ArtanPanel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tk_panel.SuspendLayout();
            artanPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            km_pan.SuspendLayout();
            panel2.SuspendLayout();
            artanPanel7.SuspendLayout();
            artanPanel8.SuspendLayout();
            artanPanel9.SuspendLayout();
            artanPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 120);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 635);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(vbButton2);
            tabPage1.Controls.Add(tk_panel);
            tabPage1.Controls.Add(artanPanel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 3, 10, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1110, 607);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton2.BackColor = Color.FromArgb(113, 168, 223);
            vbButton2.BackgroundColor = Color.FromArgb(113, 168, 223);
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 15;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = (Image)resources.GetObject("vbButton2.Image");
            vbButton2.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton2.Location = new Point(962, 89);
            vbButton2.Name = "vbButton2";
            vbButton2.Padding = new Padding(0, 0, 15, 0);
            vbButton2.Size = new Size(100, 40);
            vbButton2.TabIndex = 38;
            vbButton2.Text = "Thêm";
            vbButton2.TextAlign = ContentAlignment.MiddleRight;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // tk_panel
            // 
            tk_panel.Anchor = AnchorStyles.Top;
            tk_panel.Controls.Add(rjTextBox1);
            tk_panel.Controls.Add(vbButton1);
            tk_panel.Location = new Point(205, 55);
            tk_panel.Name = "tk_panel";
            tk_panel.Size = new Size(700, 40);
            tk_panel.TabIndex = 37;
            // 
            // rjTextBox1
            // 
            rjTextBox1.Anchor = AnchorStyles.Top;
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(113, 168, 223);
            rjTextBox1.BorderFocusColor = SystemColors.HotTrack;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(0, 0);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(640, 40);
            rjTextBox1.TabIndex = 35;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.FromArgb(113, 168, 223);
            vbButton1.BackgroundColor = Color.FromArgb(113, 168, 223);
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 15;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = (Image)resources.GetObject("vbButton1.Image");
            vbButton1.ImageAlign = ContentAlignment.MiddleRight;
            vbButton1.Location = new Point(600, 0);
            vbButton1.Name = "vbButton1";
            vbButton1.Padding = new Padding(0, 0, 15, 0);
            vbButton1.Size = new Size(100, 40);
            vbButton1.TabIndex = 36;
            vbButton1.TextAlign = ContentAlignment.TopLeft;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // artanPanel3
            // 
            artanPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 20;
            artanPanel3.Controls.Add(dataGridView1);
            artanPanel3.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel3.GradientAngle = 65F;
            artanPanel3.GradientBottomColor = Color.FromArgb(210, 220, 230);
            artanPanel3.GradientTopColor = Color.FromArgb(113, 168, 223);
            artanPanel3.Location = new Point(40, 135);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Padding = new Padding(4, 0, 4, 15);
            artanPanel3.Size = new Size(1022, 431);
            artanPanel3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 168, 223);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column6, Column9 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(4, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1014, 416);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 50F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 80F;
            Column2.HeaderText = "Tên khuyến mãi";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 80F;
            Column3.HeaderText = "Mức giảm giá";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 80F;
            Column4.HeaderText = "Mô tả";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 80F;
            Column5.HeaderText = "Thời gian bắt đàu";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.FillWeight = 80F;
            Column7.HeaderText = "Thời gian kêt thúc";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.FillWeight = 80F;
            Column8.HeaderText = "Thời gian tạo";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 40F;
            Column6.HeaderText = "Sửa";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 40F;
            Column9.HeaderText = "Xóa";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(km_pan);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1110, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // km_pan
            // 
            km_pan.Anchor = AnchorStyles.None;
            km_pan.BackColor = Color.White;
            km_pan.BorderRadius = 30;
            km_pan.Controls.Add(label15);
            km_pan.Controls.Add(panel2);
            km_pan.ForeColor = Color.Black;
            km_pan.GradientAngle = 30F;
            km_pan.GradientBottomColor = Color.FromArgb(210, 220, 230);
            km_pan.GradientTopColor = Color.FromArgb(113, 168, 223);
            km_pan.Location = new Point(255, 40);
            km_pan.Name = "km_pan";
            km_pan.Padding = new Padding(4, 40, 4, 15);
            km_pan.Size = new Size(600, 550);
            km_pan.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(50, 12);
            label15.Name = "label15";
            label15.Size = new Size(134, 25);
            label15.TabIndex = 2;
            label15.Text = "Thêm khuyến mãi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(artanPanel7);
            panel2.Controls.Add(artanPanel8);
            panel2.Controls.Add(artanPanel9);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(vbButton3);
            panel2.Controls.Add(huy_but);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(rjTextBox5);
            panel2.Controls.Add(rjTextBox6);
            panel2.Controls.Add(rjTextBox7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 495);
            panel2.TabIndex = 1;
            // 
            // rjDatePicker6
            // 
            rjDatePicker6.BorderColor = Color.FromArgb(113, 168, 223);
            rjDatePicker6.BorderSize = 0;
            rjDatePicker6.CalendarMonthBackground = SystemColors.HotTrack;
            rjDatePicker6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjDatePicker6.Location = new Point(25, 3);
            rjDatePicker6.MinimumSize = new Size(0, 40);
            rjDatePicker6.Name = "rjDatePicker6";
            rjDatePicker6.Size = new Size(200, 40);
            rjDatePicker6.SkinColor = Color.FromArgb(113, 168, 223);
            rjDatePicker6.TabIndex = 15;
            rjDatePicker6.TextColor = Color.White;
            // 
            // artanPanel7
            // 
            artanPanel7.BackColor = Color.White;
            artanPanel7.BorderRadius = 7;
            artanPanel7.Controls.Add(rjDatePicker4);
            artanPanel7.ForeColor = Color.Black;
            artanPanel7.GradientAngle = 30F;
            artanPanel7.GradientBottomColor = Color.FromArgb(113, 168, 223);
            artanPanel7.GradientTopColor = Color.FromArgb(113, 168, 223);
            artanPanel7.Location = new Point(46, 371);
            artanPanel7.Name = "artanPanel7";
            artanPanel7.Size = new Size(228, 44);
            artanPanel7.TabIndex = 20;
            // 
            // rjDatePicker4
            // 
            rjDatePicker4.BorderColor = Color.FromArgb(113, 168, 223);
            rjDatePicker4.BorderSize = 0;
            rjDatePicker4.CalendarMonthBackground = SystemColors.HotTrack;
            rjDatePicker4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjDatePicker4.Location = new Point(25, 4);
            rjDatePicker4.MinimumSize = new Size(0, 40);
            rjDatePicker4.Name = "rjDatePicker4";
            rjDatePicker4.Size = new Size(200, 40);
            rjDatePicker4.SkinColor = Color.FromArgb(113, 168, 223);
            rjDatePicker4.TabIndex = 15;
            rjDatePicker4.TextColor = Color.White;
            // 
            // artanPanel8
            // 
            artanPanel8.BackColor = Color.White;
            artanPanel8.BorderRadius = 7;
            artanPanel8.Controls.Add(rjDatePicker5);
            artanPanel8.ForeColor = Color.Black;
            artanPanel8.GradientAngle = 30F;
            artanPanel8.GradientBottomColor = Color.FromArgb(113, 168, 223);
            artanPanel8.GradientTopColor = Color.FromArgb(113, 168, 223);
            artanPanel8.Location = new Point(323, 297);
            artanPanel8.Name = "artanPanel8";
            artanPanel8.Size = new Size(228, 44);
            artanPanel8.TabIndex = 19;
            // 
            // rjDatePicker5
            // 
            rjDatePicker5.BorderColor = Color.FromArgb(113, 168, 223);
            rjDatePicker5.BorderSize = 0;
            rjDatePicker5.CalendarMonthBackground = SystemColors.HotTrack;
            rjDatePicker5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjDatePicker5.Location = new Point(23, 4);
            rjDatePicker5.MinimumSize = new Size(0, 40);
            rjDatePicker5.Name = "rjDatePicker5";
            rjDatePicker5.Size = new Size(200, 40);
            rjDatePicker5.SkinColor = Color.FromArgb(113, 168, 223);
            rjDatePicker5.TabIndex = 15;
            rjDatePicker5.TextColor = Color.White;
            // 
            // artanPanel9
            // 
            artanPanel9.BackColor = Color.White;
            artanPanel9.BorderRadius = 7;
            artanPanel9.Controls.Add(rjDatePicker6);
            artanPanel9.ForeColor = Color.Black;
            artanPanel9.GradientAngle = 30F;
            artanPanel9.GradientBottomColor = Color.FromArgb(113, 168, 223);
            artanPanel9.GradientTopColor = Color.FromArgb(113, 168, 223);
            artanPanel9.Location = new Point(46, 297);
            artanPanel9.Name = "artanPanel9";
            artanPanel9.Size = new Size(228, 44);
            artanPanel9.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(54, 275);
            label9.Name = "label9";
            label9.Size = new Size(104, 19);
            label9.TabIndex = 6;
            label9.Text = "Thời gian bắt đầu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(54, 349);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 10;
            label10.Text = "Thời gian tạo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(54, 169);
            label11.Name = "label11";
            label11.Size = new Size(106, 19);
            label11.TabIndex = 4;
            label11.Text = "Mô tả khuyến mãi:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(54, 26);
            label12.Name = "label12";
            label12.Size = new Size(95, 19);
            label12.TabIndex = 0;
            label12.Text = "Tên khuyến mãi:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(54, 96);
            label13.Name = "label13";
            label13.Size = new Size(82, 19);
            label13.TabIndex = 2;
            label13.Text = "Mức giảm giá:";
            // 
            // vbButton3
            // 
            vbButton3.Anchor = AnchorStyles.Top;
            vbButton3.BackColor = Color.FromArgb(113, 168, 223);
            vbButton3.BackgroundColor = Color.FromArgb(113, 168, 223);
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 15;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.ForeColor = Color.White;
            vbButton3.Location = new Point(146, 440);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(150, 40);
            vbButton3.TabIndex = 14;
            vbButton3.Text = "vbButton3";
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            // 
            // huy_but
            // 
            huy_but.Anchor = AnchorStyles.Top;
            huy_but.BackColor = Color.FromArgb(210, 220, 230);
            huy_but.BackgroundColor = Color.FromArgb(210, 220, 230);
            huy_but.BorderColor = Color.FromArgb(210, 220, 230);
            huy_but.BorderRadius = 15;
            huy_but.BorderSize = 0;
            huy_but.FlatAppearance.BorderSize = 0;
            huy_but.FlatStyle = FlatStyle.Flat;
            huy_but.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            huy_but.ForeColor = Color.DimGray;
            huy_but.Location = new Point(315, 440);
            huy_but.Name = "huy_but";
            huy_but.Size = new Size(150, 40);
            huy_but.TabIndex = 13;
            huy_but.Text = "Hủy";
            huy_but.TextColor = Color.DimGray;
            huy_but.UseVisualStyleBackColor = false;
            huy_but.Click += huy_but_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(335, 275);
            label14.Name = "label14";
            label14.Size = new Size(107, 19);
            label14.TabIndex = 8;
            label14.Text = "Thời gian kết thúc:";
            // 
            // rjTextBox5
            // 
            rjTextBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox5.BackColor = SystemColors.Window;
            rjTextBox5.BorderColor = Color.FromArgb(113, 168, 223);
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 8;
            rjTextBox5.BorderSize = 1;
            rjTextBox5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox5.Location = new Point(46, 179);
            rjTextBox5.Margin = new Padding(4);
            rjTextBox5.Multiline = true;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "";
            rjTextBox5.Size = new Size(500, 70);
            rjTextBox5.TabIndex = 5;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            rjTextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox6.BackColor = SystemColors.Window;
            rjTextBox6.BorderColor = Color.FromArgb(113, 168, 223);
            rjTextBox6.BorderFocusColor = Color.HotPink;
            rjTextBox6.BorderRadius = 5;
            rjTextBox6.BorderSize = 1;
            rjTextBox6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox6.Location = new Point(46, 108);
            rjTextBox6.Margin = new Padding(4);
            rjTextBox6.Multiline = false;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DarkGray;
            rjTextBox6.PlaceholderText = "";
            rjTextBox6.Size = new Size(500, 34);
            rjTextBox6.TabIndex = 3;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox7
            // 
            rjTextBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox7.BackColor = SystemColors.Window;
            rjTextBox7.BorderColor = Color.FromArgb(113, 168, 223);
            rjTextBox7.BorderFocusColor = Color.HotPink;
            rjTextBox7.BorderRadius = 7;
            rjTextBox7.BorderSize = 1;
            rjTextBox7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjTextBox7.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox7.Location = new Point(46, 40);
            rjTextBox7.Margin = new Padding(4);
            rjTextBox7.Multiline = false;
            rjTextBox7.Name = "rjTextBox7";
            rjTextBox7.Padding = new Padding(10, 7, 10, 7);
            rjTextBox7.PasswordChar = false;
            rjTextBox7.PlaceholderColor = Color.DarkGray;
            rjTextBox7.PlaceholderText = "";
            rjTextBox7.Size = new Size(500, 34);
            rjTextBox7.TabIndex = 1;
            rjTextBox7.Texts = "";
            rjTextBox7.UnderlinedStyle = false;
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.Silver;
            artanPanel1.GradientTopColor = Color.DodgerBlue;
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1118, 120);
            artanPanel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Light SemiCondensed", 35F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(326, 35);
            label1.Name = "label1";
            label1.Size = new Size(402, 57);
            label1.TabIndex = 13;
            label1.Text = "Quản lý khuyến mãi";
            // 
            // KhuyenMaiGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 755);
            Controls.Add(artanPanel1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KhuyenMaiGUI";
            Text = "KhuyenMaiGUI";
            Load += KhuyenMaiGUI_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tk_panel.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            km_pan.ResumeLayout(false);
            km_pan.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            artanPanel7.ResumeLayout(false);
            artanPanel8.ResumeLayout(false);
            artanPanel9.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ArtanPanel artanPanel1;
        private Label label1;
        private ArtanPanel artanPanel3;
        private DataGridView dataGridView1;
        private RJTextBox rjTextBox1;
        private VBButton vbButton1;
        private Panel tk_panel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
        private VBButton vbButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ArtanPanel km_pan;
        private Label label15;
        private Panel panel2;
        private ArtanPanel artanPanel7;
        private RJDateTimePicker.RJDatePicker rjDatePicker4;
        private ArtanPanel artanPanel8;
        private RJDateTimePicker.RJDatePicker rjDatePicker5;
        private ArtanPanel artanPanel9;
        private RJDateTimePicker.RJDatePicker rjDatePicker6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private VBButton vbButton3;
        private VBButton huy_but;
        private Label label14;
        private RJTextBox rjTextBox5;
        private RJTextBox rjTextBox6;
        private RJTextBox rjTextBox7;
    }
}