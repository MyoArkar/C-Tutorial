namespace Tutorial5
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
            this.lbl_Uid = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txt_Uid = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Uid
            // 
            this.lbl_Uid.AutoSize = true;
            this.lbl_Uid.Location = new System.Drawing.Point(175, 75);
            this.lbl_Uid.Name = "lbl_Uid";
            this.lbl_Uid.Size = new System.Drawing.Size(67, 20);
            this.lbl_Uid.TabIndex = 0;
            this.lbl_Uid.Text = "User ID";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(175, 148);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(124, 20);
            this.lbl_Pwd.TabIndex = 1;
            this.lbl_Pwd.Text = "User Password";
            // 
            // txt_Uid
            // 
            this.txt_Uid.Location = new System.Drawing.Point(367, 75);
            this.txt_Uid.Name = "txt_Uid";
            this.txt_Uid.Size = new System.Drawing.Size(180, 27);
            this.txt_Uid.TabIndex = 2;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(367, 140);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(180, 27);
            this.txt_Pwd.TabIndex = 3;
            this.txt_Pwd.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(443, 209);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(104, 44);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_Uid);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Uid);
            this.Name = "Login";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Uid;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txt_Uid;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_Login;
    }
}

