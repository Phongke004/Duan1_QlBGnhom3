﻿namespace PRL.View
{
    partial class frmDoiTra
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
            menuStrip1 = new MenuStrip();
            chứcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhuyếnMạiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            dgtView = new DataGridView();
            btnXem = new Button();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            txtMaHD = new TextBox();
            label4 = new Label();
            txtMaSp = new TextBox();
            txtMaNv = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnDoiHang = new Button();
            grb = new GroupBox();
            txtSearch = new TextBox();
            btnTra = new Button();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtView).BeginInit();
            groupBox3.SuspendLayout();
            grb.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(298, 43);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 0;
            label1.Text = "Quản lý đổi trả";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcToolStripMenuItem, thêmNhânViênToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcToolStripMenuItem
            // 
            chứcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem, quảnLýKhuyếnMạiToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem });
            chứcToolStripMenuItem.Name = "chứcToolStripMenuItem";
            chứcToolStripMenuItem.Size = new Size(93, 24);
            chứcToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(221, 26);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(221, 26);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMạiToolStripMenuItem
            // 
            quảnLýKhuyếnMạiToolStripMenuItem.Name = "quảnLýKhuyếnMạiToolStripMenuItem";
            quảnLýKhuyếnMạiToolStripMenuItem.Size = new Size(221, 26);
            quảnLýKhuyếnMạiToolStripMenuItem.Text = "Quản lý khuyến mại";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(221, 26);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(221, 26);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(221, 26);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(127, 24);
            thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(63, 24);
            userToolStripMenuItem.Text = "User : ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(181, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(181, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgtView);
            groupBox2.Location = new Point(27, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 311);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgtView
            // 
            dgtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtView.Location = new Point(30, 26);
            dgtView.Name = "dgtView";
            dgtView.RowHeadersWidth = 51;
            dgtView.RowTemplate.Height = 29;
            dgtView.Size = new Size(749, 265);
            dgtView.TabIndex = 0;
            dgtView.CellClick += dgtView_CellClick;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(587, 630);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(92, 47);
            btnXem.TabIndex = 4;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(712, 630);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 47);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMaHD);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtMaSp);
            groupBox3.Controls.Add(txtMaNv);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(27, 97);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(346, 178);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(154, 109);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(125, 27);
            txtMaHD.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã hóa đơn";
            // 
            // txtMaSp
            // 
            txtMaSp.Location = new Point(154, 64);
            txtMaSp.Name = "txtMaSp";
            txtMaSp.Size = new Size(125, 27);
            txtMaSp.TabIndex = 3;
            // 
            // txtMaNv
            // 
            txtMaNv.Location = new Point(154, 26);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(125, 27);
            txtMaNv.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 71);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 33);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // btnDoiHang
            // 
            btnDoiHang.Location = new Point(121, 126);
            btnDoiHang.Name = "btnDoiHang";
            btnDoiHang.Size = new Size(120, 38);
            btnDoiHang.TabIndex = 2;
            btnDoiHang.Text = "Đổi hàng";
            btnDoiHang.UseVisualStyleBackColor = true;
            btnDoiHang.Click += btnThem_Click;
            // 
            // grb
            // 
            grb.Controls.Add(btnTra);
            grb.Controls.Add(txtSearch);
            grb.Controls.Add(btnDoiHang);
            grb.Location = new Point(396, 97);
            grb.Name = "grb";
            grb.Size = new Size(430, 192);
            grb.TabIndex = 7;
            grb.TabStop = false;
            grb.Text = "Chức năng";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(15, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã hóa đơn để tìm kiếm";
            txtSearch.Size = new Size(312, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnTra
            // 
            btnTra.Location = new Point(290, 126);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(120, 38);
            btnTra.TabIndex = 3;
            btnTra.Text = "Trả hàng";
            btnTra.UseVisualStyleBackColor = true;
            // 
            // frmDoiTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 689);
            Controls.Add(grb);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnXem);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDoiTra";
            Text = "frmDoiTra";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgtView).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grb.ResumeLayout(false);
            grb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhuyếnMạiToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private GroupBox groupBox2;
        private DataGridView dgtView;
        private Button btnXem;
        private Button btnThoat;
        private GroupBox groupBox3;
        private TextBox txtMaHD;
        private Label label4;
        private TextBox txtMaSp;
        private TextBox txtMaNv;
        private Label label3;
        private Label label2;
        private Button btnDoiHang;
        private GroupBox grb;
        private TextBox txtSearch;
        private Button btnTra;
    }
}