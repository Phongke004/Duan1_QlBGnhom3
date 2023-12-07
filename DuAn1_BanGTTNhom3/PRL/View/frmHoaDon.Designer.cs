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
            cbbMaKH = new ComboBox();
            cbbMaNhanVien = new ComboBox();
            dtpkNgayTao = new DateTimePicker();
            txtMaHoaDon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtSoSanPham = new TextBox();
            cbbTenSanPham = new ComboBox();
            cbbGiamGia = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtTongTien = new TextBox();
            txtDonGia = new TextBox();
            txtMaSP = new TextBox();
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
            label12 = new Label();
            txtThanhTien = new TextBox();
            mnStripUser = new ToolStripMenuItem();
            mnStripDoiMk = new ToolStripMenuItem();
            MnStripDangXuat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            quảToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem1 = new ToolStripMenuItem();
            cuoponToolStripMenuItem = new ToolStripMenuItem();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            txtsearch = new TextBox();
            txtTienSauVC = new TextBox();
            label13 = new Label();
            label14 = new Label();
            cbbTrangthai = new ComboBox();
            label15 = new Label();
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
            groupBox1.Controls.Add(cbbMaKH);
            groupBox1.Controls.Add(cbbMaNhanVien);
            groupBox1.Controls.Add(dtpkNgayTao);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1758, 190);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cbbMaKH
            // 
            cbbMaKH.FormattingEnabled = true;
            cbbMaKH.Location = new Point(1108, 64);
            cbbMaKH.Name = "cbbMaKH";
            cbbMaKH.Size = new Size(570, 40);
            cbbMaKH.TabIndex = 10;
            // 
            // cbbMaNhanVien
            // 
            cbbMaNhanVien.FormattingEnabled = true;
            cbbMaNhanVien.Location = new Point(1103, 131);
            cbbMaNhanVien.Name = "cbbMaNhanVien";
            cbbMaNhanVien.Size = new Size(572, 40);
            cbbMaNhanVien.TabIndex = 9;
            // 
            // dtpkNgayTao
            // 
            dtpkNgayTao.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkNgayTao.Format = DateTimePickerFormat.Custom;
            dtpkNgayTao.Location = new Point(231, 128);
            dtpkNgayTao.Name = "dtpkNgayTao";
            dtpkNgayTao.Size = new Size(511, 41);
            dtpkNgayTao.TabIndex = 8;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(228, 54);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(514, 41);
            txtMaHoaDon.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(843, 136);
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
            label3.Location = new Point(49, 136);
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
            groupBox2.Controls.Add(txtSoSanPham);
            groupBox2.Controls.Add(cbbTenSanPham);
            groupBox2.Controls.Add(cbbGiamGia);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(8, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1755, 245);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtSoSanPham
            // 
            txtSoSanPham.Location = new Point(242, 118);
            txtSoSanPham.Name = "txtSoSanPham";
            txtSoSanPham.Size = new Size(522, 39);
            txtSoSanPham.TabIndex = 0;
            txtSoSanPham.TextChanged += txtSoSanPham_TextChanged;
            // 
            // cbbTenSanPham
            // 
            cbbTenSanPham.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTenSanPham.FormattingEnabled = true;
            cbbTenSanPham.Location = new Point(237, 58);
            cbbTenSanPham.Name = "cbbTenSanPham";
            cbbTenSanPham.Size = new Size(527, 41);
            cbbTenSanPham.TabIndex = 12;
            cbbTenSanPham.SelectedIndexChanged += cbbMaSP_SelectedIndexChanged;
            // 
            // cbbGiamGia
            // 
            cbbGiamGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbGiamGia.FormattingEnabled = true;
            cbbGiamGia.Location = new Point(1112, 115);
            cbbGiamGia.Name = "cbbGiamGia";
            cbbGiamGia.Size = new Size(570, 41);
            cbbGiamGia.TabIndex = 11;
            cbbGiamGia.SelectedIndexChanged += cbbGiamGia_SelectedIndexChanged;
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
            txtTongTien.Location = new Point(1112, 174);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(574, 41);
            txtTongTien.TabIndex = 7;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(242, 178);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(522, 41);
            txtDonGia.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSP.Location = new Point(1110, 46);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(571, 41);
            txtMaSP.TabIndex = 4;
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
            label8.Size = new Size(181, 33);
            label8.TabIndex = 2;
            label8.Text = "Mã sản phẩm :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
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
            dtgView.Location = new Point(11, 602);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 82;
            dtgView.RowTemplate.Height = 41;
            dtgView.Size = new Size(1753, 294);
            dtgView.TabIndex = 3;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btnAddHoadon
            // 
            btnAddHoadon.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddHoadon.Location = new Point(15, 982);
            btnAddHoadon.Name = "btnAddHoadon";
            btnAddHoadon.Size = new Size(185, 46);
            btnAddHoadon.TabIndex = 4;
            btnAddHoadon.Text = "Thêm hóa đơn";
            btnAddHoadon.UseVisualStyleBackColor = true;
            btnAddHoadon.Click += btnAddHoadon_Click;
            // 
            // btnSuaHoaDon
            // 
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
            btnHienthi.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHienthi.Location = new Point(704, 982);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(150, 46);
            btnHienthi.TabIndex = 7;
            btnHienthi.Text = "Hiển thị";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += btnHienthi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnThoat.Location = new Point(1536, 982);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(960, 933);
            label12.Name = "label12";
            label12.Size = new Size(120, 24);
            label12.TabIndex = 10;
            label12.Text = "Thành tiền :";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtThanhTien.Location = new Point(1118, 926);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(357, 32);
            txtThanhTien.TabIndex = 11;
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
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, thốngKêToolStripMenuItem, quảToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, thốngKêToolStripMenuItem1, cuoponToolStripMenuItem });
            quảnLýToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(108, 31);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(335, 44);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(335, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(335, 44);
            thốngKêToolStripMenuItem.Text = "Quản lý Voucher";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // quảToolStripMenuItem
            // 
            quảToolStripMenuItem.Name = "quảToolStripMenuItem";
            quảToolStripMenuItem.Size = new Size(335, 44);
            quảToolStripMenuItem.Text = "Quản lý đổi trả";
            quảToolStripMenuItem.Click += quảToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(335, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // thốngKêToolStripMenuItem1
            // 
            thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            thốngKêToolStripMenuItem1.Size = new Size(335, 44);
            thốngKêToolStripMenuItem1.Text = "Thống kê";
            thốngKêToolStripMenuItem1.Click += thốngKêToolStripMenuItem1_Click;
            // 
            // cuoponToolStripMenuItem
            // 
            cuoponToolStripMenuItem.Name = "cuoponToolStripMenuItem";
            cuoponToolStripMenuItem.Size = new Size(335, 44);
            cuoponToolStripMenuItem.Text = "Cuopon";
            cuoponToolStripMenuItem.Click += cuoponToolStripMenuItem_Click;
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(187, 31);
            thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
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
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtsearch.Location = new Point(1131, 546);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(555, 35);
            txtsearch.TabIndex = 10;
            // 
            // txtTienSauVC
            // 
            txtTienSauVC.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTienSauVC.Location = new Point(1131, 915);
            txtTienSauVC.Name = "txtTienSauVC";
            txtTienSauVC.Size = new Size(558, 35);
            txtTienSauVC.TabIndex = 11;
            txtTienSauVC.TextChanged += txtTienSauVC_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(977, 549);
            label13.Name = "label13";
            label13.Size = new Size(106, 28);
            label13.TabIndex = 12;
            label13.Text = "Tìm kiếm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(977, 922);
            label14.Name = "label14";
            label14.Size = new Size(122, 28);
            label14.TabIndex = 13;
            label14.Text = "Thành tiền";
            // 
            // cbbTrangthai
            // 
            cbbTrangthai.FormattingEnabled = true;
            cbbTrangthai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cbbTrangthai.Location = new Point(245, 547);
            cbbTrangthai.Name = "cbbTrangthai";
            cbbTrangthai.Size = new Size(526, 40);
            cbbTrangthai.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(73, 546);
            label15.Name = "label15";
            label15.Size = new Size(117, 28);
            label15.TabIndex = 15;
            label15.Text = "Trạng thái";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 1040);
            Controls.Add(label15);
            Controls.Add(cbbTrangthai);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtTienSauVC);
            Controls.Add(txtsearch);
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
            Text = "Hóa đơn";
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
        private TextBox txtMaHoaDon;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private TextBox txtTongTien;
        private TextBox textBox3;
        private TextBox txtDonGia;
        private TextBox txtMaSP;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbbGiamGia;
        private ComboBox cbbTenSanPham;
        private DataGridView dtgView;
        private Button btnAddHoadon;
        private Button btnSuaHoaDon;
        private Button btnXoaHoaDon;
        private Button btnHienthi;
        private Button btnThoat;

        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private Label label12;
        private TextBox txtSoSanPham;
        private Label label13;
        private TextBox txtsearch;
        private Label label14;
        private TextBox txtSearch;
        private Label label15;
        private ComboBox cbbTrangthai;
        private ToolStripMenuItem mnStripUser;
        private ToolStripMenuItem mnStripDoiMk;
        private ToolStripMenuItem MnStripDangXuat;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem quảToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem1;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TextBox txtTienSauVC;
        private ComboBox cbbMaNhanVien;
        private ToolStripMenuItem cuoponToolStripMenuItem;
        private ComboBox cbbMaKH;
    }
}