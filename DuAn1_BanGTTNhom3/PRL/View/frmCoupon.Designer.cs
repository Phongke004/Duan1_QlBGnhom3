namespace PRL.View
{
    partial class frmCoupon
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
            dgvCoupon = new DataGridView();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dtpNgayKetThucCoupon = new DateTimePicker();
            dtpNgayBatDauCoupon = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtboxDKCoupon = new TextBox();
            txtboxGiaTriCoupon = new TextBox();
            label8 = new Label();
            txtboxMoTaCoupon = new TextBox();
            txtboxTenCoupon = new TextBox();
            txtboxMaCoupon = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhuyếnMãiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();
            btnThoat = new Button();
            quảnLýCouponToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCoupon).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCoupon
            // 
            dgvCoupon.AllowUserToAddRows = false;
            dgvCoupon.AllowUserToDeleteRows = false;
            dgvCoupon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupon.Location = new Point(6, 32);
            dgvCoupon.Name = "dgvCoupon";
            dgvCoupon.ReadOnly = true;
            dgvCoupon.RowHeadersWidth = 51;
            dgvCoupon.RowTemplate.Height = 29;
            dgvCoupon.Size = new Size(1004, 261);
            dgvCoupon.TabIndex = 0;
            dgvCoupon.CellClick += dgvCoupon_CellClick;
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.Delete;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(6, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 53);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Refresh;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(6, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(172, 53);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(6, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCoupon);
            groupBox3.Location = new Point(12, 479);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1030, 308);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Voucher";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(858, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 384);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(395, 34);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 7;
            label1.Text = "Quản Lý Coupon";
            // 
            // dtpNgayKetThucCoupon
            // 
            dtpNgayKetThucCoupon.Format = DateTimePickerFormat.Short;
            dtpNgayKetThucCoupon.Location = new Point(565, 320);
            dtpNgayKetThucCoupon.Name = "dtpNgayKetThucCoupon";
            dtpNgayKetThucCoupon.Size = new Size(269, 27);
            dtpNgayKetThucCoupon.TabIndex = 12;
            // 
            // dtpNgayBatDauCoupon
            // 
            dtpNgayBatDauCoupon.Format = DateTimePickerFormat.Short;
            dtpNgayBatDauCoupon.Location = new Point(131, 320);
            dtpNgayBatDauCoupon.Name = "dtpNgayBatDauCoupon";
            dtpNgayBatDauCoupon.Size = new Size(269, 27);
            dtpNgayBatDauCoupon.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtboxDKCoupon);
            groupBox1.Controls.Add(txtboxGiaTriCoupon);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayKetThucCoupon);
            groupBox1.Controls.Add(dtpNgayBatDauCoupon);
            groupBox1.Controls.Add(txtboxMoTaCoupon);
            groupBox1.Controls.Add(txtboxTenCoupon);
            groupBox1.Controls.Add(txtboxMaCoupon);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 384);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtboxDKCoupon
            // 
            txtboxDKCoupon.Location = new Point(131, 239);
            txtboxDKCoupon.Name = "txtboxDKCoupon";
            txtboxDKCoupon.Size = new Size(269, 27);
            txtboxDKCoupon.TabIndex = 15;
            // 
            // txtboxGiaTriCoupon
            // 
            txtboxGiaTriCoupon.Location = new Point(131, 156);
            txtboxGiaTriCoupon.Name = "txtboxGiaTriCoupon";
            txtboxGiaTriCoupon.Size = new Size(269, 27);
            txtboxGiaTriCoupon.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 242);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 13;
            label8.Text = "Điều Kiện";
            // 
            // txtboxMoTaCoupon
            // 
            txtboxMoTaCoupon.Location = new Point(565, 199);
            txtboxMoTaCoupon.Name = "txtboxMoTaCoupon";
            txtboxMoTaCoupon.Size = new Size(269, 27);
            txtboxMoTaCoupon.TabIndex = 8;
            // 
            // txtboxTenCoupon
            // 
            txtboxTenCoupon.Location = new Point(565, 73);
            txtboxTenCoupon.Name = "txtboxTenCoupon";
            txtboxTenCoupon.Size = new Size(269, 27);
            txtboxTenCoupon.TabIndex = 7;
            // 
            // txtboxMaCoupon
            // 
            txtboxMaCoupon.Location = new Point(131, 73);
            txtboxMaCoupon.Name = "txtboxMaCoupon";
            txtboxMaCoupon.ReadOnly = true;
            txtboxMaCoupon.Size = new Size(269, 27);
            txtboxMaCoupon.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 325);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 5;
            label7.Text = "Ngày Kết Thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 325);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày Bắt Đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 159);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 3;
            label5.Text = "Giá Trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 202);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 2;
            label4.Text = "Mô Tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 80);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên Coupon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Coupon";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, quảnLýToolStripMenuItem, thêmNhânViênToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1053, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(55, 24);
            userToolStripMenuItem.Text = "User:";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(183, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(183, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, quảnLýKhuyếnMãiToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem, quảnLýCouponToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(224, 26);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(224, 26);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMãiToolStripMenuItem
            // 
            quảnLýKhuyếnMãiToolStripMenuItem.Name = "quảnLýKhuyếnMãiToolStripMenuItem";
            quảnLýKhuyếnMãiToolStripMenuItem.Size = new Size(224, 26);
            quảnLýKhuyếnMãiToolStripMenuItem.Text = "Quản Lý Voucher";
            quảnLýKhuyếnMãiToolStripMenuItem.Click += quảnLýKhuyếnMãiToolStripMenuItem_Click;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(224, 26);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(132, 24);
            thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
            // 
            // btnThoat
            // 
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.Location = new Point(893, 804);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 47);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // quảnLýCouponToolStripMenuItem
            // 
            quảnLýCouponToolStripMenuItem.Name = "quảnLýCouponToolStripMenuItem";
            quảnLýCouponToolStripMenuItem.Size = new Size(224, 26);
            quảnLýCouponToolStripMenuItem.Text = "Coupon";
            quảnLýCouponToolStripMenuItem.Click += quảnLýCouponToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(224, 26);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // frmCoupon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 863);
            Controls.Add(btnThoat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "frmCoupon";
            Text = "frmQLCoupon";
            ((System.ComponentModel.ISupportInitialize)dgvCoupon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoupon;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dtpNgayKetThucCoupon;
        private DateTimePicker dtpNgayBatDauCoupon;
        private GroupBox groupBox1;
        private TextBox txtboxMoTaCoupon;
        private TextBox txtboxTenCoupon;
        private TextBox txtboxMaCoupon;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhuyếnMãiToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private Label label8;
        private TextBox txtboxDKCoupon;
        private TextBox txtboxGiaTriCoupon;
        private Button btnThoat;
        private ToolStripMenuItem quảnLýCouponToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
    }
}