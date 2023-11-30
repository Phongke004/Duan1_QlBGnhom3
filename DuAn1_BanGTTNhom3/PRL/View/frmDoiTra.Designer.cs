namespace PRL.View
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
            btnTra = new Button();
            txtSearch = new TextBox();
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
            label1.Location = new Point(484, 69);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 55);
            label1.TabIndex = 0;
            label1.Text = "Quản lý đổi trả";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcToolStripMenuItem, thêmNhânViênToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1402, 42);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcToolStripMenuItem
            // 
            chứcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem, quảnLýKhuyếnMạiToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem });
            chứcToolStripMenuItem.Name = "chứcToolStripMenuItem";
            chứcToolStripMenuItem.Size = new Size(149, 36);
            chứcToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(362, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(362, 44);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMạiToolStripMenuItem
            // 
            quảnLýKhuyếnMạiToolStripMenuItem.Name = "quảnLýKhuyếnMạiToolStripMenuItem";
            quảnLýKhuyếnMạiToolStripMenuItem.Size = new Size(362, 44);
            quảnLýKhuyếnMạiToolStripMenuItem.Text = "Quản lý khuyến mại";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(362, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(362, 44);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(362, 44);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(208, 36);
            thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(100, 36);
            userToolStripMenuItem.Text = "User : ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(291, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(291, 44);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgtView);
            groupBox2.Location = new Point(44, 472);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(1298, 498);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgtView
            // 
            dgtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtView.Location = new Point(49, 42);
            dgtView.Margin = new Padding(5, 5, 5, 5);
            dgtView.Name = "dgtView";
            dgtView.RowHeadersWidth = 51;
            dgtView.RowTemplate.Height = 29;
            dgtView.Size = new Size(1217, 424);
            dgtView.TabIndex = 0;
            dgtView.CellClick += dgtView_CellClick;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(954, 1008);
            btnXem.Margin = new Padding(5, 5, 5, 5);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(150, 75);
            btnXem.TabIndex = 4;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1157, 1008);
            btnThoat.Margin = new Padding(5, 5, 5, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(153, 75);
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
            groupBox3.Location = new Point(44, 155);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(562, 285);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(250, 174);
            txtMaHD.Margin = new Padding(5, 5, 5, 5);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(201, 39);
            txtMaHD.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 174);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 4;
            label4.Text = "Mã hóa đơn";
            // 
            // txtMaSp
            // 
            txtMaSp.Location = new Point(250, 102);
            txtMaSp.Margin = new Padding(5, 5, 5, 5);
            txtMaSp.Name = "txtMaSp";
            txtMaSp.Size = new Size(201, 39);
            txtMaSp.TabIndex = 3;
            // 
            // txtMaNv
            // 
            txtMaNv.Location = new Point(250, 42);
            txtMaNv.Margin = new Padding(5, 5, 5, 5);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(201, 39);
            txtMaNv.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 114);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 1;
            label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // btnDoiHang
            // 
            btnDoiHang.Location = new Point(197, 202);
            btnDoiHang.Margin = new Padding(5, 5, 5, 5);
            btnDoiHang.Name = "btnDoiHang";
            btnDoiHang.Size = new Size(195, 61);
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
            grb.Location = new Point(644, 155);
            grb.Margin = new Padding(5, 5, 5, 5);
            grb.Name = "grb";
            grb.Padding = new Padding(5, 5, 5, 5);
            grb.Size = new Size(699, 307);
            grb.TabIndex = 7;
            grb.TabStop = false;
            grb.Text = "Chức năng";
            // 
            // btnTra
            // 
            btnTra.Location = new Point(471, 202);
            btnTra.Margin = new Padding(5, 5, 5, 5);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(195, 61);
            btnTra.TabIndex = 3;
            btnTra.Text = "Trả hàng";
            btnTra.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(24, 70);
            txtSearch.Margin = new Padding(5, 5, 5, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã hóa đơn để tìm kiếm";
            txtSearch.Size = new Size(504, 39);
            txtSearch.TabIndex = 2;
            // 
            // frmDoiTra
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 1102);
            Controls.Add(grb);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnXem);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
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