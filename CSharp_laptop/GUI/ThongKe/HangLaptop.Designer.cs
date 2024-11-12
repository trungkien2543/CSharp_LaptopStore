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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            vbButton1 = new CSharp_laptop.VBButton();
            dateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 89);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold);
            label3.ForeColor = Color.RebeccaPurple;
            label3.Location = new Point(30, 19);
            label3.Name = "label3";
            label3.Size = new Size(1064, 50);
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
            panel2.Location = new Point(0, 89);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 69);
            panel2.TabIndex = 1;
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
            vbButton1.Location = new Point(827, 7);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(188, 50);
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
            dateTimePicker2.CustomizableEdges = customizableEdges5;
            dateTimePicker2.FillColor = Color.MediumSlateBlue;
            dateTimePicker2.Font = new Font("Segoe UI", 9F);
            dateTimePicker2.Format = DateTimePickerFormat.Long;
            dateTimePicker2.Location = new Point(473, 9);
            dateTimePicker2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dateTimePicker2.Size = new Size(250, 45);
            dateTimePicker2.TabIndex = 12;
            dateTimePicker2.Value = new DateTime(2024, 11, 12, 18, 42, 49, 384);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker1.Checked = true;
            dateTimePicker1.CustomizableEdges = customizableEdges7;
            dateTimePicker1.FillColor = Color.MediumSlateBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.Location = new Point(85, 9);
            dateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dateTimePicker1.Size = new Size(250, 45);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2024, 11, 12, 18, 42, 49, 384);
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(33, 187);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(565, 555);
            pieChart1.TabIndex = 4;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 772);
            label1.Name = "label1";
            label1.Size = new Size(360, 61);
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
            dataGridView1.Location = new Point(605, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(491, 364);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(665, 772);
            label7.Name = "label7";
            label7.Size = new Size(377, 61);
            label7.TabIndex = 13;
            label7.Text = "Bảng thống kê doanh thu các loại laptop đã bán theo khoảng thời gian đã chọn";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(33, 14);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(34, 33);
            guna2HtmlLabel2.TabIndex = 19;
            guna2HtmlLabel2.Text = "TỪ";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(406, 14);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(50, 33);
            guna2HtmlLabel1.TabIndex = 20;
            guna2HtmlLabel1.Text = "ĐẾN";
            // 
            // HangLaptop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 147, 186);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pieChart1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HangLaptop";
            Size = new Size(1125, 887);
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
