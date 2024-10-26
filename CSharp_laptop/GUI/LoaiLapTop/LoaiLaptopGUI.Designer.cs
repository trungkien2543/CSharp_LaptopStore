namespace CSharp_laptop.GUI
{
    partial class LoaiLaptopGUI
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
            panel1 = new Panel();
            artanPanel1 = new ArtanPanel();
            rjTextBox1 = new RJTextBox();
            vbButton1 = new VBButton();
            vbButton2 = new VBButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(artanPanel1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 701);
            panel1.TabIndex = 0;
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(rjTextBox1);
            artanPanel1.Controls.Add(vbButton1);
            artanPanel1.Controls.Add(vbButton2);
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.CadetBlue;
            artanPanel1.GradientTopColor = Color.DodgerBlue;
            artanPanel1.Location = new Point(11, 11);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1202, 151);
            artanPanel1.TabIndex = 10;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(30, 93);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(287, 39);
            rjTextBox1.TabIndex = 12;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
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
            vbButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.icons8_add_29;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(1062, 74);
            vbButton1.Name = "vbButton1";
            vbButton1.Padding = new Padding(7, 0, 0, 0);
            vbButton1.Size = new Size(123, 58);
            vbButton1.TabIndex = 7;
            vbButton1.Text = "Thêm";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // vbButton2
            // 
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
            vbButton2.Location = new Point(339, 93);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(70, 39);
            vbButton2.TabIndex = 11;
            vbButton2.TextColor = Color.White;
            vbButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 10;
            label1.Text = "Danh sách loại laptop";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(11, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1202, 527);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // LoaiLaptopGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 703);
            Controls.Add(panel1);
            Name = "LoaiLaptopGUI";
            Text = "SanPhamGUI";
            panel1.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button2;
        private VBButton vbButton1;
        private ArtanPanel artanPanel1;
        private RJTextBox rjTextBox1;
        private VBButton vbButton2;
        private Label label1;
    }
}