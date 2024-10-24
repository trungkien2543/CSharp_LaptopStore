namespace CSharp_laptop.GUI
{
    partial class TestBanHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBanHang));
            artanPanel2 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            vbButton2 = new VBButton();
            vbButton1 = new VBButton();
            rjDatePicker2 = new RJDateTimePicker.RJDatePicker();
            rjDatePicker1 = new RJDateTimePicker.RJDatePicker();
            rjTextBox1 = new RJTextBox();
            label1 = new Label();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 10;
            artanPanel2.Controls.Add(dataGridView1);
            artanPanel2.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.FromArgb(57, 54, 161);
            artanPanel2.GradientTopColor = Color.FromArgb(57, 54, 161);
            artanPanel2.Location = new Point(0, 167);
            artanPanel2.Margin = new Padding(3, 4, 3, 4);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Padding = new Padding(5, 0, 5, 20);
            artanPanel2.Size = new Size(1277, 767);
            artanPanel2.TabIndex = 12;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 54, 161);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 54, 161);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(5, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
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
            dataGridView1.Size = new Size(1267, 747);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 50F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 80F;
            Column2.HeaderText = "Tên KH";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 70F;
            Column3.HeaderText = "Địa Chỉ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 80F;
            Column4.HeaderText = "SĐT";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 60F;
            Column5.HeaderText = "Tích Điểm";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.FillWeight = 40F;
            Column7.HeaderText = "Edit";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.FillWeight = 40F;
            Column8.HeaderText = "Delete";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // vbButton2
            // 
            vbButton2.BackColor = Color.FromArgb(57, 54, 161);
            vbButton2.BackgroundColor = Color.FromArgb(57, 54, 161);
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 28;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = (Image)resources.GetObject("vbButton2.Image");
            vbButton2.Location = new Point(573, 83);
            vbButton2.Margin = new Padding(3, 4, 3, 4);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(55, 55);
            vbButton2.TabIndex = 29;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.FromArgb(57, 54, 161);
            vbButton1.BackgroundColor = Color.FromArgb(57, 54, 161);
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 28;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.icons8_add_50;
            vbButton1.Location = new Point(1210, 83);
            vbButton1.Margin = new Padding(3, 4, 3, 4);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(55, 55);
            vbButton1.TabIndex = 28;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // rjDatePicker2
            // 
            rjDatePicker2.BorderColor = Color.PaleVioletRed;
            rjDatePicker2.BorderSize = 0;
            rjDatePicker2.CustomFormat = "dd/MM/yyyy";
            rjDatePicker2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjDatePicker2.Format = DateTimePickerFormat.Custom;
            rjDatePicker2.Location = new Point(291, 112);
            rjDatePicker2.Margin = new Padding(3, 4, 3, 4);
            rjDatePicker2.MinimumSize = new Size(4, 40);
            rjDatePicker2.Name = "rjDatePicker2";
            rjDatePicker2.Size = new Size(260, 40);
            rjDatePicker2.SkinColor = Color.FromArgb(57, 54, 161);
            rjDatePicker2.TabIndex = 27;
            rjDatePicker2.TextColor = Color.White;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.BorderColor = Color.PaleVioletRed;
            rjDatePicker1.BorderSize = 0;
            rjDatePicker1.CustomFormat = "dd/MM/yyyy";
            rjDatePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjDatePicker1.Format = DateTimePickerFormat.Custom;
            rjDatePicker1.Location = new Point(10, 112);
            rjDatePicker1.Margin = new Padding(3, 4, 3, 4);
            rjDatePicker1.MinimumSize = new Size(4, 40);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(260, 40);
            rjDatePicker1.SkinColor = Color.FromArgb(57, 54, 161);
            rjDatePicker1.TabIndex = 26;
            rjDatePicker1.TextColor = Color.White;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(57, 54, 161);
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(10, 69);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(541, 35);
            rjTextBox1.TabIndex = 25;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 54, 161);
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 24;
            label1.Text = "Quản lý hóa đơn";
            // 
            // TestBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 951);
            Controls.Add(vbButton2);
            Controls.Add(artanPanel2);
            Controls.Add(vbButton1);
            Controls.Add(rjTextBox1);
            Controls.Add(rjDatePicker2);
            Controls.Add(label1);
            Controls.Add(rjDatePicker1);
            Name = "TestBanHang";
            Text = "TestBanHang";
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ArtanPanel artanPanel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private RJDateTimePicker.RJDatePicker rjDatePicker2;
        private RJDateTimePicker.RJDatePicker rjDatePicker1;
        private RJTextBox rjTextBox1;
        private Label label1;
    }
}