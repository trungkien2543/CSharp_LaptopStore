namespace CSharp_laptop.GUI
{
    partial class EditHangGUI
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
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 42);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 1;
            label1.Text = "Chi tiết hãng";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(170, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 33);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(170, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 33);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(170, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 33);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 297);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 15;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 235);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 14;
            label3.Text = "Tên hãng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 170);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 13;
            label2.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(170, 350);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 33);
            textBox4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 358);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 19;
            label5.Text = "SĐT";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 118, 176);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(44, 39);
            button1.Name = "button1";
            button1.Size = new Size(127, 51);
            button1.TabIndex = 21;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(202, 39);
            button2.Name = "button2";
            button2.Size = new Size(127, 51);
            button2.TabIndex = 22;
            button2.Text = "Đóng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 118, 176);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 124);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-1, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 124);
            panel2.TabIndex = 24;
            // 
            // EditHangGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditHangGUI";
            Text = "ThemHangGUI";
            Load += EditHangGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}