﻿namespace PRL.View
{
    partial class frmMenuNV
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
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnCoupon = new Button();
            btnVoucher = new Button();
            btnKhachHang = new Button();
            btnPoint = new Button();
            btnHoaDon = new Button();
            btnSanPham = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1116, 28);
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
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCoupon);
            groupBox1.Controls.Add(btnVoucher);
            groupBox1.Controls.Add(btnKhachHang);
            groupBox1.Controls.Add(btnPoint);
            groupBox1.Controls.Add(btnHoaDon);
            groupBox1.Controls.Add(btnSanPham);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 610);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnCoupon
            // 
            btnCoupon.Location = new Point(6, 446);
            btnCoupon.Name = "btnCoupon";
            btnCoupon.Size = new Size(322, 53);
            btnCoupon.TabIndex = 5;
            btnCoupon.Text = "Coupon";
            btnCoupon.UseVisualStyleBackColor = true;
            // 
            // btnVoucher
            // 
            btnVoucher.Location = new Point(6, 341);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(322, 53);
            btnVoucher.TabIndex = 4;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(6, 551);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(322, 53);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(6, 236);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(322, 53);
            btnPoint.TabIndex = 2;
            btnPoint.Text = "Điểm";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(6, 131);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(322, 53);
            btnHoaDon.TabIndex = 1;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Location = new Point(6, 26);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(322, 53);
            btnSanPham.TabIndex = 0;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ronaldocamgiay;
            pictureBox1.Location = new Point(352, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(752, 604);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 653);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuNV";
            Text = "frmMenuNV";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnHoaDon;
        private Button btnSanPham;
        private PictureBox pictureBox1;
        private Button btnKhachHang;
        private Button btnPoint;
        private Button btnCoupon;
        private Button btnVoucher;
    }
}