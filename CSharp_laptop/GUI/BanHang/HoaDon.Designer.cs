namespace CSharp_laptop.GUI
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtFind = new RJTextBox();
            vbButton2 = new VBButton();
            DateTimeFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateTimeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            dataGridView2 = new DataGridView();
            vbButton3 = new VBButton();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.BackColor = SystemColors.Window;
            txtFind.BorderColor = Color.FromArgb(247, 176, 118);
            txtFind.BorderFocusColor = Color.DodgerBlue;
            txtFind.BorderRadius = 15;
            txtFind.BorderSize = 2;
            txtFind.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFind.ForeColor = Color.FromArgb(64, 64, 64);
            txtFind.Location = new Point(4, 13);
            txtFind.Margin = new Padding(4);
            txtFind.Multiline = false;
            txtFind.Name = "txtFind";
            txtFind.Padding = new Padding(10, 7, 10, 7);
            txtFind.PasswordChar = false;
            txtFind.PlaceholderColor = Color.DarkGray;
            txtFind.PlaceholderText = "";
            txtFind.Size = new Size(482, 40);
            txtFind.TabIndex = 36;
            txtFind.Texts = "";
            txtFind.UnderlinedStyle = false;
            txtFind._TextChanged += rjTextBox1__TextChanged;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton2.BackColor = Color.FromArgb(247, 176, 118);
            vbButton2.BackgroundColor = Color.FromArgb(247, 176, 118);
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 15;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = (Image)resources.GetObject("vbButton2.Image");
            vbButton2.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton2.Location = new Point(1002, 60);
            vbButton2.Name = "vbButton2";
            vbButton2.Padding = new Padding(0, 0, 15, 0);
            vbButton2.Size = new Size(111, 40);
            vbButton2.TabIndex = 39;
            vbButton2.Text = "Thêm";
            vbButton2.TextAlign = ContentAlignment.MiddleRight;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // DateTimeFrom
            // 
            DateTimeFrom.BorderRadius = 10;
            DateTimeFrom.Checked = true;
            DateTimeFrom.CustomizableEdges = customizableEdges1;
            DateTimeFrom.FillColor = Color.FromArgb(247, 176, 118);
            DateTimeFrom.Font = new Font("Segoe UI", 9F);
            DateTimeFrom.ForeColor = Color.White;
            DateTimeFrom.Format = DateTimePickerFormat.Long;
            DateTimeFrom.Location = new Point(4, 60);
            DateTimeFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimeFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimeFrom.Name = "DateTimeFrom";
            DateTimeFrom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTimeFrom.Size = new Size(238, 40);
            DateTimeFrom.TabIndex = 42;
            DateTimeFrom.Value = new DateTime(2024, 11, 8, 16, 19, 53, 513);
            DateTimeFrom.ValueChanged += DateTimeFrom_ValueChanged;
            // 
            // DateTimeTo
            // 
            DateTimeTo.BorderRadius = 10;
            DateTimeTo.Checked = true;
            DateTimeTo.CustomizableEdges = customizableEdges3;
            DateTimeTo.FillColor = Color.FromArgb(247, 176, 118);
            DateTimeTo.Font = new Font("Segoe UI", 9F);
            DateTimeTo.ForeColor = Color.White;
            DateTimeTo.Format = DateTimePickerFormat.Long;
            DateTimeTo.Location = new Point(248, 60);
            DateTimeTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimeTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimeTo.Name = "DateTimeTo";
            DateTimeTo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DateTimeTo.Size = new Size(238, 40);
            DateTimeTo.TabIndex = 43;
            DateTimeTo.Value = new DateTime(2024, 11, 8, 16, 19, 53, 513);
            DateTimeTo.ValueChanged += DateTimeTo_ValueChanged;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderRadius = 12;
            guna2GradientPanel1.Controls.Add(dataGridView2);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(85, 81, 132);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(210, 220, 230);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            guna2GradientPanel1.Location = new Point(4, 106);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(1112, 608);
            guna2GradientPanel1.TabIndex = 46;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 81, 132);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(85, 81, 132);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PapayaWhip;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(0, 12);
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
            dataGridView2.Size = new Size(1109, 581);
            dataGridView2.TabIndex = 0;
            // 
            // vbButton3
            // 
            vbButton3.BackColor = Color.FromArgb(247, 176, 118);
            vbButton3.BackgroundColor = Color.FromArgb(247, 176, 118);
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 15;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton3.ForeColor = Color.White;
            vbButton3.Image = (Image)resources.GetObject("vbButton3.Image");
            vbButton3.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton3.Location = new Point(492, 13);
            vbButton3.Name = "vbButton3";
            vbButton3.Padding = new Padding(0, 0, 15, 0);
            vbButton3.Size = new Size(111, 40);
            vbButton3.TabIndex = 47;
            vbButton3.Text = "Làm mới";
            vbButton3.TextAlign = ContentAlignment.MiddleRight;
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            vbButton3.Click += vbButton3_Click_1;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.SeaGreen;
            guna2Button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1002, 13);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(111, 40);
            guna2Button1.TabIndex = 48;
            guna2Button1.Text = "Xuất Excel";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 147, 186);
            ClientSize = new Size(1117, 713);
            Controls.Add(guna2Button1);
            Controls.Add(vbButton3);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(DateTimeTo);
            Controls.Add(DateTimeFrom);
            Controls.Add(vbButton2);
            Controls.Add(txtFind);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HoaDon";
            Text = "TestBanHang";
            Load += BanHang_Load;
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RJTextBox txtFind;
        private VBButton vbButton2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeTo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private DataGridView dataGridView2;
        private VBButton vbButton3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}