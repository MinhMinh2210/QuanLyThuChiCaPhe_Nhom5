namespace QuanLyThuChiCaPhe_Nhom5
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.btnQuenMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lbNameHT = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.AutoSize = true;
            this.btnQuenMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQuenMatKhau.ImageOptions.SvgImage")));
            this.btnQuenMatKhau.Location = new System.Drawing.Point(479, 236);
            this.btnQuenMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(115, 36);
            this.btnQuenMatKhau.TabIndex = 20;
            this.btnQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AutoSize = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(134, 103);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(38, 36);
            this.simpleButton2.TabIndex = 19;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(134, 60);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(38, 36);
            this.simpleButton1.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(181, 168);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 36);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Location = new System.Drawing.Point(324, 168);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 36);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Đăng nhập";
            // 
            // lbNameHT
            // 
            this.lbNameHT.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameHT.Appearance.Options.UseFont = true;
            this.lbNameHT.Location = new System.Drawing.Point(166, -2);
            this.lbNameHT.Margin = new System.Windows.Forms.Padding(9);
            this.lbNameHT.Name = "lbNameHT";
            this.lbNameHT.Size = new System.Drawing.Size(283, 29);
            this.lbNameHT.TabIndex = 15;
            this.lbNameHT.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 107);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 21);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(181, 68);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 21);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 278);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbNameHT);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQuenMatKhau;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl lbNameHT;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

