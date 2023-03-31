namespace Tutorial7
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
            this.lbl_uid = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.rtxt_addr = new System.Windows.Forms.RichTextBox();
            this.gbox_gender = new System.Windows.Forms.GroupBox();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbox_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Location = new System.Drawing.Point(397, 48);
            this.lbl_uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(80, 25);
            this.lbl_uid.TabIndex = 0;
            this.lbl_uid.Text = "User ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(131, 122);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(115, 25);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "User Name";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(131, 202);
            this.lbl_pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(105, 25);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_addr
            // 
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(131, 280);
            this.lbl_addr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(90, 25);
            this.lbl_addr.TabIndex = 3;
            this.lbl_addr.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_name.Location = new System.Drawing.Point(281, 122);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(282, 33);
            this.txt_name.TabIndex = 4;
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_pwd.Location = new System.Drawing.Point(281, 202);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.ReadOnly = true;
            this.txt_pwd.Size = new System.Drawing.Size(282, 33);
            this.txt_pwd.TabIndex = 5;
            // 
            // rtxt_addr
            // 
            this.rtxt_addr.BackColor = System.Drawing.Color.Cornsilk;
            this.rtxt_addr.Location = new System.Drawing.Point(281, 280);
            this.rtxt_addr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_addr.Name = "rtxt_addr";
            this.rtxt_addr.ReadOnly = true;
            this.rtxt_addr.Size = new System.Drawing.Size(282, 119);
            this.rtxt_addr.TabIndex = 6;
            this.rtxt_addr.Text = "";
            // 
            // gbox_gender
            // 
            this.gbox_gender.Controls.Add(this.rdbtn_female);
            this.gbox_gender.Controls.Add(this.rdbtn_male);
            this.gbox_gender.Location = new System.Drawing.Point(656, 122);
            this.gbox_gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_gender.Name = "gbox_gender";
            this.gbox_gender.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_gender.Size = new System.Drawing.Size(259, 158);
            this.gbox_gender.TabIndex = 7;
            this.gbox_gender.TabStop = false;
            this.gbox_gender.Text = "Gender";
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Location = new System.Drawing.Point(29, 49);
            this.rdbtn_male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(82, 29);
            this.rdbtn_male.TabIndex = 0;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Male";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Location = new System.Drawing.Point(29, 105);
            this.rdbtn_female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(105, 29);
            this.rdbtn_female.TabIndex = 1;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Female";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(402, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbox_gender);
            this.Controls.Add(this.rtxt_addr);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_addr);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_uid);
            this.Font = new System.Drawing.Font("Roboto", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserForm_Load_1);
            this.gbox_gender.ResumeLayout(false);
            this.gbox_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.RichTextBox rtxt_addr;
        private System.Windows.Forms.GroupBox gbox_gender;
        private System.Windows.Forms.RadioButton rdbtn_female;
        private System.Windows.Forms.RadioButton rdbtn_male;
        private System.Windows.Forms.Button button1;
    }
}