namespace PRL.View
{
    partial class frmQuanLyHD
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            dtgvHoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dtgvHDCT = new DataGridView();
            btnXoa = new Button();
            btnHIenthi = new Button();
            btnInHoaDon = new Button();
            txtsearch = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHDCT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(527, 25);
            label1.Name = "label1";
            label1.Size = new Size(386, 57);
            label1.TabIndex = 0;
            label1.Text = "Quản lý Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvHoaDon);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1434, 372);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtgvHoaDon
            // 
            dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDon.Location = new Point(8, 44);
            dtgvHoaDon.Name = "dtgvHoaDon";
            dtgvHoaDon.RowHeadersWidth = 82;
            dtgvHoaDon.RowTemplate.Height = 41;
            dtgvHoaDon.Size = new Size(1420, 306);
            dtgvHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgvHDCT);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 556);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1428, 411);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // dtgvHDCT
            // 
            dtgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHDCT.Location = new Point(6, 38);
            dtgvHDCT.Name = "dtgvHDCT";
            dtgvHDCT.RowHeadersWidth = 82;
            dtgvHDCT.RowTemplate.Height = 41;
            dtgvHDCT.Size = new Size(1416, 367);
            dtgvHDCT.TabIndex = 0;
            dtgvHDCT.CellClick += dtgvHDCT_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.Location = new Point(790, 502);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHIenthi
            // 
            btnHIenthi.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHIenthi.Location = new Point(1290, 502);
            btnHIenthi.Name = "btnHIenthi";
            btnHIenthi.Size = new Size(150, 46);
            btnHIenthi.TabIndex = 4;
            btnHIenthi.Text = "Hiển thị";
            btnHIenthi.UseVisualStyleBackColor = true;
            btnHIenthi.Click += btnHIenthi_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInHoaDon.Location = new Point(602, 502);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(150, 46);
            btnInHoaDon.TabIndex = 5;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtsearch.Location = new Point(996, 508);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Tìm Kiếm";
            txtsearch.Size = new Size(282, 35);
            txtsearch.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(1170, 1001);
            button1.Name = "button1";
            button1.Size = new Size(198, 46);
            button1.TabIndex = 8;
            button1.Text = "Xóa sản phẩm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmQuanLyHD
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 1087);
            Controls.Add(button1);
            Controls.Add(txtsearch);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnHIenthi);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmQuanLyHD";
            Text = "frmQuanLyHD";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHDCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private DataGridView dtgvHoaDon;
        private GroupBox groupBox2;
        private DataGridView dtgvHDCT;
        private Button btnXoa;
        private Button btnHIenthi;
        private Button btnInHoaDon;
        private TextBox txtsearch;
        private Button button1;
    }
}