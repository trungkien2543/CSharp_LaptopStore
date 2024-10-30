namespace CSharp_laptop.GUI
{
    partial class HangGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            vbButton1 = new VBButton();
            rjTextBox1 = new RJTextBox();
            artanPanel2 = new ArtanPanel();
            dataGridView2 = new DataGridView();
            vbButton2 = new VBButton();
            artanPanel1 = new ArtanPanel();
            label2 = new Label();
            panel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            artanPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(rjTextBox1);
            panel1.Controls.Add(artanPanel2);
            panel1.Controls.Add(vbButton2);
            panel1.Controls.Add(artanPanel1);
            panel1.Location = new Point(0, 3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1736, 1173);
            panel1.TabIndex = 4;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.FromArgb(249, 118, 176);
            vbButton1.BackgroundColor = Color.FromArgb(249, 118, 176);
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.icons8_add_29;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(1532, 291);
            vbButton1.Margin = new Padding(4, 5, 4, 5);
            vbButton1.Name = "vbButton1";
            vbButton1.Padding = new Padding(10, 0, 0, 0);
            vbButton1.Size = new Size(176, 97);
            vbButton1.TabIndex = 10;
            vbButton1.Text = "Thêm";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.PaleTurquoise;
            rjTextBox1.BorderFocusColor = SystemColors.HotTrack;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(17, 298);
            rjTextBox1.Margin = new Padding(6, 7, 6, 7);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(14, 12, 14, 12);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(410, 58);
            rjTextBox1.TabIndex = 35;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 10;
            artanPanel2.Controls.Add(dataGridView2);
            artanPanel2.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.FromArgb(249, 118, 176);
            artanPanel2.GradientTopColor = Color.PaleTurquoise;
            artanPanel2.Location = new Point(17, 398);
            artanPanel2.Margin = new Padding(4, 5, 4, 5);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Padding = new Padding(6, 0, 6, 25);
            artanPanel2.Size = new Size(1710, 767);
            artanPanel2.TabIndex = 12;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(6, 0);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1698, 742);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // vbButton2
            // 
            vbButton2.BackColor = Color.PaleTurquoise;
            vbButton2.BackgroundColor = Color.PaleTurquoise;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = Properties.Resources.icons8_find_29;
            vbButton2.Location = new Point(467, 291);
            vbButton2.Margin = new Padding(4, 5, 4, 5);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(100, 65);
            vbButton2.TabIndex = 9;
            vbButton2.TextColor = Color.White;
            vbButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(label2);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(249, 118, 176);
            artanPanel1.GradientTopColor = Color.PaleTurquoise;
            artanPanel1.Location = new Point(17, 17);
            artanPanel1.Margin = new Padding(4, 5, 4, 5);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1706, 235);
            artanPanel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Light SemiCondensed", 35F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(648, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(401, 84);
            label2.TabIndex = 15;
            label2.Text = "Quản lý hãng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HangGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 1178);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HangGUI";
            Text = "HangGUI";
            panel1.ResumeLayout(false);
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Panel panel1;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private ArtanPanel artanPanel1;
        private RJTextBox rjTextBox1;
        private ArtanPanel artanPanel2;
        private DataGridView dataGridView2;
        private Label label2;
    }
}