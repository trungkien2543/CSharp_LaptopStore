using System.Globalization;

namespace CSharp_laptop.GUI.NhanVien
{
    partial class CreateNhanVienGUI
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
            rjTextBox1 = new RJTextBox();
            rjTextBox2 = new RJTextBox();
            rjTextBox3 = new RJTextBox();
            rjTextBox4 = new RJTextBox();
            rjTextBox5 = new RJTextBox();
            rjTextBox6 = new RJTextBox();
            vbButton1 = new VBButton();
            vbButton2 = new VBButton();
            rjDatePicker1 = new RJDateTimePicker.RJDatePicker();
            label2 = new Label();
            rjRadioButton1 = new UI_cos.RJRadioButton();
            label3 = new Label();
            rjRadioButton2 = new UI_cos.RJRadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(363, 45);
            label1.TabIndex = 1;
            label1.Text = "🙍 Tạo Nhân Viên Mới";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(58, 97);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "ID Nhân Viên";
            rjTextBox1.Size = new Size(425, 40);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(58, 177);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "Tên Nhân Viên";
            rjTextBox2.Size = new Size(425, 40);
            rjTextBox2.TabIndex = 3;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = SystemColors.Window;
            rjTextBox3.BorderColor = Color.MediumSlateBlue;
            rjTextBox3.BorderFocusColor = Color.HotPink;
            rjTextBox3.BorderRadius = 10;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(58, 257);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "Số Điện Thoại";
            rjTextBox3.Size = new Size(425, 40);
            rjTextBox3.TabIndex = 4;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = SystemColors.Window;
            rjTextBox4.BorderColor = Color.MediumSlateBlue;
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 10;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox4.Location = new Point(58, 337);
            rjTextBox4.Margin = new Padding(4);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "Địa Chỉ";
            rjTextBox4.Size = new Size(425, 40);
            rjTextBox4.TabIndex = 5;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = SystemColors.Window;
            rjTextBox5.BorderColor = Color.MediumSlateBlue;
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 10;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox5.Location = new Point(58, 419);
            rjTextBox5.Margin = new Padding(4);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "Căn Cước Công Dân";
            rjTextBox5.Size = new Size(425, 40);
            rjTextBox5.TabIndex = 6;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            rjTextBox6.BackColor = SystemColors.Window;
            rjTextBox6.BorderColor = Color.MediumSlateBlue;
            rjTextBox6.BorderFocusColor = Color.HotPink;
            rjTextBox6.BorderRadius = 10;
            rjTextBox6.BorderSize = 2;
            rjTextBox6.Font = new Font("Microsoft Sans Serif", 15.75F);
            rjTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox6.Location = new Point(58, 499);
            rjTextBox6.Margin = new Padding(4);
            rjTextBox6.Multiline = false;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DarkGray;
            rjTextBox6.PlaceholderText = "Email";
            rjTextBox6.Size = new Size(425, 40);
            rjTextBox6.TabIndex = 7;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = false;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            vbButton1.BackColor = Color.MediumPurple;
            vbButton1.BackgroundColor = Color.MediumPurple;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 10;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Location = new Point(594, 576);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(138, 55);
            vbButton1.TabIndex = 8;
            vbButton1.Text = "Lưu";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            vbButton2.BackColor = Color.MediumPurple;
            vbButton2.BackgroundColor = Color.MediumPurple;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 10;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Location = new Point(755, 576);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(138, 55);
            vbButton2.TabIndex = 9;
            vbButton2.Text = "Lưun't";
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.BorderColor = Color.PaleVioletRed;
            rjDatePicker1.BorderSize = 0;
            rjDatePicker1.CustomFormat = "dd/MM/yyyy";
            rjDatePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjDatePicker1.Format = DateTimePickerFormat.Custom;
            rjDatePicker1.Location = new Point(698, 97);
            rjDatePicker1.MinimumSize = new Size(0, 40);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(228, 40);
            rjDatePicker1.SkinColor = Color.MediumSlateBlue;
            rjDatePicker1.TabIndex = 10;
            rjDatePicker1.TextColor = Color.White;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(555, 99);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 11;
            label2.Text = "Ngày Sinh:";
            // 
            // rjRadioButton1
            // 
            rjRadioButton1.AutoSize = true;
            rjRadioButton1.CheckedColor = Color.MediumSlateBlue;
            rjRadioButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjRadioButton1.ForeColor = SystemColors.ButtonShadow;
            rjRadioButton1.Location = new Point(6, 13);
            rjRadioButton1.MinimumSize = new Size(0, 21);
            rjRadioButton1.Name = "rjRadioButton1";
            rjRadioButton1.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton1.Size = new Size(88, 34);
            rjRadioButton1.TabIndex = 12;
            rjRadioButton1.TabStop = true;
            rjRadioButton1.Text = "Nam";
            rjRadioButton1.UnCheckedColor = Color.Gray;
            rjRadioButton1.UseVisualStyleBackColor = true;
            rjRadioButton1.CheckedChanged += rjRadioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumPurple;
            label3.Location = new Point(555, 177);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 13;
            label3.Text = "Giới Tính:";
            // 
            // rjRadioButton2
            // 
            rjRadioButton2.AutoSize = true;
            rjRadioButton2.CheckedColor = Color.MediumSlateBlue;
            rjRadioButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjRadioButton2.ForeColor = SystemColors.ButtonShadow;
            rjRadioButton2.Location = new Point(113, 13);
            rjRadioButton2.MinimumSize = new Size(0, 21);
            rjRadioButton2.Name = "rjRadioButton2";
            rjRadioButton2.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton2.Size = new Size(72, 34);
            rjRadioButton2.TabIndex = 14;
            rjRadioButton2.TabStop = true;
            rjRadioButton2.Text = "Nữ";
            rjRadioButton2.UnCheckedColor = Color.Gray;
            rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rjRadioButton2);
            groupBox1.Controls.Add(rjRadioButton1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(698, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 52);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // CreateNhanVienGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 667);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rjDatePicker1);
            Controls.Add(rjTextBox1);
            Controls.Add(rjTextBox2);
            Controls.Add(vbButton2);
            Controls.Add(rjTextBox3);
            Controls.Add(vbButton1);
            Controls.Add(rjTextBox4);
            Controls.Add(label1);
            Controls.Add(rjTextBox6);
            Controls.Add(rjTextBox5);
            Name = "CreateNhanVienGUI";
            Text = "CreateNhanVienGUI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RJTextBox rjTextBox1;
        private RJTextBox rjTextBox2;
        private RJTextBox rjTextBox3;
        private RJTextBox rjTextBox4;
        private RJTextBox rjTextBox5;
        private RJTextBox rjTextBox6;
        private VBButton vbButton1;
        private VBButton vbButton2;
        private RJDateTimePicker.RJDatePicker rjDatePicker1;
        private Label label2;
        private UI_cos.RJRadioButton rjRadioButton1;
        private Label label3;
        private UI_cos.RJRadioButton rjRadioButton2;
        private GroupBox groupBox1;
    }
}