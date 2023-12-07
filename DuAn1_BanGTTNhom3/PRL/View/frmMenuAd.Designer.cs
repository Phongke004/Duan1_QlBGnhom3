namespace PRL.View
{
    partial class frmMenuAd
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
            PictureBox pictureBox1;
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnThongKe = new Button();
            btnQLCoupon = new Button();
            btnQLVoucher = new Button();
            btnQLHD = new Button();
            btnQLKH = new Button();
            btnQLNV = new Button();
            btnQLSP = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ronaldocamgiay;
            pictureBox1.Location = new Point(238, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(748, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(998, 28);
            menuStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(btnQLCoupon);
            groupBox1.Controls.Add(btnQLVoucher);
            groupBox1.Controls.Add(btnQLHD);
            groupBox1.Controls.Add(btnQLKH);
            groupBox1.Controls.Add(btnQLNV);
            groupBox1.Controls.Add(btnQLSP);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 610);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnThongKe
            // 
            btnThongKe.Image = Properties.Resources.Statistics;
            btnThongKe.ImageAlign = ContentAlignment.MiddleRight;
            btnThongKe.Location = new Point(6, 492);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(208, 53);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnQLCoupon
            // 
            btnQLCoupon.Image = Properties.Resources.copy;
            btnQLCoupon.ImageAlign = ContentAlignment.MiddleRight;
            btnQLCoupon.Location = new Point(6, 401);
            btnQLCoupon.Name = "btnQLCoupon";
            btnQLCoupon.Size = new Size(208, 53);
            btnQLCoupon.TabIndex = 5;
            btnQLCoupon.Text = "Quản Lý Coupon";
            btnQLCoupon.UseVisualStyleBackColor = true;
            btnQLCoupon.Click += btnQLCoupon_Click;
            // 
            // btnQLVoucher
            // 
            btnQLVoucher.Image = Properties.Resources.copy;
            btnQLVoucher.ImageAlign = ContentAlignment.MiddleRight;
            btnQLVoucher.Location = new Point(6, 326);
            btnQLVoucher.Name = "btnQLVoucher";
            btnQLVoucher.Size = new Size(208, 53);
            btnQLVoucher.TabIndex = 4;
            btnQLVoucher.Text = "Quản Lý Voucher";
            btnQLVoucher.UseVisualStyleBackColor = true;
            btnQLVoucher.Click += btnQLVoucher_Click;
            // 
            // btnQLHD
            // 
            btnQLHD.Image = Properties.Resources.Price_list;
            btnQLHD.ImageAlign = ContentAlignment.MiddleRight;
            btnQLHD.Location = new Point(6, 251);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(208, 53);
            btnQLHD.TabIndex = 3;
            btnQLHD.Text = "Quản Lý Hóa Đơn";
            btnQLHD.UseVisualStyleBackColor = true;
            btnQLHD.Click += btnQLHD_Click;
            // 
            // btnQLKH
            // 
            btnQLKH.Image = Properties.Resources.User;
            btnQLKH.ImageAlign = ContentAlignment.MiddleRight;
            btnQLKH.Location = new Point(6, 176);
            btnQLKH.Name = "btnQLKH";
            btnQLKH.Size = new Size(208, 53);
            btnQLKH.TabIndex = 2;
            btnQLKH.Text = "Quản Lý Khách Hàng";
            btnQLKH.UseVisualStyleBackColor = true;
            btnQLKH.Click += btnQLKH_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.Image = Properties.Resources.Users;
            btnQLNV.ImageAlign = ContentAlignment.MiddleRight;
            btnQLNV.Location = new Point(6, 101);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(208, 53);
            btnQLNV.TabIndex = 1;
            btnQLNV.Text = "Quản Lý Nhân Viên";
            btnQLNV.UseVisualStyleBackColor = true;
            btnQLNV.Click += btnQLNV_Click;
            // 
            // btnQLSP
            // 
            btnQLSP.Image = Properties.Resources.Numbered_list;
            btnQLSP.ImageAlign = ContentAlignment.MiddleRight;
            btnQLSP.Location = new Point(6, 26);
            btnQLSP.Name = "btnQLSP";
            btnQLSP.Size = new Size(208, 53);
            btnQLSP.TabIndex = 0;
            btnQLSP.Text = "Quản Lý Sản Phẩm";
            btnQLSP.UseVisualStyleBackColor = true;
            btnQLSP.Click += btnQLSP_Click;
            // 
            // frmMenuAd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 653);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuAd";
            Text = "frmMenuAd";
            Load += frmMenuAd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnQLSP;
        private Button btnQLCoupon;
        private Button btnQLVoucher;
        private Button btnQLHD;
        private Button btnQLKH;
        private Button btnQLNV;
        private Button btnThongKe;
    }
}