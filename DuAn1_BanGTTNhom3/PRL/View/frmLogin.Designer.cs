namespace PRL.View
{
    partial class frmLogin
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
            btnLogin = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(218, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(479, 308);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(170, 46);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 18);
            label1.Name = "label1";
            label1.Size = new Size(260, 61);
            label1.TabIndex = 2;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(158, 36);
            label2.TabIndex = 3;
            label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 208);
            label3.Name = "label3";
            label3.Size = new Size(151, 36);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu :";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(215, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(500, 44);
            txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(215, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(503, 44);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(608, 391);
            label4.Name = "label4";
            label4.Size = new Size(159, 27);
            label4.TabIndex = 7;
            label4.Text = "Quên mật khẩu";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label4;
    }
}