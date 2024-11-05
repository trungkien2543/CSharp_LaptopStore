namespace CSharp_laptop.GUI
{
    partial class ThongKe
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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label2 = new Label();
            ccbYear = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            lbThongKe = new Label();
            ccbMonth = new ComboBox();
            lblMonth = new Label();
            ccbType = new ComboBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnLoc = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.AutoScroll = true;
            cartesianChart1.Cursor = Cursors.Hand;
            cartesianChart1.Location = new Point(16, 170);
            cartesianChart1.Margin = new Padding(5, 5, 5, 5);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1057, 657);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn năm :";
            label2.Click += label2_Click;
            // 
            // ccbYear
            // 
            ccbYear.FormattingEnabled = true;
            ccbYear.Location = new Point(494, 113);
            ccbYear.Name = "ccbYear";
            ccbYear.Size = new Size(151, 28);
            ccbYear.TabIndex = 3;
            ccbYear.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1107, 922);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(ccbMonth);
            tabPage1.Controls.Add(lblMonth);
            tabPage1.Controls.Add(ccbType);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(cartesianChart1);
            tabPage1.Controls.Add(ccbYear);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1099, 889);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh thu";
            tabPage1.Click += tabPage1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbThongKe);
            panel1.Location = new Point(6, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 72);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint_1;
            // 
            // lbThongKe
            // 
            lbThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbThongKe.AutoSize = true;
            lbThongKe.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongKe.ForeColor = Color.FromArgb(0, 0, 192);
            lbThongKe.Location = new Point(426, 16);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(363, 37);
            lbThongKe.TabIndex = 1;
            lbThongKe.Text = "THỐNG KÊ DOANH THU\r\n";
            lbThongKe.TextAlign = ContentAlignment.MiddleCenter;
            lbThongKe.Click += label1_Click;
            // 
            // ccbMonth
            // 
            ccbMonth.FormattingEnabled = true;
            ccbMonth.Location = new Point(802, 112);
            ccbMonth.Name = "ccbMonth";
            ccbMonth.Size = new Size(151, 28);
            ccbMonth.TabIndex = 7;
            ccbMonth.SelectedIndexChanged += ccbMonth_SelectedIndexChanged;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(686, 114);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(110, 23);
            lblMonth.TabIndex = 6;
            lblMonth.Text = "Chọn tháng :";
            // 
            // ccbType
            // 
            ccbType.FormattingEnabled = true;
            ccbType.Location = new Point(210, 113);
            ccbType.Name = "ccbType";
            ccbType.Size = new Size(151, 28);
            ccbType.TabIndex = 5;
            ccbType.SelectedIndexChanged += ccbType_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 114);
            label6.Name = "label6";
            label6.Size = new Size(161, 23);
            label6.TabIndex = 4;
            label6.Text = "Chọn loại thống kê:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnLoc);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(pieChart1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1099, 889);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán chạy";
            tabPage2.Click += tabPage2_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(676, 791);
            label7.Name = "label7";
            label7.Size = new Size(377, 61);
            label7.TabIndex = 11;
            label7.Text = "Bảng thống kê doanh thu các loại laptop đã bán theo khoảng thời gian đã chọn";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 791);
            label1.Name = "label1";
            label1.Size = new Size(360, 61);
            label1.TabIndex = 10;
            label1.Text = "Biểu đồ tròn thống kê các loại laptop đã bán theo khoảng thời gian đã chọn";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(600, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(491, 364);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(874, 157);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(100, 37);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "LỌC";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(537, 164);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(476, 160);
            label5.Name = "label5";
            label5.Size = new Size(55, 31);
            label5.TabIndex = 6;
            label5.Text = "Đến";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 156);
            label4.Name = "label4";
            label4.Size = new Size(46, 31);
            label4.TabIndex = 5;
            label4.Text = "Từ ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(29, 234);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(565, 554);
            pieChart1.TabIndex = 3;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(376, 62);
            label3.Name = "label3";
            label3.Size = new Size(479, 37);
            label3.TabIndex = 2;
            label3.Text = "Thống kê laptop theo hãng";
            label3.Click += label3_Click;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 919);
            Controls.Add(tabControl1);
            Name = "ThongKe";
            Text = "ThongKe";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label2;
        private ComboBox ccbYear;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnLoc;
        private DataGridView dataGridView1;
        private ComboBox ccbMonth;
        private Label lblMonth;
        private ComboBox ccbType;
        private Label label6;
        private Panel panel1;
        private Label lbThongKe;
        private Label label1;
        private Label label7;
    }
}