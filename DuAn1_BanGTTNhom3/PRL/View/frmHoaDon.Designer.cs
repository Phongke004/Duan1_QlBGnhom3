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
            cbbTenSanPham = new ComboBox();
            cbbMaNhanVien = new ComboBox();
            dtpkNgayTao = new DateTimePicker();
            txtMaHoaDon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            cbbMaHD = new ComboBox();
            label16 = new Label();
            txtSoSanPham = new TextBox();
            cbbGiamGia = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtTongTien = new TextBox();
            txtDonGia = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label14 = new Label();
            txtTienSauVC = new TextBox();
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
            menuStrip1 = new MenuStrip();
            txtsearch = new TextBox();
            label13 = new Label();
            cbbTrangthai = new ComboBox();
            label15 = new Label();
            dtgviewHD = new DataGridView();
            ClearCode = new Button();
            btnHienThiHD = new Button();
            btnAddHD = new Button();
            btnUpdateHD = new Button();
            btnXoaHD = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewHD).BeginInit();
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
            groupBox1.Controls.Add(cbbTenSanPham);
            groupBox1.Controls.Add(cbbMaNhanVien);
            groupBox1.Controls.Add(dtpkNgayTao);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(11, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1758, 235);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoa đơn";
            // 
            // cbbMaKH
            // 
            cbbMaKH.FormattingEnabled = true;
            cbbMaKH.Location = new Point(1131, 35);
            cbbMaKH.Name = "cbbMaKH";
            cbbMaKH.Size = new Size(570, 40);
            cbbMaKH.TabIndex = 10;
            // 
            // cbbTenSanPham
            // 
            cbbTenSanPham.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTenSanPham.FormattingEnabled = true;
            cbbTenSanPham.Location = new Point(253, 170);
            cbbTenSanPham.Name = "cbbTenSanPham";
            cbbTenSanPham.Size = new Size(514, 41);
            cbbTenSanPham.TabIndex = 12;
            cbbTenSanPham.SelectedIndexChanged += cbbMaSP_SelectedIndexChanged;
            // 
            // cbbMaNhanVien
            // 
            cbbMaNhanVien.FormattingEnabled = true;
            cbbMaNhanVien.Location = new Point(1134, 104);
            cbbMaNhanVien.Name = "cbbMaNhanVien";
            cbbMaNhanVien.Size = new Size(567, 40);
            cbbMaNhanVien.TabIndex = 9;
            // 
            // dtpkNgayTao
            // 
            dtpkNgayTao.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkNgayTao.Format = DateTimePickerFormat.Custom;
            dtpkNgayTao.Location = new Point(251, 104);
            dtpkNgayTao.Name = "dtpkNgayTao";
            dtpkNgayTao.Size = new Size(511, 41);
            dtpkNgayTao.TabIndex = 8;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(251, 38);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(514, 41);
            txtMaHoaDon.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(871, 112);
            label5.Name = "label5";
            label5.Size = new Size(185, 33);
            label5.TabIndex = 3;
            label5.Text = "Mã nhân viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(866, 38);
            label4.Name = "label4";
            label4.Size = new Size(201, 33);
            label4.TabIndex = 2;
            label4.Text = "Mã khách hàng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 112);
            label3.Name = "label3";
            label3.Size = new Size(130, 33);
            label3.TabIndex = 1;
            label3.Text = "Ngày tạo :";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSP.Location = new Point(1131, 162);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(570, 41);
            txtMaSP.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 170);
            label6.Name = "label6";
            label6.Size = new Size(188, 33);
            label6.TabIndex = 0;
            label6.Text = "Tên sản phẩm :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 46);
            label2.Name = "label2";
            label2.Size = new Size(166, 33);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(875, 173);
            label8.Name = "label8";
            label8.Size = new Size(181, 33);
            label8.TabIndex = 2;
            label8.Text = "Mã sản phẩm :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbMaHD);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtSoSanPham);
            groupBox2.Controls.Add(cbbGiamGia);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtTienSauVC);
            groupBox2.Location = new Point(16, 646);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1755, 252);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // cbbMaHD
            // 
            cbbMaHD.FormattingEnabled = true;
            cbbMaHD.Location = new Point(229, 198);
            cbbMaHD.Name = "cbbMaHD";
            cbbMaHD.Size = new Size(522, 40);
            cbbMaHD.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(26, 194);
            label16.Name = "label16";
            label16.Size = new Size(143, 28);
            label16.TabIndex = 14;
            label16.Text = "Mã Hóa Đơn";
            // 
            // txtSoSanPham
            // 
            txtSoSanPham.Location = new Point(229, 53);
            txtSoSanPham.Name = "txtSoSanPham";
            txtSoSanPham.Size = new Size(522, 39);
            txtSoSanPham.TabIndex = 0;
            txtSoSanPham.TextChanged += txtSoSanPham_TextChanged;
            // 
            // cbbGiamGia
            // 
            cbbGiamGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbbGiamGia.FormattingEnabled = true;
            cbbGiamGia.Location = new Point(1099, 50);
            cbbGiamGia.Name = "cbbGiamGia";
            cbbGiamGia.Size = new Size(570, 41);
            cbbGiamGia.TabIndex = 11;
            cbbGiamGia.SelectedIndexChanged += cbbGiamGia_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(840, 117);
            label11.Name = "label11";
            label11.Size = new Size(124, 33);
            label11.TabIndex = 9;
            label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(21, 121);
            label10.Name = "label10";
            label10.Size = new Size(105, 33);
            label10.TabIndex = 8;
            label10.Text = "Đơn giá";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTien.Location = new Point(1099, 109);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(574, 41);
            txtTongTien.TabIndex = 7;
            txtTongTien.TextChanged += txtTongTien_TextChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(229, 113);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(522, 41);
            txtDonGia.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(840, 58);
            label9.Name = "label9";
            label9.Size = new Size(132, 33);
            label9.TabIndex = 3;
            label9.Text = "Giảm giá :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 53);
            label7.Name = "label7";
            label7.Size = new Size(133, 33);
            label7.TabIndex = 1;
            label7.Text = "Số lượng :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(850, 190);
            label14.Name = "label14";
            label14.Size = new Size(122, 28);
            label14.TabIndex = 13;
            label14.Text = "Thành tiền";
            // 
            // txtTienSauVC
            // 
            txtTienSauVC.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTienSauVC.Location = new Point(1103, 187);
            txtTienSauVC.Name = "txtTienSauVC";
            txtTienSauVC.Size = new Size(558, 35);
            txtTienSauVC.TabIndex = 11;
            txtTienSauVC.TextChanged += txtTienSauVC_TextChanged;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(11, 904);
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
            btnAddHoadon.Location = new Point(1801, 758);
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
            btnSuaHoaDon.Location = new Point(1801, 840);
            btnSuaHoaDon.Name = "btnSuaHoaDon";
            btnSuaHoaDon.Size = new Size(185, 46);
            btnSuaHoaDon.TabIndex = 5;
            btnSuaHoaDon.Text = "Sửa hóa đơn";
            btnSuaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXoaHoaDon.Location = new Point(1791, 943);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(182, 46);
            btnXoaHoaDon.TabIndex = 6;
            btnXoaHoaDon.Text = "Xóa hóa đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            btnHienthi.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHienthi.Location = new Point(1801, 1033);
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
            btnThoat.Location = new Point(1801, 1195);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnStripUser, quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(2009, 37);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtsearch.Location = new Point(1145, 338);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(555, 35);
            txtsearch.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(985, 346);
            label13.Name = "label13";
            label13.Size = new Size(106, 28);
            label13.TabIndex = 12;
            label13.Text = "Tìm kiếm";
            // 
            // cbbTrangthai
            // 
            cbbTrangthai.FormattingEnabled = true;
            cbbTrangthai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cbbTrangthai.Location = new Point(264, 331);
            cbbTrangthai.Name = "cbbTrangthai";
            cbbTrangthai.Size = new Size(514, 40);
            cbbTrangthai.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(75, 338);
            label15.Name = "label15";
            label15.Size = new Size(117, 28);
            label15.TabIndex = 15;
            label15.Text = "Trạng thái";
            // 
            // dtgviewHD
            // 
            dtgviewHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewHD.Location = new Point(22, 390);
            dtgviewHD.Name = "dtgviewHD";
            dtgviewHD.RowHeadersWidth = 82;
            dtgviewHD.RowTemplate.Height = 41;
            dtgviewHD.Size = new Size(1749, 250);
            dtgviewHD.TabIndex = 13;
            dtgviewHD.CellClick += dtgviewHD_CellClick;
            // 
            // ClearCode
            // 
            ClearCode.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClearCode.Location = new Point(1801, 1112);
            ClearCode.Name = "ClearCode";
            ClearCode.Size = new Size(150, 46);
            ClearCode.TabIndex = 16;
            ClearCode.Text = "Clear >.<";
            ClearCode.UseVisualStyleBackColor = true;
            ClearCode.Click += button1_Click;
            // 
            // btnHienThiHD
            // 
            btnHienThiHD.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHienThiHD.Location = new Point(1823, 115);
            btnHienThiHD.Name = "btnHienThiHD";
            btnHienThiHD.Size = new Size(150, 46);
            btnHienThiHD.TabIndex = 17;
            btnHienThiHD.Text = "Hiển thị";
            btnHienThiHD.UseVisualStyleBackColor = true;
            btnHienThiHD.Click += btnHienThiHD_Click;
            // 
            // btnAddHD
            // 
            btnAddHD.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddHD.Location = new Point(1823, 202);
            btnAddHD.Name = "btnAddHD";
            btnAddHD.Size = new Size(150, 46);
            btnAddHD.TabIndex = 18;
            btnAddHD.Text = "Thêm";
            btnAddHD.UseVisualStyleBackColor = true;
            btnAddHD.Click += btnAddHD_Click;
            // 
            // btnUpdateHD
            // 
            btnUpdateHD.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdateHD.Location = new Point(1823, 292);
            btnUpdateHD.Name = "btnUpdateHD";
            btnUpdateHD.Size = new Size(150, 46);
            btnUpdateHD.TabIndex = 19;
            btnUpdateHD.Text = "Sửa";
            btnUpdateHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            btnXoaHD.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXoaHD.Location = new Point(1829, 390);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(150, 46);
            btnXoaHD.TabIndex = 20;
            btnXoaHD.Text = "Xóa";
            btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2009, 1277);
            Controls.Add(btnXoaHD);
            Controls.Add(btnUpdateHD);
            Controls.Add(btnAddHD);
            Controls.Add(btnHienThiHD);
            Controls.Add(ClearCode);
            Controls.Add(dtgviewHD);
            Controls.Add(label15);
            Controls.Add(cbbTrangthai);
            Controls.Add(label13);
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
            ((System.ComponentModel.ISupportInitialize)dtgviewHD).EndInit();
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
        private MenuStrip menuStrip1;
        private TextBox txtTienSauVC;
        private ComboBox cbbMaNhanVien;
        private ToolStripMenuItem cuoponToolStripMenuItem;
        private ComboBox cbbMaKH;
        private DataGridView dtgviewHD;
        private Button ClearCode;
        private Button btnHienThiHD;
        private Button btnAddHD;
        private Button btnUpdateHD;
        private Button btnXoaHD;
        private ComboBox cbbMaHD;
        private Label label16;
    }
}