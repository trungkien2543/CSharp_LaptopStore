namespace CSharp_laptop.GUI
{
    partial class QuanLyTaiKhoanGUI
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            artanPanel1 = new ArtanPanel();
            vbButton1 = new VBButton();
            label1 = new Label();
            artanPanel2 = new ArtanPanel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            artanPanel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 20;
            artanPanel1.Controls.Add(vbButton1);
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 30F;
            artanPanel1.GradientBottomColor = Color.FromArgb(85, 81, 132);
            artanPanel1.GradientTopColor = Color.FromArgb(85, 81, 132);
            artanPanel1.Location = new Point(10, 10);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1096, 117);
            artanPanel1.TabIndex = 15;
            artanPanel1.Paint += artanPanel1_Paint_1;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vbButton1.BackColor = Color.FromArgb(247, 176, 118);
            vbButton1.BackgroundColor = Color.FromArgb(247, 176, 118);
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.icons8_add_29;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(939, 34);
            vbButton1.Name = "vbButton1";
            vbButton1.Padding = new Padding(7, 0, 0, 0);
            vbButton1.Size = new Size(129, 52);
            vbButton1.TabIndex = 11;
            vbButton1.Text = "Thêm";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 176, 118);
            label1.Location = new Point(32, 41);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 10;
            label1.Text = "Danh sách tài khoản";
            // 
            // artanPanel2
            // 
            artanPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artanPanel2.BackColor = Color.FromArgb(85, 81, 132);
            artanPanel2.BorderRadius = 10;
            artanPanel2.Controls.Add(dataGridView1);
            artanPanel2.ForeColor = Color.FromArgb(100, 150, 200);
            artanPanel2.GradientAngle = 30F;
            artanPanel2.GradientBottomColor = Color.FromArgb(85, 81, 132);
            artanPanel2.GradientTopColor = Color.FromArgb(85, 81, 132);
            artanPanel2.Location = new Point(10, 133);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Padding = new Padding(4, 0, 4, 15);
            artanPanel2.Size = new Size(1096, 385);
            artanPanel2.TabIndex = 16;
            artanPanel2.Paint += artanPanel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(85, 81, 132);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(85, 81, 132);
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column7, Column8 });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(4, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1088, 370);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.SizeChanged += dataGridView1_SizeChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 50F;
            dataGridViewTextBoxColumn1.HeaderText = "Tên tài khoản";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 80F;
            dataGridViewTextBoxColumn2.HeaderText = "Mật khẩu";
            dataGridViewTextBoxColumn2.MinimumWidth = 9;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.FillWeight = 70F;
            dataGridViewTextBoxColumn3.HeaderText = "Quyền";
            dataGridViewTextBoxColumn3.MinimumWidth = 9;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.FillWeight = 40F;
            Column7.HeaderText = "Sửa";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.FillWeight = 40F;
            Column8.HeaderText = "Xóa";
            Column8.MinimumWidth = 9;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // QuanLyTaiKhoanGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 147, 186);
            ClientSize = new Size(1123, 527);
            Controls.Add(artanPanel2);
            Controls.Add(artanPanel1);
            Name = "QuanLyTaiKhoanGUI";
            Text = "QuanLyTaiKhoanGUI";
            Load += TaiKhoanGUI_Load;
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ArtanPanel artanPanel1;
        private Label label1;
        private VBButton vbButton1;
        private ArtanPanel artanPanel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}