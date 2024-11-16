namespace CSharp_laptop.GUI
{
    partial class DangNhapGUI
    {
        private const char V = '\u25CF';

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapGUI));
            label1 = new Label();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMini = new FontAwesome.Sharp.IconButton();
            btnZoom = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            vbButton1 = new VBButton();
            rjTextBox1 = new RJTextBox();
            rjTextBox2 = new RJTextBox();
            pictureBox1 = new PictureBox();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(540, 187);
            label1.Name = "label1";
            label1.Size = new Size(611, 83);
            label1.TabIndex = 8;
            label1.Text = " Classy Login Form";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1335, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(1, 10, 0, 10);
            btnExit.Size = new Size(34, 22);
            btnExit.TabIndex = 15;
            btnExit.TabStop = false;
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMini
            // 
            btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.ForeColor = Color.Gainsboro;
            btnMini.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMini.IconColor = Color.Gainsboro;
            btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMini.IconSize = 20;
            btnMini.ImageAlign = ContentAlignment.MiddleLeft;
            btnMini.Location = new Point(1266, 0);
            btnMini.Margin = new Padding(0);
            btnMini.Name = "btnMini";
            btnMini.Padding = new Padding(3, 10, 0, 10);
            btnMini.Size = new Size(34, 22);
            btnMini.TabIndex = 14;
            btnMini.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMini.UseVisualStyleBackColor = true;
            btnMini.Click += btnMini_Click;
            // 
            // btnZoom
            // 
            btnZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoom.FlatAppearance.BorderSize = 0;
            btnZoom.FlatStyle = FlatStyle.Flat;
            btnZoom.ForeColor = Color.Gainsboro;
            btnZoom.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnZoom.IconColor = Color.Gainsboro;
            btnZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnZoom.IconSize = 20;
            btnZoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnZoom.Location = new Point(1300, 0);
            btnZoom.Margin = new Padding(0);
            btnZoom.Name = "btnZoom";
            btnZoom.Padding = new Padding(3, 10, 0, 10);
            btnZoom.Size = new Size(34, 22);
            btnZoom.TabIndex = 13;
            btnZoom.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(iconButton1);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(iconButton2);
            panelTitleBar.Controls.Add(btnMini);
            panelTitleBar.Controls.Add(iconButton3);
            panelTitleBar.Controls.Add(btnZoom);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1369, 34);
            panelTitleBar.TabIndex = 16;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(2268, 0);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(1, 10, 0, 10);
            iconButton1.Size = new Size(34, 22);
            iconButton1.TabIndex = 6;
            iconButton1.TabStop = false;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(2199, 0);
            iconButton2.Margin = new Padding(0);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(3, 10, 0, 10);
            iconButton2.Size = new Size(34, 22);
            iconButton2.TabIndex = 5;
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(2233, 0);
            iconButton3.Margin = new Padding(0);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(3, 10, 0, 10);
            iconButton3.Size = new Size(34, 22);
            iconButton3.TabIndex = 4;
            iconButton3.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ButtonFace;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(971, 438);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(137, 21);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(623, 310);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 39);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(623, 382);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 39);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.SlateGray;
            vbButton1.BackgroundColor = Color.SlateGray;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 5;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.Transparent;
            vbButton1.Location = new Point(708, 485);
            vbButton1.Margin = new Padding(3, 2, 3, 2);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(400, 38);
            vbButton1.TabIndex = 20;
            vbButton1.Text = "Login";
            vbButton1.TextColor = Color.Transparent;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.White;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(708, 310);
            rjTextBox1.Margin = new Padding(4, 3, 4, 3);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(9, 5, 9, 5);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkCyan;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(400, 37);
            rjTextBox1.TabIndex = 21;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.Transparent;
            rjTextBox2.BorderFocusColor = Color.White;
            rjTextBox2.BorderRadius = 5;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(708, 386);
            rjTextBox2.Margin = new Padding(4, 3, 4, 3);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(9, 5, 9, 5);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkCyan;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(400, 37);
            rjTextBox2.TabIndex = 22;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_home_removebg;
            pictureBox1.Location = new Point(8, 18);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 706);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DangNhapGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1369, 825);
            Controls.Add(rjTextBox2);
            Controls.Add(rjTextBox1);
            Controls.Add(vbButton1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(panelTitleBar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhapGUI";
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnZoom;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private VBButton vbButton1;
        private RJTextBox rjTextBox1;
        private RJTextBox rjTextBox2;
        private PictureBox pictureBox1;
    }
}