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
            txtsearch = new TextBox();
            btndel = new Button();
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
            label1.Location = new Point(464, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "Quản lý Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvHoaDon);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 64);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1068, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtgvHoaDon
            // 
            dtgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDon.Location = new Point(20, 37);
            dtgvHoaDon.Margin = new Padding(2);
            dtgvHoaDon.Name = "dtgvHoaDon";
            dtgvHoaDon.RowHeadersWidth = 82;
            dtgvHoaDon.RowTemplate.Height = 41;
            dtgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHoaDon.Size = new Size(1020, 191);
            dtgvHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgvHDCT);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(11, 348);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1064, 257);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // dtgvHDCT
            // 
            dtgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHDCT.Location = new Point(7, 28);
            dtgvHDCT.Margin = new Padding(2);
            dtgvHDCT.Name = "dtgvHDCT";
            dtgvHDCT.RowHeadersWidth = 82;
            dtgvHDCT.RowTemplate.Height = 41;
            dtgvHDCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHDCT.Size = new Size(1029, 229);
            dtgvHDCT.TabIndex = 0;
            dtgvHDCT.CellClick += dtgvHDCT_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.Location = new Point(486, 314);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHIenthi
            // 
            btnHIenthi.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHIenthi.Location = new Point(794, 314);
            btnHIenthi.Margin = new Padding(2);
            btnHIenthi.Name = "btnHIenthi";
            btnHIenthi.Size = new Size(92, 29);
            btnHIenthi.TabIndex = 4;
            btnHIenthi.Text = "Hiển thị";
            btnHIenthi.UseVisualStyleBackColor = true;
            btnHIenthi.Click += btnHIenthi_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtsearch.Location = new Point(613, 318);
            txtsearch.Margin = new Padding(2);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Tìm Kiếm";
            txtsearch.Size = new Size(175, 25);
            txtsearch.TabIndex = 7;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // btndel
            // 
            btndel.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btndel.Location = new Point(720, 626);
            btndel.Margin = new Padding(2);
            btndel.Name = "btndel";
            btndel.Size = new Size(122, 29);
            btndel.TabIndex = 8;
            btndel.Text = "Xóa sản phẩm";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // frmQuanLyHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 659);
            Controls.Add(btndel);
            Controls.Add(txtsearch);
            Controls.Add(btnHIenthi);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private TextBox txtsearch;
        private Button btndel;
    }
}