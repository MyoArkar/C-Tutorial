namespace Tutorial7
{
    partial class Login
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
            this.lbl_uid = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Location = new System.Drawing.Point(199, 122);
            this.lbl_uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(80, 25);
            this.lbl_uid.TabIndex = 0;
            this.lbl_uid.Text = "User ID";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(199, 245);
            this.lbl_pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(153, 25);
            this.lbl_pwd.TabIndex = 1;
            this.lbl_pwd.Text = "User Password";
            // 
            // txt_uid
            // 
            this.txt_uid.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_uid.Location = new System.Drawing.Point(413, 120);
            this.txt_uid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(268, 33);
            this.txt_uid.TabIndex = 2;
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_pwd.Location = new System.Drawing.Point(413, 242);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(268, 33);
            this.txt_pwd.TabIndex = 3;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Wheat;
            this.btn_login.Location = new System.Drawing.Point(549, 346);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 62);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 562);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_uid);
            this.Font = new System.Drawing.Font("Roboto", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_login;
    }
}

