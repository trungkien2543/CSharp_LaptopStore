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
            label1 = new Label();
            label2 = new Label();
            ccbYear = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
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
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.AutoScroll = true;
            cartesianChart1.Cursor = Cursors.Hand;
            cartesianChart1.Location = new Point(0, 161);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1093, 722);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(461, 41);
            label1.TabIndex = 1;
            label1.Text = "Thống kê doanh thu theo tháng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 112);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn năm :";
            label2.Click += label2_Click;
            // 
            // ccbYear
            // 
            ccbYear.FormattingEnabled = true;
            ccbYear.Location = new Point(172, 107);
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
            tabPage1.Controls.Add(cartesianChart1);
            tabPage1.Controls.Add(ccbYear);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1099, 889);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh thu";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(600, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(491, 652);
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
            pieChart1.Size = new Size(565, 610);
            pieChart1.TabIndex = 3;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 48);
            label3.Name = "label3";
            label3.Size = new Size(527, 41);
            label3.TabIndex = 2;
            label3.Text = "Thống kê số lượng laptop theo hãng";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
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
    }
}