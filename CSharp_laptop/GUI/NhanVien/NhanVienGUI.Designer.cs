﻿namespace CSharp_laptop.GUI
{
    partial class NhanVienGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienGUI));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            vbButton1 = new VBButton();
            vbButton2 = new VBButton();
            rjTextBox1 = new RJTextBox();
            panel1 = new Panel();
            artanPanel1 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 10;
            label1.Text = "Danh sách nhân viên";
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.MediumPurple;
            vbButton1.BackgroundColor = Color.MediumPurple;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 25;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = (Image)resources.GetObject("vbButton1.Image");
            vbButton1.Location = new Point(955, 48);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(55, 55);
            vbButton1.TabIndex = 14;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // vbButton2
            // 
            vbButton2.BackColor = Color.MediumPurple;
            vbButton2.BackgroundColor = Color.MediumPurple;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = Properties.Resources.icons8_find_29;
            vbButton2.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton2.Location = new Point(459, 64);
            vbButton2.Name = "vbButton2";
            vbButton2.Padding = new Padding(7, 0, 0, 0);
            vbButton2.Size = new Size(137, 39);
            vbButton2.TabIndex = 15;
            vbButton2.Text = "Tìm kiếm";
            vbButton2.TextColor = Color.White;
            vbButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(17, 64);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(424, 39);
            rjTextBox1.TabIndex = 16;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(artanPanel1);
            panel1.Location = new Point(12, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 556);
            panel1.TabIndex = 17;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 10;
            artanPanel1.Controls.Add(dataGridView1);
            artanPanel1.Dock = DockStyle.Fill;
            artanPanel1.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(113, 92, 232);
            artanPanel1.GradientTopColor = Color.FromArgb(113, 92, 232);
            artanPanel1.Location = new Point(0, 0);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Padding = new Padding(4, 0, 4, 15);
            artanPanel1.Size = new Size(998, 556);
            artanPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column9, Column10, Column7, Column8 });
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
            dataGridView1.Size = new Size(990, 541);
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
            Column2.HeaderText = "Tên NV";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 80F;
            Column3.HeaderText = "Ngày Sinh";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "SĐT";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Địa Chỉ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.FillWeight = 80F;
            Column6.HeaderText = "Giới Tính";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "CCCD";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Email";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.FillWeight = 30F;
            Column7.HeaderText = "Edit";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.FillWeight = 40F;
            Column8.HeaderText = "Delete";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // NhanVienGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 679);
            Controls.Add(panel1);
            Controls.Add(rjTextBox1);
            Controls.Add(vbButton2);
            Controls.Add(vbButton1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhanVienGUI";
            Text = "NhanVienGUI";
            Load += NhanVienGUI_Load;
            panel1.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private VBButton vbButton1;
        private VBButton vbButton2;
        private RJTextBox rjTextBox1;
        private Panel panel1;
        private ArtanPanel artanPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column8;
    }
}