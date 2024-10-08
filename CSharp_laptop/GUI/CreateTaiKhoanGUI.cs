using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class CreateTaiKhoanGUI : Form
    {
        public CreateTaiKhoanGUI()
        {
            InitializeComponent();
        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 0;
            label1.Text = "Tạo Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 1;
            label2.Text = "- Tên Đăng Nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 104);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 2;
            label3.Text = "- Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 145);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "- Quyền:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 23);
            comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Location = new Point(24, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 185);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 84);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Drop here";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(48, 417);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(105, 34);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Enter ";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(362, 417);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(105, 34);
            iconButton2.TabIndex = 9;
            iconButton2.Text = "Cancel";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // CreateTaiKhoanGUI
            // 
            ClientSize = new Size(701, 481);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTaiKhoanGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
