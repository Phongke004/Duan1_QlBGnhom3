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
            txtPassWord = new TextBox();
            lbQuenMk = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(195, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(452, 320);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 20);
            label1.Name = "label1";
            label1.Size = new Size(273, 61);
            label1.TabIndex = 2;
            label1.Text = "Đăng nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 116);
            label2.Name = "label2";
            label2.Size = new Size(143, 33);
            label2.TabIndex = 3;
            label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 189);
            label3.Name = "label3";
            label3.Size = new Size(137, 33);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu :";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(213, 116);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(489, 41);
            txtUser.TabIndex = 5;
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(213, 192);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(489, 41);
            txtPassWord.TabIndex = 6;
            // 
            // lbQuenMk
            // 
            lbQuenMk.AutoSize = true;
            lbQuenMk.Font = new Font("Times New Roman", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuenMk.Location = new Point(611, 396);
            lbQuenMk.Name = "lbQuenMk";
            lbQuenMk.Size = new Size(136, 23);
            lbQuenMk.TabIndex = 7;
            lbQuenMk.Text = "Quên mật khẩu";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbQuenMk);
            Controls.Add(txtPassWord);
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
        private TextBox txtPassWord;
        private Label lbQuenMk;
    }
}