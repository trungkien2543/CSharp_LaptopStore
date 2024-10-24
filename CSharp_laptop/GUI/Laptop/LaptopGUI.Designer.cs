namespace CSharp_laptop.GUI.Laptop
{
    partial class LaptopGUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopGUI));
            panel1 = new Panel();
            artanPanel2 = new ArtanPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label12 = new Label();
            label2 = new Label();
            label20 = new Label();
            label4 = new Label();
            label19 = new Label();
            label5 = new Label();
            label18 = new Label();
            label6 = new Label();
            label17 = new Label();
            label7 = new Label();
            label16 = new Label();
            label8 = new Label();
            label15 = new Label();
            label9 = new Label();
            label14 = new Label();
            label10 = new Label();
            label13 = new Label();
            label11 = new Label();
            vbButton1 = new VBButton();
            rjTextBox1 = new RJTextBox();
            vbButton2 = new VBButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(artanPanel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 675);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 30;
            artanPanel2.Controls.Add(rjTextBox1);
            artanPanel2.Controls.Add(vbButton2);
            artanPanel2.Controls.Add(vbButton1);
            artanPanel2.Controls.Add(pictureBox1);
            artanPanel2.Controls.Add(label1);
            artanPanel2.Controls.Add(label12);
            artanPanel2.Controls.Add(label2);
            artanPanel2.Controls.Add(label20);
            artanPanel2.Controls.Add(label4);
            artanPanel2.Controls.Add(label19);
            artanPanel2.Controls.Add(label5);
            artanPanel2.Controls.Add(label18);
            artanPanel2.Controls.Add(label6);
            artanPanel2.Controls.Add(label17);
            artanPanel2.Controls.Add(label7);
            artanPanel2.Controls.Add(label16);
            artanPanel2.Controls.Add(label8);
            artanPanel2.Controls.Add(label15);
            artanPanel2.Controls.Add(label9);
            artanPanel2.Controls.Add(label14);
            artanPanel2.Controls.Add(label10);
            artanPanel2.Controls.Add(label13);
            artanPanel2.Controls.Add(label11);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.Navy;
            artanPanel2.GradientTopColor = Color.Red;
            artanPanel2.Location = new Point(15, 9);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(1197, 376);
            artanPanel2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.Image = Properties.Resources.win12;
            pictureBox1.Location = new Point(394, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Laptop";
            label1.Click += label1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 0, 0, 0);
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(394, 180);
            label12.Name = "label12";
            label12.Size = new Size(104, 30);
            label12.TabIndex = 31;
            label12.Text = "Hình ảnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 21);
            label2.Name = "label2";
            label2.Size = new Size(255, 37);
            label2.TabIndex = 7;
            label2.Text = "Asus Macbook Pro";
            label2.Click += label2_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(0, 0, 0, 0);
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(560, 130);
            label20.Name = "label20";
            label20.Size = new Size(150, 30);
            label20.TabIndex = 30;
            label20.Text = "Black Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 75);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 10;
            label4.Text = "ID Loại";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(0, 0, 0, 0);
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(560, 80);
            label19.Name = "label19";
            label19.Size = new Size(107, 30);
            label19.TabIndex = 29;
            label19.Text = "RTX 9090";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 125);
            label5.Name = "label5";
            label5.Size = new Size(66, 30);
            label5.TabIndex = 11;
            label5.Text = "Hãng";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(0, 0, 0, 0);
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(155, 326);
            label18.Name = "label18";
            label18.Size = new Size(79, 30);
            label18.TabIndex = 28;
            label18.Text = "18inch";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 175);
            label6.Name = "label6";
            label6.Size = new Size(45, 30);
            label6.TabIndex = 12;
            label6.Text = "Giá";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(0, 0, 0, 0);
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(155, 276);
            label17.Name = "label17";
            label17.Size = new Size(65, 30);
            label17.TabIndex = 27;
            label17.Text = "64GB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 223);
            label7.Name = "label7";
            label7.Size = new Size(54, 30);
            label7.TabIndex = 13;
            label7.Text = "CPU";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(0, 0, 0, 0);
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(155, 223);
            label16.Name = "label16";
            label16.Size = new Size(94, 30);
            label16.TabIndex = 26;
            label16.Text = "Intel i11";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 276);
            label8.Name = "label8";
            label8.Size = new Size(62, 30);
            label8.TabIndex = 14;
            label8.Text = "RAM";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(0, 0, 0, 0);
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(155, 175);
            label15.Name = "label15";
            label15.Size = new Size(134, 30);
            label15.TabIndex = 25;
            label15.Text = "40.000.000đ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(21, 326);
            label9.Name = "label9";
            label9.Size = new Size(120, 30);
            label9.TabIndex = 15;
            label9.Text = "Kích thước";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 0, 0, 0);
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(155, 125);
            label14.Name = "label14";
            label14.Size = new Size(103, 30);
            label14.TabIndex = 24;
            label14.Text = "Samsung";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 0, 0, 0);
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(394, 80);
            label10.Name = "label10";
            label10.Size = new Size(56, 30);
            label10.TabIndex = 16;
            label10.Text = "GPU";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 0, 0, 0);
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(155, 75);
            label13.Name = "label13";
            label13.Size = new Size(82, 30);
            label13.TabIndex = 23;
            label13.Text = "ID Loại";
            label13.Click += label13_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 0, 0, 0);
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(394, 128);
            label11.Name = "label11";
            label11.Size = new Size(130, 30);
            label11.TabIndex = 17;
            label11.Text = "Khuyến mãi";
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(1028, 21);
            vbButton1.Name = "vbButton1";
            vbButton1.Padding = new Padding(7, 0, 0, 0);
            vbButton1.Size = new Size(137, 44);
            vbButton1.TabIndex = 33;
            vbButton1.Text = "Quay lại";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(821, 316);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(287, 40);
            rjTextBox1.TabIndex = 34;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton2.BackColor = Color.MediumSlateBlue;
            vbButton2.BackgroundColor = Color.MediumSlateBlue;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = Properties.Resources.icons8_find_29;
            vbButton2.Location = new Point(1115, 318);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(50, 38);
            vbButton2.TabIndex = 32;
            vbButton2.TextColor = Color.White;
            vbButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(11, 391);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1201, 277);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(2113, 79);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(112, 58);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LaptopGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 681);
            Controls.Add(panel1);
            Name = "LaptopGUI";
            Text = "Laptop";
            panel1.ResumeLayout(false);
            artanPanel2.ResumeLayout(false);
            artanPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button button4;
        private VBButton vbButton2;
        private ContextMenuStrip contextMenuStrip1;
        private VBButton vbButton1;
        private RJTextBox rjTextBox1;
        private ArtanPanel artanPanel1;
        private ArtanPanel artanPanel2;
    }
}