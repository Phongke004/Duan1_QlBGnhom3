namespace PRL.View
{
    partial class frmQLSP
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
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhuyếnMãiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            couponToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbbThuongHieu = new ComboBox();
            cbbChatLieu = new ComboBox();
            cbbSize = new ComboBox();
            cbbColor = new ComboBox();
            txtboxGiaTien = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            rbtnHetHang = new RadioButton();
            rbtnConHang = new RadioButton();
            txtboxSoLuong = new TextBox();
            txtboxNameSP = new TextBox();
            txtboxIDSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpNgayNhap = new DateTimePicker();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvSanPham = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1711, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýKhuyếnMãiToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem, couponToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(121, 36);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(361, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMãiToolStripMenuItem
            // 
            quảnLýKhuyếnMãiToolStripMenuItem.Name = "quảnLýKhuyếnMãiToolStripMenuItem";
            quảnLýKhuyếnMãiToolStripMenuItem.Size = new Size(361, 44);
            quảnLýKhuyếnMãiToolStripMenuItem.Text = "Quản Lý Voucher";
            quảnLýKhuyếnMãiToolStripMenuItem.Click += quảnLýKhuyếnMãiToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(361, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(361, 44);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(361, 44);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // couponToolStripMenuItem
            // 
            couponToolStripMenuItem.Name = "couponToolStripMenuItem";
            couponToolStripMenuItem.Size = new Size(361, 44);
            couponToolStripMenuItem.Text = "Coupon";
            couponToolStripMenuItem.Click += couponToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(86, 36);
            userToolStripMenuItem.Text = "User:";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(294, 44);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(294, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(647, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(592, 73);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Sản Phẩm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbThuongHieu);
            groupBox1.Controls.Add(cbbChatLieu);
            groupBox1.Controls.Add(cbbSize);
            groupBox1.Controls.Add(cbbColor);
            groupBox1.Controls.Add(txtboxGiaTien);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rbtnHetHang);
            groupBox1.Controls.Add(rbtnConHang);
            groupBox1.Controls.Add(txtboxSoLuong);
            groupBox1.Controls.Add(txtboxNameSP);
            groupBox1.Controls.Add(txtboxIDSP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Location = new Point(21, 133);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1370, 614);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // cbbThuongHieu
            // 
            cbbThuongHieu.FormattingEnabled = true;
            cbbThuongHieu.Location = new Point(920, 418);
            cbbThuongHieu.Margin = new Padding(5, 5, 5, 5);
            cbbThuongHieu.Name = "cbbThuongHieu";
            cbbThuongHieu.Size = new Size(438, 40);
            cbbThuongHieu.TabIndex = 24;
            // 
            // cbbChatLieu
            // 
            cbbChatLieu.FormattingEnabled = true;
            cbbChatLieu.Location = new Point(228, 418);
            cbbChatLieu.Margin = new Padding(5, 5, 5, 5);
            cbbChatLieu.Name = "cbbChatLieu";
            cbbChatLieu.Size = new Size(438, 40);
            cbbChatLieu.TabIndex = 23;
            // 
            // cbbSize
            // 
            cbbSize.FormattingEnabled = true;
            cbbSize.Location = new Point(920, 304);
            cbbSize.Margin = new Padding(5, 5, 5, 5);
            cbbSize.Name = "cbbSize";
            cbbSize.Size = new Size(438, 40);
            cbbSize.TabIndex = 22;
            // 
            // cbbColor
            // 
            cbbColor.FormattingEnabled = true;
            cbbColor.Location = new Point(228, 299);
            cbbColor.Margin = new Padding(5, 5, 5, 5);
            cbbColor.Name = "cbbColor";
            cbbColor.Size = new Size(438, 40);
            cbbColor.TabIndex = 21;
            // 
            // txtboxGiaTien
            // 
            txtboxGiaTien.Location = new Point(228, 538);
            txtboxGiaTien.Margin = new Padding(5, 5, 5, 5);
            txtboxGiaTien.Name = "txtboxGiaTien";
            txtboxGiaTien.Size = new Size(438, 39);
            txtboxGiaTien.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(115, 542);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 32);
            label11.TabIndex = 15;
            label11.Text = "Giá Tiền";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(756, 422);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(154, 32);
            label10.TabIndex = 14;
            label10.Text = "Thương Hiệu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(104, 422);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(114, 32);
            label9.TabIndex = 13;
            label9.Text = "Chất Liệu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(852, 304);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 32);
            label8.TabIndex = 12;
            label8.Text = "Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 304);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 11;
            label7.Text = "Màu Sắc";
            // 
            // rbtnHetHang
            // 
            rbtnHetHang.AutoSize = true;
            rbtnHetHang.Location = new Point(1207, 539);
            rbtnHetHang.Margin = new Padding(5, 5, 5, 5);
            rbtnHetHang.Name = "rbtnHetHang";
            rbtnHetHang.Size = new Size(147, 36);
            rbtnHetHang.TabIndex = 10;
            rbtnHetHang.TabStop = true;
            rbtnHetHang.Text = "Hết Hàng";
            rbtnHetHang.UseVisualStyleBackColor = true;
            // 
            // rbtnConHang
            // 
            rbtnConHang.AutoSize = true;
            rbtnConHang.Location = new Point(920, 539);
            rbtnConHang.Margin = new Padding(5, 5, 5, 5);
            rbtnConHang.Name = "rbtnConHang";
            rbtnConHang.Size = new Size(152, 36);
            rbtnConHang.TabIndex = 9;
            rbtnConHang.TabStop = true;
            rbtnConHang.Text = "Còn Hàng";
            rbtnConHang.UseVisualStyleBackColor = true;
            // 
            // txtboxSoLuong
            // 
            txtboxSoLuong.Location = new Point(920, 181);
            txtboxSoLuong.Margin = new Padding(5, 5, 5, 5);
            txtboxSoLuong.Name = "txtboxSoLuong";
            txtboxSoLuong.Size = new Size(438, 39);
            txtboxSoLuong.TabIndex = 8;
            // 
            // txtboxNameSP
            // 
            txtboxNameSP.Location = new Point(920, 62);
            txtboxNameSP.Margin = new Padding(5, 5, 5, 5);
            txtboxNameSP.Name = "txtboxNameSP";
            txtboxNameSP.Size = new Size(438, 39);
            txtboxNameSP.TabIndex = 7;
            // 
            // txtboxIDSP
            // 
            txtboxIDSP.Location = new Point(228, 62);
            txtboxIDSP.Margin = new Padding(5, 5, 5, 5);
            txtboxIDSP.Name = "txtboxIDSP";
            txtboxIDSP.ReadOnly = true;
            txtboxIDSP.Size = new Size(438, 39);
            txtboxIDSP.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 542);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 5;
            label6.Text = "Trạng Thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(793, 186);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 4;
            label5.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 186);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 3;
            label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 67);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 2;
            label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 67);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 1;
            label2.Text = "Mã Sản Phẩm";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(228, 178);
            dtpNgayNhap.Margin = new Padding(5, 5, 5, 5);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(438, 39);
            dtpNgayNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(1399, 133);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(299, 614);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.Delete;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(10, 480);
            btnClear.Margin = new Padding(5, 5, 5, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(280, 85);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Refresh;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(10, 261);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(280, 85);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(10, 42);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 85);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPham);
            groupBox3.Location = new Point(10, 757);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(1679, 478);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Sản Phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(10, 42);
            dgvSanPham.Margin = new Padding(5, 5, 5, 5);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 29;
            dgvSanPham.Size = new Size(1659, 427);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // frmQLSP
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1254);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmQLSP";
            Text = "frmQLSP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhuyếnMãiToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayNhap;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvSanPham;
        private RadioButton rbtnHetHang;
        private RadioButton rbtnConHang;
        private TextBox txtboxSoLuong;
        private TextBox txtboxNameSP;
        private TextBox txtboxIDSP;
        private Label label6;
        private Label label5;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtboxGiaTien;
        private ComboBox cbbColor;
        private ComboBox cbbThuongHieu;
        private ComboBox cbbChatLieu;
        private ComboBox cbbSize;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem couponToolStripMenuItem;
    }
}