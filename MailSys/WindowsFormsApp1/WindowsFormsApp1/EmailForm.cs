using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_email : Form
    {
        public string attachment = String.Empty;
        public form_email()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(txt_to.Text==string.Empty || txt_subject.Text==string.Empty || rtxt_body.Text==string.Empty)
            {
                if(txt_to.Text == string.Empty)
                {
                    MessageBox.Show("Fill to-gmail");
                    txt_to.Focus();
                    return;
                }
                if (txt_subject.Text == string.Empty)
                {
                    MessageBox.Show("Subject is Require");
                    txt_subject.Focus();
                    return;
                }
                if (rtxt_body.Text == string.Empty)
                {
                    MessageBox.Show("Body is Require");
                    rtxt_body.Focus();
                    return;
                }
            }
            else
            {
                try
                {
                    MailMessage messsage = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    messsage.From = new MailAddress(txt_from.Text);
                    messsage.To.Add(new MailAddress(txt_to.Text));
                    messsage.Subject = txt_subject.Text;
                    messsage.Body = rtxt_body.Text;
                    messsage.Attachments.Add(new Attachment(attachment));

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("csharptestacc@gmail.com", "raleglpneocchwvv");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(messsage);
                    MessageBox.Show("Sent Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("err: " + ex.Message);
                }
            }
            
        }

        private void form_email_Load(object sender, EventArgs e)
        {
            txt_from.Text = "csharptestacc@gmail.com";
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                attachment = opd.FileName;
                txt_attachement.Text = attachment;
                

            }
        }
    }
}
