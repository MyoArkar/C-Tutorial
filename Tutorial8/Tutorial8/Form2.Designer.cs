namespace Tutorial8
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
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.rtxt_addr = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Location = new System.Drawing.Point(190, 49);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(78, 25);
            this.lbl_uid.TabIndex = 0;
            this.lbl_uid.Text = "User Id";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(190, 135);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(115, 25);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "User Name";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(190, 216);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(105, 25);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(190, 296);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(79, 25);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(195, 382);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(90, 25);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Address";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(361, 49);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(350, 33);
            this.txt_uid.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(361, 132);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(350, 33);
            this.txt_name.TabIndex = 6;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(361, 216);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(350, 33);
            this.txt_pwd.TabIndex = 7;
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Location = new System.Drawing.Point(404, 306);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(82, 29);
            this.rdbtn_male.TabIndex = 8;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Male";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Location = new System.Drawing.Point(572, 306);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(105, 29);
            this.rdbtn_female.TabIndex = 9;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Female";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // rtxt_addr
            // 
            this.rtxt_addr.Location = new System.Drawing.Point(361, 382);
            this.rtxt_addr.Name = "rtxt_addr";
            this.rtxt_addr.Size = new System.Drawing.Size(350, 96);
            this.rtxt_addr.TabIndex = 10;
            this.rtxt_addr.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(314, 537);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(139, 35);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(489, 536);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 37);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(668, 536);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(139, 36);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 741);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rtxt_addr);
            this.Controls.Add(this.rdbtn_female);
            this.Controls.Add(this.rdbtn_male);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_uid);
            this.Font = new System.Drawing.Font("Roboto", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.RadioButton rdbtn_male;
        private System.Windows.Forms.RadioButton rdbtn_female;
        private System.Windows.Forms.RichTextBox rtxt_addr;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
    }
}