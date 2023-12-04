namespace PRL.View
{
    partial class frmThongKe
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
            quảnLýKhuyếnMạiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            tHêToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            couponToolStripMenuItem = new ToolStripMenuItem();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            dateTimeTKEnd = new DateTimePicker();
            button1 = new Button();
            dateTimeTKStart = new DateTimePicker();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnDoiTra = new Label();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // quảnLýKhuyếnMạiToolStripMenuItem
            // 
            quảnLýKhuyếnMạiToolStripMenuItem.Name = "quảnLýKhuyếnMạiToolStripMenuItem";
            quảnLýKhuyếnMạiToolStripMenuItem.Size = new Size(221, 26);
            quảnLýKhuyếnMạiToolStripMenuItem.Text = "Quản lý Voucher";
            quảnLýKhuyếnMạiToolStripMenuItem.Click += quảnLýKhuyếnMạiToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(221, 26);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(221, 26);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // tHêToolStripMenuItem
            // 
            tHêToolStripMenuItem.Name = "tHêToolStripMenuItem";
            tHêToolStripMenuItem.Size = new Size(221, 26);
            tHêToolStripMenuItem.Text = "Quản lý sản phẩm";
            tHêToolStripMenuItem.Click += tHêToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tHêToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýKhuyếnMạiToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, couponToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(112, 24);
            quảnLýToolStripMenuItem.Text = "Menu quản lý";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(221, 26);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // couponToolStripMenuItem
            // 
            couponToolStripMenuItem.Name = "couponToolStripMenuItem";
            couponToolStripMenuItem.Size = new Size(221, 26);
            couponToolStripMenuItem.Text = "Coupon";
            couponToolStripMenuItem.Click += couponToolStripMenuItem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(19, 357);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(879, 236);
            groupBox4.TabIndex = 60;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(832, 188);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimeTKEnd
            // 
            dateTimeTKEnd.Format = DateTimePickerFormat.Custom;
            dateTimeTKEnd.Location = new Point(171, 114);
            dateTimeTKEnd.Name = "dateTimeTKEnd";
            dateTimeTKEnd.Size = new Size(193, 27);
            dateTimeTKEnd.TabIndex = 40;
            dateTimeTKEnd.Value = new DateTime(2023, 12, 1, 19, 58, 57, 0);
            // 
            // button1
            // 
            button1.Location = new Point(240, 179);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 39;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimeTKStart
            // 
            dateTimeTKStart.Format = DateTimePickerFormat.Custom;
            dateTimeTKStart.Location = new Point(171, 53);
            dateTimeTKStart.Name = "dateTimeTKStart";
            dateTimeTKStart.Size = new Size(193, 27);
            dateTimeTKStart.TabIndex = 25;
            dateTimeTKStart.Value = new DateTime(2023, 12, 1, 19, 58, 57, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 58);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 19;
            label2.Text = "Bắt đầu từ ngày : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimeTKEnd);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimeTKStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(19, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 250);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 119);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 41;
            label1.Text = "Tới ngày  : ";
            // 
            // btnDoiTra
            // 
            btnDoiTra.AutoSize = true;
            btnDoiTra.Cursor = Cursors.Cross;
            btnDoiTra.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiTra.Location = new Point(364, 28);
            btnDoiTra.Name = "btnDoiTra";
            btnDoiTra.Size = new Size(152, 41);
            btnDoiTra.TabIndex = 58;
            btnDoiTra.Text = "Thống Kê";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(974, 28);
            menuStrip1.TabIndex = 57;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(63, 24);
            userToolStripMenuItem.Text = "User : ";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 616);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(btnDoiTra);
            Controls.Add(menuStrip1);
            Name = "frmThongKe";
            Text = "frmThongKe";
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem quảnLýKhuyếnMạiToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem tHêToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimeTKEnd;
        private Button button1;
        private DateTimePicker dateTimeTKStart;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private Label btnDoiTra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem couponToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}