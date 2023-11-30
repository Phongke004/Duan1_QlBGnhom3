namespace PRL.View
{
    partial class frmHoaDon
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
            groupBox1 = new GroupBox();
            dtpkNgayTao = new DateTimePicker();
            txtMaNhanVien = new TextBox();
            txtMaKhachHang = new TextBox();
            txtMaHoaDon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
       
            cbbMaSP = new ComboBox();
            cbbGiamGia = new ComboBox();
            cbbSoLuong = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtTongTien = new TextBox();
            txtDonGia = new TextBox();
            txtTenSanPham = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dtgView = new DataGridView();
            btnAddHoadon = new Button();
            btnSuaHoaDon = new Button();
            btnXoaHoaDon = new Button();
            btnHienthi = new Button();
            btnThoat = new Button();
            menuStrip1 = new MenuStrip();
            mnStripUser = new ToolStripMenuItem();
            mnStripDoiMk = new ToolStripMenuItem();
            MnStripDangXuat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            quảToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem1 = new ToolStripMenuItem();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(731, 24);
            label1.Name = "label1";
            label1.Size = new Size(336, 63);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn Bán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpkNgayTao);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1758, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // dtpkNgayTao
            // 
            dtpkNgayTao.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkNgayTao.Format = DateTimePickerFormat.Custom;
            dtpkNgayTao.Location = new Point(224, 165);
            dtpkNgayTao.Name = "dtpkNgayTao";
            dtpkNgayTao.Size = new Size(526, 41);
            dtpkNgayTao.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(1107, 154);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(578, 41);
            txtMaNhanVien.TabIndex = 7;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(1107, 51);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(578, 41);
            txtMaKhachHang.TabIndex = 6;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(228, 54);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(522, 41);
            txtMaHoaDon.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(843, 162);
            label5.Name = "label5";
            label5.Size = new Size(185, 33);
            label5.TabIndex = 3;
            label5.Text = "Mã nhân viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(843, 54);
            label4.Name = "label4";
            label4.Size = new Size(201, 33);
            label4.TabIndex = 2;
            label4.Text = "Mã khách hàng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 160);
            label3.Name = "label3";
            label3.Size = new Size(130, 33);
            label3.TabIndex = 1;
            label3.Text = "Ngày tạo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 54);
            label2.Name = "label2";
            label2.Size = new Size(166, 33);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbMaSP);
            groupBox2.Controls.Add(cbbGiamGia);
            groupBox2.Controls.Add(cbbSoLuong);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtTenSanPham);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(16, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1755, 245);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtSoLuong
            // 

            // cbbMaSP
            // 
            cbbMaSP.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaSP.FormattingEnabled = true;
            cbbMaSP.Location = new Point(1103, 51);
            cbbMaSP.Name = "cbbMaSP";
            cbbMaSP.Size = new Size(574, 41);
            cbbMaSP.TabIndex = 12;
            // 
            // cbbGiamGia
            // 
            cbbGiamGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbGiamGia.FormattingEnabled = true;
            cbbGiamGia.Location = new Point(1103, 115);
            cbbGiamGia.Name = "cbbGiamGia";
            cbbGiamGia.Size = new Size(578, 41);
            cbbGiamGia.TabIndex = 11;
           
            // 
            // cbbSoLuong
            // 
            cbbSoLuong.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSoLuong.FormattingEnabled = true;
            cbbSoLuong.Location = new Point(223, 118);
            cbbSoLuong.Name = "cbbSoLuong";
            cbbSoLuong.Size = new Size(522, 41);
            cbbSoLuong.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(853, 182);
            label11.Name = "label11";
            label11.Size = new Size(124, 33);
            label11.TabIndex = 9;
            label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(34, 186);
            label10.Name = "label10";
            label10.Size = new Size(105, 33);
            label10.TabIndex = 8;
            label10.Text = "Đơn giá";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTien.Location = new Point(1102, 174);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(578, 41);
            txtTongTien.TabIndex = 7;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(223, 179);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(522, 41);
            txtDonGia.TabIndex = 5;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSanPham.Location = new Point(223, 51);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(522, 41);
            txtTenSanPham.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(853, 123);
            label9.Name = "label9";
            label9.Size = new Size(132, 33);
            label9.TabIndex = 3;
            label9.Text = "Giảm giá :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(853, 46);
            label8.Name = "label8";
            label8.Size = new Size(128, 33);
            label8.TabIndex = 2;
            label8.Text = "Mã hàng :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);

            label7.Location = new Point(34, 115);
            label7.Location = new Point(34, 118);

            label7.Name = "label7";
            label7.Size = new Size(133, 33);
            label7.TabIndex = 1;
            label7.Text = "Số lượng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 58);
            label6.Name = "label6";
            label6.Size = new Size(188, 33);
            label6.TabIndex = 0;
            label6.Text = "Tên sản phẩm :";
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(16, 600);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 82;
            dtgView.RowTemplate.Height = 41;
            dtgView.Size = new Size(1753, 301);
            dtgView.TabIndex = 3;
            // 
            // btnAddHoadon

            btnAddHoadon.Location = new Point(25, 982);
            btnAddHoadon.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddHoadon.Location = new Point(14, 982);

            btnAddHoadon.Name = "btnAddHoadon";
            btnAddHoadon.Size = new Size(185, 46);
            btnAddHoadon.TabIndex = 4;
            btnAddHoadon.Text = "Thêm hóa đơn";
            btnAddHoadon.UseVisualStyleBackColor = true;
            // 
            // btnSuaHoaDon
            // 

            btnSuaHoaDon.Location = new Point(239, 982);
            btnSuaHoaDon.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSuaHoaDon.Location = new Point(228, 982);

            btnSuaHoaDon.Name = "btnSuaHoaDon";
            btnSuaHoaDon.Size = new Size(185, 46);
            btnSuaHoaDon.TabIndex = 5;
            btnSuaHoaDon.Text = "Sửa hóa đơn";
            btnSuaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 

            btnXoaHoaDon.Location = new Point(485, 982);
            btnXoaHoaDon.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXoaHoaDon.Location = new Point(474, 982);

            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(182, 46);
            btnXoaHoaDon.TabIndex = 6;
            btnXoaHoaDon.Text = "Xóa hóa đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 

            btnHienthi.Location = new Point(714, 982);
            btnHienthi.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHienthi.Location = new Point(703, 982);

            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(150, 46);
            btnHienthi.TabIndex = 7;
            btnHienthi.Text = "Hiển thị";
            btnHienthi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 

            btnThoat.Location = new Point(1547, 982);
            btnThoat.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnThoat.Location = new Point(1536, 982);

            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnStripUser, quảnLýToolStripMenuItem, thêmNhânViênToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1796, 37);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnStripUser
            // 
            mnStripUser.Alignment = ToolStripItemAlignment.Right;
            mnStripUser.DropDownItems.AddRange(new ToolStripItem[] { mnStripDoiMk, MnStripDangXuat });
            mnStripUser.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mnStripUser.Margin = new Padding(0, 0, 290, 0);
            mnStripUser.Name = "mnStripUser";
            mnStripUser.Size = new Size(88, 31);
            mnStripUser.Text = "User :";
            // 
            // mnStripDoiMk
            // 
            mnStripDoiMk.Name = "mnStripDoiMk";
            mnStripDoiMk.Size = new Size(273, 44);
            mnStripDoiMk.Text = "Đổi mật khẩu";
            mnStripDoiMk.Click += mnStripDoiMk_Click;
            // 
            // MnStripDangXuat
            // 
            MnStripDangXuat.Name = "MnStripDangXuat";
            MnStripDangXuat.Size = new Size(273, 44);
            MnStripDangXuat.Text = "Đăng Xuất";
            MnStripDangXuat.Click += MnStripDangXuat_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, quToolStripMenuItem, thốngKêToolStripMenuItem, quảToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, thốngKêToolStripMenuItem1 });
            quảnLýToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(108, 31);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(337, 44);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(337, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quToolStripMenuItem
            // 
            quToolStripMenuItem.Name = "quToolStripMenuItem";
            quToolStripMenuItem.Size = new Size(337, 44);
            quToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(337, 44);
            thốngKêToolStripMenuItem.Text = "Quản lý khuyến mại";
            // 
            // quảToolStripMenuItem
            // 
            quảToolStripMenuItem.Name = "quảToolStripMenuItem";
            quảToolStripMenuItem.Size = new Size(337, 44);
            quảToolStripMenuItem.Text = "Quản lý đổi trả";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(337, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // thốngKêToolStripMenuItem1
            // 
            thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            thốngKêToolStripMenuItem1.Size = new Size(337, 44);
            thốngKêToolStripMenuItem1.Text = "Thống kê";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(187, 31);
            thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            // 
          

            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 1040);

           

            Controls.Add(btnThoat);
            Controls.Add(btnHienthi);
            Controls.Add(btnXoaHoaDon);
            Controls.Add(btnSuaHoaDon);
            Controls.Add(btnAddHoadon);
            Controls.Add(dtgView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpkNgayTao;
        private TextBox txtMaNhanVien;
        private TextBox txtMaKhachHang;
        private TextBox txtMaHoaDon;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private TextBox txtTongTien;
        private TextBox textBox3;
        private TextBox txtDonGia;
        private TextBox txtTenSanPham;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbbGiamGia;
        private ComboBox cbbSoLuong;
        private ComboBox cbbMaSP;
        private DataGridView dtgView;
        private Button btnAddHoadon;
        private Button btnSuaHoaDon;
        private Button btnXoaHoaDon;
        private Button btnHienthi;
        private Button btnThoat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnStripUser;
        private ToolStripMenuItem mnStripDoiMk;
        private ToolStripMenuItem MnStripDangXuat;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem quảToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem1;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;

        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private Label label12;


    }
}