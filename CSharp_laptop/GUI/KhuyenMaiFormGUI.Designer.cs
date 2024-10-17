namespace CSharp_laptop.GUI
{
    partial class KhuyenMaiFormGUI
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
            polarChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PolarChart();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // polarChart1
            // 
            polarChart1.Location = new Point(155, 51);
            polarChart1.Name = "polarChart1";
            polarChart1.Size = new Size(8, 8);
            polarChart1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(polarChart1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 90);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(93, 25);
            label1.Name = "label1";
            label1.Size = new Size(398, 46);
            label1.TabIndex = 0;
            label1.Text = "Chương trình khuyến mãi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 136);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên khuyến mãi";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 230);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 4;
            label3.Text = "Mức giảm giá";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 324);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 5;
            label4.Text = "Mô tả khuyến mãi";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 420);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 6;
            label5.Text = "Thời gian bắt đầu";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 515);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 7;
            label6.Text = "Thời gian kết thúc";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 604);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 8;
            label7.Text = "Thời gian tạo";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(56, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(56, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 30);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(56, 366);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 30);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(56, 461);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 30);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(56, 556);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 30);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(56, 646);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(450, 30);
            textBox6.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(132, 721);
            button1.Name = "button1";
            button1.Size = new Size(130, 55);
            button1.TabIndex = 15;
            button1.Text = "Đồng ý";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(295, 721);
            button2.Name = "button2";
            button2.Size = new Size(130, 55);
            button2.TabIndex = 16;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // KhuyenMaiFormGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 803);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "KhuyenMaiFormGUI";
            Text = "Form1";
            Load += KhuyenMaiFormGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PolarChart polarChart1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}