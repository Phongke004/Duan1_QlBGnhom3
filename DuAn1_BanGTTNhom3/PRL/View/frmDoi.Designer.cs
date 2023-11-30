namespace PRL
{
    partial class frmDoi
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
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtMaHDCT = new TextBox();
            txtLyDo = new TextBox();
            ptkNgayDoi = new DateTimePicker();
            cbTrangThai = new ComboBox();
            txtMaDoi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgView = new DataGridView();
            btnThoat = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaHDCT);
            groupBox1.Controls.Add(txtLyDo);
            groupBox1.Controls.Add(ptkNgayDoi);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(txtMaDoi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(511, 90);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 43);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(511, 152);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 43);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(511, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 43);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaHDCT
            // 
            txtMaHDCT.Location = new Point(161, 190);
            txtMaHDCT.Name = "txtMaHDCT";
            txtMaHDCT.Size = new Size(250, 27);
            txtMaHDCT.TabIndex = 9;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(161, 152);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(250, 27);
            txtLyDo.TabIndex = 8;
            // 
            // ptkNgayDoi
            // 
            ptkNgayDoi.CustomFormat = "MM/dd/yyyy";
            ptkNgayDoi.Format = DateTimePickerFormat.Custom;
            ptkNgayDoi.Location = new Point(161, 113);
            ptkNgayDoi.Name = "ptkNgayDoi";
            ptkNgayDoi.Size = new Size(250, 27);
            ptkNgayDoi.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(161, 63);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(250, 28);
            cbTrangThai.TabIndex = 6;
            // 
            // txtMaDoi
            // 
            txtMaDoi.Location = new Point(161, 22);
            txtMaDoi.Name = "txtMaDoi";
            txtMaDoi.Size = new Size(250, 27);
            txtMaDoi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 197);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã hóa đơn CT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 155);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Lý do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày đổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã đổi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgView);
            groupBox2.Location = new Point(31, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 260);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(23, 37);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(682, 208);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(631, 613);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 50);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(511, 212);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 43);
            btnClear.TabIndex = 13;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmDoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 675);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDoi";
            Text = "frmDoi";
            Load += frmDoi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtMaHDCT;
        private TextBox txtLyDo;
        private DateTimePicker ptkNgayDoi;
        private ComboBox cbTrangThai;
        private TextBox txtMaDoi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dtgView;
        private Button btnThoat;
        private Button btnClear;
    }
}