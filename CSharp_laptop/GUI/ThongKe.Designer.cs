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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.AutoScroll = true;
            cartesianChart1.Location = new Point(21, 203);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1099, 659);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 45);
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
            label2.Location = new Point(96, 147);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn năm :";
            label2.Click += label2_Click;
            // 
            // ccbYear
            // 
            ccbYear.FormattingEnabled = true;
            ccbYear.Location = new Point(212, 146);
            ccbYear.Name = "ccbYear";
            ccbYear.Size = new Size(151, 28);
            ccbYear.TabIndex = 3;
            ccbYear.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 

            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ccbYear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cartesianChart1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 897);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1152, 897);
            Controls.Add(panel1);
            Name = "ThongKe";
            Text = "ThongKe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
        private Label label2;
        private ComboBox ccbYear;
        private Panel panel1;
    }
}