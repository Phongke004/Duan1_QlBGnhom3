namespace PRL.View
{
    partial class frmKhachHang
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
            cbbSearchRank = new ComboBox();
            txtboxSearchSDT = new TextBox();
            label9 = new Label();
            dgvKhachHang = new DataGridView();
            groupBox3 = new GroupBox();
            label8 = new Label();
            txtboxRank = new TextBox();
            txtboxDiem = new TextBox();
            txtboxSDT = new TextBox();
            txtboxMaKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            userToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbSearchRank
            // 
            cbbSearchRank.FormattingEnabled = true;
            cbbSearchRank.Location = new Point(502, 68);
            cbbSearchRank.Name = "cbbSearchRank";
            cbbSearchRank.Size = new Size(275, 28);
            cbbSearchRank.TabIndex = 6;
            // 
            // txtboxSearchSDT
            // 
            txtboxSearchSDT.Location = new Point(42, 69);
            txtboxSearchSDT.Name = "txtboxSearchSDT";
            txtboxSearchSDT.Size = new Size(275, 27);
            txtboxSearchSDT.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(502, 37);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 3;
            label9.Text = "Tìm Theo Xếp Hạng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(6, 109);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(1001, 226);
            dgvKhachHang.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbSearchRank);
            groupBox3.Controls.Add(txtboxSearchSDT);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dgvKhachHang);
            groupBox3.Location = new Point(12, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1013, 340);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu Khách Hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 37);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 2;
            label8.Text = "Tìm Theo SDT";
            // 
            // txtboxRank
            // 
            txtboxRank.Location = new Point(149, 149);
            txtboxRank.Name = "txtboxRank";
            txtboxRank.Size = new Size(247, 27);
            txtboxRank.TabIndex = 9;
            // 
            // txtboxDiem
            // 
            txtboxDiem.Location = new Point(553, 149);
            txtboxDiem.Name = "txtboxDiem";
            txtboxDiem.Size = new Size(247, 27);
            txtboxDiem.TabIndex = 8;
            // 
            // txtboxSDT
            // 
            txtboxSDT.Location = new Point(553, 51);
            txtboxSDT.Name = "txtboxSDT";
            txtboxSDT.Size = new Size(247, 27);
            txtboxSDT.TabIndex = 7;
            // 
            // txtboxMaKH
            // 
            txtboxMaKH.Location = new Point(149, 51);
            txtboxMaKH.Name = "txtboxMaKH";
            txtboxMaKH.ReadOnly = true;
            txtboxMaKH.Size = new Size(247, 27);
            txtboxMaKH.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 152);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Xếp Hạng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 152);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Điểm";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 48);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Clear";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 48);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 48);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 55);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 2;
            label4.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 55);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Khách Hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtboxRank);
            groupBox1.Controls.Add(txtboxDiem);
            groupBox1.Controls.Add(txtboxSDT);
            groupBox1.Controls.Add(txtboxMaKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 246);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(336, 10);
            label1.Name = "label1";
            label1.Size = new Size(361, 50);
            label1.TabIndex = 6;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(55, 24);
            userToolStripMenuItem.Text = "User:";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(824, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(201, 246);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1094, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbSearchRank;
        private TextBox txtboxSearchSDT;
        private Label label9;
        private DataGridView dgvKhachHang;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtboxRank;
        private TextBox txtboxDiem;
        private TextBox txtboxSDT;
        private TextBox txtboxMaKH;
        private Label label6;
        private Label label5;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label4;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
    }
}