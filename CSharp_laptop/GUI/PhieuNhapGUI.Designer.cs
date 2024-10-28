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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            them_but = new VBButton();
            artanPanel2 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            tk_panel = new Panel();
            rjTextBox1 = new RJTextBox();
            vbButton1 = new VBButton();
            tabPage2 = new TabPage();
            km_pan = new ArtanPanel();
            label15 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            rjTextBox3 = new RJTextBox();
            label2 = new Label();
            rjTextBox2 = new RJTextBox();
            artanPanel9 = new ArtanPanel();
            rjDatePicker6 = new RJDateTimePicker.RJDatePicker();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            vbButton3 = new VBButton();
            huy_but = new VBButton();
            rjTextBox6 = new RJTextBox();
            rjTextBox7 = new RJTextBox();
            tabPage3 = new TabPage();
            artanPanel1 = new ArtanPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tk_panel.SuspendLayout();
            tabPage2.SuspendLayout();
            km_pan.SuspendLayout();
            panel2.SuspendLayout();
            artanPanel9.SuspendLayout();
            artanPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Light SemiCondensed", 35F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(383, 35);
            label1.Name = "label1";
            label1.Size = new Size(392, 57);
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
            tabControl1.Location = new Point(0, 120);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 637);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(them_but);
            tabPage1.Controls.Add(artanPanel2);
            tabPage1.Controls.Add(tk_panel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1110, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // them_but
            // 
            them_but.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            them_but.BackColor = Color.FromArgb(119, 195, 144);
            them_but.BackgroundColor = Color.FromArgb(119, 195, 144);
            them_but.BorderColor = Color.PaleVioletRed;
            them_but.BorderRadius = 15;
            them_but.BorderSize = 0;
            them_but.FlatAppearance.BorderSize = 0;
            them_but.FlatStyle = FlatStyle.Flat;
            them_but.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            them_but.ForeColor = Color.White;
            them_but.Image = (Image)resources.GetObject("them_but.Image");
            them_but.ImageAlign = ContentAlignment.MiddleLeft;
            them_but.Location = new Point(962, 89);
            them_but.Name = "them_but";
            them_but.Padding = new Padding(0, 0, 15, 0);
            them_but.Size = new Size(100, 40);
            them_but.TabIndex = 39;
            them_but.Text = "Thêm";
            them_but.TextAlign = ContentAlignment.MiddleRight;
            them_but.TextColor = Color.White;
            them_but.UseVisualStyleBackColor = false;
            them_but.Click += them_but_Click_1;
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 20;
            artanPanel2.Controls.Add(dataGridView1);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 65F;
            artanPanel2.GradientBottomColor = Color.FromArgb(178, 211, 154);
            artanPanel2.GradientTopColor = Color.MediumSeaGreen;
            artanPanel2.Location = new Point(40, 135);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Padding = new Padding(4, 0, 4, 15);
            artanPanel2.Size = new Size(1022, 431);
            artanPanel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 195, 144);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(4, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1014, 416);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "ID nhân viên";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "ID nhà cung cấp";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Ngày nhập";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Tổng tiền";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Tiền trả";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Tiền thối";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "123";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // tk_panel
            // 
            tk_panel.Anchor = AnchorStyles.Top;
            tk_panel.Controls.Add(rjTextBox1);
            tk_panel.Controls.Add(vbButton1);
            tk_panel.Location = new Point(205, 55);
            tk_panel.Name = "tk_panel";
            tk_panel.Size = new Size(700, 40);
            tk_panel.TabIndex = 38;
            // 
            // rjTextBox1
            // 
            rjTextBox1.Anchor = AnchorStyles.Top;
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(119, 195, 144);
            rjTextBox1.BorderFocusColor = Color.YellowGreen;
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
            vbButton1.BackColor = Color.FromArgb(119, 195, 144);
            vbButton1.BackgroundColor = Color.FromArgb(119, 195, 144);
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
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(km_pan);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1110, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // km_pan
            // 
            km_pan.Anchor = AnchorStyles.None;
            km_pan.BackColor = Color.White;
            km_pan.BorderRadius = 30;
            km_pan.Controls.Add(label15);
            km_pan.Controls.Add(panel2);
            km_pan.ForeColor = Color.Black;
            km_pan.GradientAngle = 40F;
            km_pan.GradientBottomColor = Color.FromArgb(195, 216, 160);
            km_pan.GradientTopColor = Color.FromArgb(96, 188, 132);
            km_pan.Location = new Point(255, 29);
            km_pan.Name = "km_pan";
            km_pan.Padding = new Padding(4, 40, 4, 15);
            km_pan.Size = new Size(600, 550);
            km_pan.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(50, 12);
            label15.Name = "label15";
            label15.Size = new Size(130, 25);
            label15.TabIndex = 2;
            label15.Text = "Thêm phiếu nhập";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rjTextBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(artanPanel9);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(vbButton3);
            panel2.Controls.Add(huy_but);
            panel2.Controls.Add(rjTextBox6);
            panel2.Controls.Add(rjTextBox7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 495);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(54, 319);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 21;
            label3.Text = "Tiền thối:";
            // 
            // rjTextBox3
            // 
            rjTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox3.BackColor = SystemColors.Window;
            rjTextBox3.BorderColor = Color.FromArgb(119, 195, 144);
            rjTextBox3.BorderFocusColor = Color.YellowGreen;
            rjTextBox3.BorderRadius = 5;
            rjTextBox3.BorderSize = 1;
            rjTextBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(46, 331);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.Size = new Size(500, 34);
            rjTextBox3.TabIndex = 22;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(54, 251);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 19;
            label2.Text = "Tiền trả:";
            // 
            // rjTextBox2
            // 
            rjTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.FromArgb(119, 195, 144);
            rjTextBox2.BorderFocusColor = Color.YellowGreen;
            rjTextBox2.BorderRadius = 5;
            rjTextBox2.BorderSize = 1;
            rjTextBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(46, 263);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(500, 34);
            rjTextBox2.TabIndex = 20;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // artanPanel9
            // 
            artanPanel9.BackColor = Color.White;
            artanPanel9.BorderRadius = 7;
            artanPanel9.Controls.Add(rjDatePicker6);
            artanPanel9.ForeColor = Color.Black;
            artanPanel9.GradientAngle = 30F;
            artanPanel9.GradientBottomColor = Color.FromArgb(119, 195, 144);
            artanPanel9.GradientTopColor = Color.FromArgb(119, 195, 144);
            artanPanel9.Location = new Point(46, 185);
            artanPanel9.Name = "artanPanel9";
            artanPanel9.Padding = new Padding(10, 0, 0, 0);
            artanPanel9.Size = new Size(228, 44);
            artanPanel9.TabIndex = 18;
            // 
            // rjDatePicker6
            // 
            rjDatePicker6.BorderColor = Color.FromArgb(113, 168, 223);
            rjDatePicker6.BorderSize = 0;
            rjDatePicker6.CalendarMonthBackground = SystemColors.InactiveCaption;
            rjDatePicker6.Dock = DockStyle.Fill;
            rjDatePicker6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjDatePicker6.Location = new Point(10, 0);
            rjDatePicker6.MinimumSize = new Size(0, 40);
            rjDatePicker6.Name = "rjDatePicker6";
            rjDatePicker6.Size = new Size(218, 40);
            rjDatePicker6.SkinColor = Color.FromArgb(119, 195, 144);
            rjDatePicker6.TabIndex = 15;
            rjDatePicker6.TextColor = Color.White;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(54, 163);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 6;
            label9.Text = "Ngày nhập:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(54, 26);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 0;
            label12.Text = "ID nhân viên:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(54, 96);
            label13.Name = "label13";
            label13.Size = new Size(94, 19);
            label13.TabIndex = 2;
            label13.Text = "ID nhà cung cấp";
            // 
            // vbButton3
            // 
            vbButton3.Anchor = AnchorStyles.Top;
            vbButton3.BackColor = Color.FromArgb(119, 195, 144);
            vbButton3.BackgroundColor = Color.FromArgb(119, 195, 144);
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 15;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.ForeColor = Color.White;
            vbButton3.Location = new Point(149, 440);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(150, 40);
            vbButton3.TabIndex = 14;
            vbButton3.Text = "Đồng ý";
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            // 
            // huy_but
            // 
            huy_but.Anchor = AnchorStyles.Top;
            huy_but.BackColor = Color.FromArgb(195, 216, 160);
            huy_but.BackgroundColor = Color.FromArgb(195, 216, 160);
            huy_but.BorderColor = Color.FromArgb(210, 220, 230);
            huy_but.BorderRadius = 15;
            huy_but.BorderSize = 0;
            huy_but.FlatAppearance.BorderSize = 0;
            huy_but.FlatStyle = FlatStyle.Flat;
            huy_but.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            huy_but.ForeColor = Color.DimGray;
            huy_but.Location = new Point(317, 440);
            huy_but.Name = "huy_but";
            huy_but.Size = new Size(150, 40);
            huy_but.TabIndex = 13;
            huy_but.Text = "Hủy";
            huy_but.TextColor = Color.DimGray;
            huy_but.UseVisualStyleBackColor = false;
            huy_but.Click += huy_but_Click;
            // 
            // rjTextBox6
            // 
            rjTextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rjTextBox6.BackColor = SystemColors.Window;
            rjTextBox6.BorderColor = Color.FromArgb(119, 195, 144);
            rjTextBox6.BorderFocusColor = Color.YellowGreen;
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
            rjTextBox7.BorderColor = Color.FromArgb(119, 195, 144);
            rjTextBox7.BorderFocusColor = Color.YellowGreen;
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
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1110, 609);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 0;
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(195, 216, 160);
            artanPanel1.GradientTopColor = Color.MediumSeaGreen;
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1118, 120);
            artanPanel1.TabIndex = 2;
            // 
            // PhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 755);
            Controls.Add(artanPanel1);
            Controls.Add(tabControl1);
            Name = "PhieuNhapGUI";
            Text = "PhieuNhapGUI";
            Load += PhieuNhapGUI_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tk_panel.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            km_pan.ResumeLayout(false);
            km_pan.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            artanPanel9.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ArtanPanel artanPanel1;
        private Panel tk_panel;
        private RJTextBox rjTextBox1;
        private VBButton vbButton1;
        private ArtanPanel artanPanel2;
        private DataGridView dataGridView1;
        private VBButton them_but;
        private ArtanPanel km_pan;
        private Label label15;
        private Panel panel2;
        private ArtanPanel artanPanel9;
        private RJDateTimePicker.RJDatePicker rjDatePicker6;
        private Label label9;
        private Label label12;
        private Label label13;
        private VBButton vbButton3;
        private VBButton huy_but;
        private RJTextBox rjTextBox6;
        private RJTextBox rjTextBox7;
        private Label label3;
        private RJTextBox rjTextBox3;
        private Label label2;
        private RJTextBox rjTextBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}