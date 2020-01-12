namespace nghichchodochan
{
    partial class FLogin
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
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblTenDangnhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.ptbLogin = new System.Windows.Forms.PictureBox();
            this.grbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangnhap.Location = new System.Drawing.Point(410, 111);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(189, 44);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(296, 20);
            this.txtuserName.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(189, 85);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(296, 20);
            this.txtPassWord.TabIndex = 2;
            // 
            // lblTenDangnhap
            // 
            this.lblTenDangnhap.AutoSize = true;
            this.lblTenDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangnhap.Location = new System.Drawing.Point(6, 38);
            this.lblTenDangnhap.Name = "lblTenDangnhap";
            this.lblTenDangnhap.Size = new System.Drawing.Size(177, 25);
            this.lblTenDangnhap.TabIndex = 2;
            this.lblTenDangnhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(62, 78);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(116, 25);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(329, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.Color.Pink;
            this.grbLogin.Controls.Add(this.lblTenDangnhap);
            this.grbLogin.Controls.Add(this.lblMatKhau);
            this.grbLogin.Controls.Add(this.btnDangnhap);
            this.grbLogin.Controls.Add(this.btnExit);
            this.grbLogin.Controls.Add(this.txtPassWord);
            this.grbLogin.Controls.Add(this.txtuserName);
            this.grbLogin.Location = new System.Drawing.Point(209, 333);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(499, 139);
            this.grbLogin.TabIndex = 6;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Đăng Nhập";
            // 
            // ptbLogin
            // 
            this.ptbLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ptbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbLogin.Image = global::nghichchodochan.Properties.Resources.Login_2;
            this.ptbLogin.Location = new System.Drawing.Point(12, 9);
            this.ptbLogin.Name = "ptbLogin";
            this.ptbLogin.Size = new System.Drawing.Size(872, 540);
            this.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogin.TabIndex = 5;
            this.ptbLogin.TabStop = false;
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(894, 560);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.ptbLogin);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblTenDangnhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox ptbLogin;
        private System.Windows.Forms.GroupBox grbLogin;
    }
}