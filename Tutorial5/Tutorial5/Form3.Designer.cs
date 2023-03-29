namespace Tutorial5
{
    partial class UserForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_addr = new System.Windows.Forms.RichTextBox();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Uid
            // 
            this.lbl_Uid.AutoSize = true;
            this.lbl_Uid.Location = new System.Drawing.Point(348, 13);
            this.lbl_Uid.Name = "lbl_Uid";
            this.lbl_Uid.Size = new System.Drawing.Size(58, 20);
            this.lbl_Uid.TabIndex = 0;
            this.lbl_Uid.Text = "UserId";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(163, 85);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(94, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "User Name";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(163, 164);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(83, 20);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(320, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(179, 27);
            this.txt_name.TabIndex = 3;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(320, 164);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(179, 27);
            this.txt_pwd.TabIndex = 4;
            // 
            // txt_addr
            // 
            this.txt_addr.Location = new System.Drawing.Point(320, 257);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(179, 96);
            this.txt_addr.TabIndex = 5;
            this.txt_addr.Text = "";
            // 
            // lbl_addr
            // 
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(163, 257);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(71, 20);
            this.lbl_addr.TabIndex = 6;
            this.lbl_addr.Text = "Address";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(620, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(620, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(330, 376);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(131, 40);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_addr);
            this.Controls.Add(this.txt_addr);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Uid);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Uid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.RichTextBox txt_addr;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btn_submit;
    }
}