using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial7
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
        private void UserForm_Load_1(object sender, EventArgs e)
        {
            lbl_uid.Text = Login.SetValueForUid;
            txt_name.Text = Login.SetValueForName;
            txt_pwd.Text = DecodeFrom64(Login.SetValueForPassword);
            rtxt_addr.Text = Login.SetValueForAddr;
            if(Login.SetValueForGender == "1")
            {
               rdbtn_male.Checked = true;
            }
            else
            {
                rdbtn_female.Checked = true;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sumbit Button Clicked");
            
        }

        
    }
}
