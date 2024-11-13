namespace CustomTabControl
{
    partial class HangLaptop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            vbButton1 = new CSharp_laptop.VBButton();
            dateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 67);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold);
            label3.ForeColor = Color.RebeccaPurple;
            label3.Location = new Point(26, 14);
            label3.Name = "label3";
            label3.Size = new Size(860, 40);
            label3.TabIndex = 3;
            label3.Text = "THỐNG KÊ SỐ LƯỢNG LAPTOP BÁN ĐƯỢC THEO HÃNG";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2HtmlLabel1);
            panel2.Controls.Add(guna2HtmlLabel2);
            panel2.Controls.Add(vbButton1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 52);
            panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(355, 10);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(40, 27);
            guna2HtmlLabel1.TabIndex = 20;
            guna2HtmlLabel1.Text = "ĐẾN";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(29, 10);
            guna2HtmlLabel2.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(28, 27);
            guna2HtmlLabel2.TabIndex = 19;
            guna2HtmlLabel2.Text = "TỪ";
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Location = new Point(724, 5);
            vbButton1.Margin = new Padding(3, 2, 3, 2);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(164, 38);
            vbButton1.TabIndex = 13;
            vbButton1.Text = "LỌC";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.BackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker2.Checked = true;
            dateTimePicker2.CustomizableEdges = customizableEdges1;
            dateTimePicker2.FillColor = Color.MediumSlateBlue;
            dateTimePicker2.Font = new Font("Segoe UI", 9F);
            dateTimePicker2.Format = DateTimePickerFormat.Long;
            dateTimePicker2.Location = new Point(414, 7);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateTimePicker2.Size = new Size(219, 34);
            dateTimePicker2.TabIndex = 12;
            dateTimePicker2.Value = new DateTime(2024, 11, 12, 18, 42, 49, 384);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker1.Checked = true;
            dateTimePicker1.CustomizableEdges = customizableEdges3;
            dateTimePicker1.FillColor = Color.MediumSlateBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.Location = new Point(74, 7);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateTimePicker1.Size = new Size(219, 34);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2024, 11, 12, 18, 42, 49, 384);
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(29, 140);
            pieChart1.Margin = new Padding(3, 2, 3, 2);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(494, 416);
            pieChart1.TabIndex = 4;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 619);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 11;
            label1.Text = "Biểu đồ tròn thống kê các loại laptop đã bán theo khoảng thời gian đã chọn";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(529, 204);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 273);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(582, 579);
            label7.Name = "label7";
            label7.Size = new Size(330, 46);
            label7.TabIndex = 13;
            label7.Text = "Bảng thống kê doanh thu các loại laptop đã bán theo khoảng thời gian đã chọn";
            // 
            // HangLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 147, 186);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pieChart1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HangLaptop";
            Size = new Size(984, 665);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker2;
        private CSharp_laptop.VBButton vbButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
