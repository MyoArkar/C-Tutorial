namespace WindowsFormsApp1
{
    partial class form_email
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
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.lbl_attachment = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_attachement = new System.Windows.Forms.TextBox();
            this.rtxt_body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btn_send.Location = new System.Drawing.Point(388, 531);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(172, 90);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(117, 35);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(73, 37);
            this.lbl_from.TabIndex = 1;
            this.lbl_from.Text = "From";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(117, 125);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(43, 37);
            this.lbl_to.TabIndex = 2;
            this.lbl_to.Text = "To";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(117, 201);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(94, 37);
            this.lbl_subject.TabIndex = 3;
            this.lbl_subject.Text = "Subject";
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(117, 318);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(70, 37);
            this.lbl_body.TabIndex = 4;
            this.lbl_body.Text = "Body";
            // 
            // lbl_attachment
            // 
            this.lbl_attachment.AutoSize = true;
            this.lbl_attachment.Location = new System.Drawing.Point(107, 460);
            this.lbl_attachment.Name = "lbl_attachment";
            this.lbl_attachment.Size = new System.Drawing.Size(145, 37);
            this.lbl_attachment.TabIndex = 5;
            this.lbl_attachment.Text = "Attachment";
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btn_browse.Location = new System.Drawing.Point(672, 456);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(125, 45);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_from
            // 
            this.txt_from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_from.Location = new System.Drawing.Point(294, 35);
            this.txt_from.Name = "txt_from";
            this.txt_from.ReadOnly = true;
            this.txt_from.Size = new System.Drawing.Size(340, 45);
            this.txt_from.TabIndex = 7;
            // 
            // txt_to
            // 
            this.txt_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_to.Location = new System.Drawing.Point(294, 116);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(340, 45);
            this.txt_to.TabIndex = 8;
            // 
            // txt_subject
            // 
            this.txt_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_subject.Location = new System.Drawing.Point(294, 192);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(340, 45);
            this.txt_subject.TabIndex = 9;
            // 
            // txt_attachement
            // 
            this.txt_attachement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_attachement.Location = new System.Drawing.Point(294, 455);
            this.txt_attachement.Name = "txt_attachement";
            this.txt_attachement.ReadOnly = true;
            this.txt_attachement.Size = new System.Drawing.Size(340, 45);
            this.txt_attachement.TabIndex = 10;
            // 
            // rtxt_body
            // 
            this.rtxt_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.rtxt_body.Location = new System.Drawing.Point(294, 275);
            this.rtxt_body.Name = "rtxt_body";
            this.rtxt_body.Size = new System.Drawing.Size(340, 137);
            this.rtxt_body.TabIndex = 11;
            this.rtxt_body.Text = "";
            // 
            // form_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(151)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1316, 959);
            this.Controls.Add(this.rtxt_body);
            this.Controls.Add(this.txt_attachement);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.lbl_attachment);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.btn_send);
            this.Font = new System.Drawing.Font("Segoe Print", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(13)))), ((int)(((byte)(117)))));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "form_email";
            this.Text = "EmailForm";
            this.Load += new System.EventHandler(this.form_email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_attachment;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_attachement;
        private System.Windows.Forms.RichTextBox rtxt_body;
    }
}

