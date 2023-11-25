namespace PRL.View
{
    partial class frmDoiMatKhau
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnXacNhanDoiMK = new Button();
            thoát = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 24);
            label1.Name = "label1";
            label1.Size = new Size(329, 61);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 118);
            label2.Name = "label2";
            label2.Size = new Size(128, 33);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 199);
            label3.Name = "label3";
            label3.Size = new Size(177, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu cũ : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 285);
            label4.Name = "label4";
            label4.Size = new Size(189, 33);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(313, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 41);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(314, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(442, 41);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(316, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 41);
            textBox3.TabIndex = 6;
            // 
            // btnXacNhanDoiMK
            // 
            btnXacNhanDoiMK.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhanDoiMK.Location = new Point(316, 468);
            btnXacNhanDoiMK.Name = "btnXacNhanDoiMK";
            btnXacNhanDoiMK.Size = new Size(150, 46);
            btnXacNhanDoiMK.TabIndex = 7;
            btnXacNhanDoiMK.Text = "Xác nhận";
            btnXacNhanDoiMK.UseVisualStyleBackColor = true;
            // 
            // thoát
            // 
            thoát.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            thoát.Location = new Point(606, 468);
            thoát.Name = "thoát";
            thoát.Size = new Size(150, 46);
            thoát.TabIndex = 8;
            thoát.Text = "Thoát";
            thoát.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 374);
            label5.Name = "label5";
            label5.Size = new Size(246, 33);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận mật khẩu :";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(320, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(436, 41);
            textBox4.TabIndex = 10;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 564);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(thoát);
            Controls.Add(btnXacNhanDoiMK);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "frmDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnXacNhanDoiMK;
        private Button thoát;
        private Label label5;
        private TextBox textBox4;
    }
}