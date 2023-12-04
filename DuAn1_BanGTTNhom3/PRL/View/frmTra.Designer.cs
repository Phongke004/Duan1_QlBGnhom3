namespace PRL.View
{
    partial class frmTra
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
            label6 = new Label();
            txtSearch = new TextBox();
            txtLyDo = new TextBox();
            label5 = new Label();
            dtpkNgayTra = new DateTimePicker();
            label4 = new Label();
            txtTrangThai = new TextBox();
            label3 = new Label();
            txtMaTRa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnShow = new Button();
            dtgview = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(txtLyDo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpkNgayTra);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTrangThai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaTRa);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(71, 342);
            label6.Name = "label6";
            label6.Size = new Size(109, 24);
            label6.TabIndex = 9;
            label6.Text = "Tìm kiếm : ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(345, 335);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(468, 39);
            txtSearch.TabIndex = 8;
            // 
            // txtLyDo
            // 
            txtLyDo.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtLyDo.Location = new Point(348, 272);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(464, 35);
            txtLyDo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(72, 275);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 6;
            label5.Text = "Lý do trả :";
            // 
            // dtpkNgayTra
            // 
            dtpkNgayTra.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dtpkNgayTra.Format = DateTimePickerFormat.Short;
            dtpkNgayTra.Location = new Point(346, 192);
            dtpkNgayTra.Name = "dtpkNgayTra";
            dtpkNgayTra.Size = new Size(466, 35);
            dtpkNgayTra.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(54, 197);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 4;
            label4.Text = " Ngày trả :";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTrangThai.Location = new Point(348, 119);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(465, 35);
            txtTrangThai.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(48, 118);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái hàng :";
            // 
            // txtMaTRa
            // 
            txtMaTRa.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtMaTRa.Location = new Point(350, 44);
            txtMaTRa.Name = "txtMaTRa";
            txtMaTRa.Size = new Size(463, 35);
            txtMaTRa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(54, 47);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã trả hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(755, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 55);
            label1.TabIndex = 1;
            label1.Text = "Trả hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(985, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 379);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(128, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(128, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Lưu ";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(128, 61);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(150, 46);
            btnShow.TabIndex = 4;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dtgview
            // 
            dtgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview.Location = new Point(12, 499);
            dtgview.Name = "dtgview";
            dtgview.RowHeadersWidth = 82;
            dtgview.RowTemplate.Height = 41;
            dtgview.Size = new Size(1373, 346);
            dtgview.TabIndex = 3;
            dtgview.CellClick += dtgview_CellClick;
            // 
            // frmTra
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 847);
            Controls.Add(dtgview);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmTra";
            Text = "frmTra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMaTRa;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dtgview;
        private TextBox txtLyDo;
        private Label label5;
        private DateTimePicker dtpkNgayTra;
        private Label label4;
        private TextBox txtTrangThai;
        private Label label3;
        private Button btnShow;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label6;
        private TextBox txtSearch;
    }
}