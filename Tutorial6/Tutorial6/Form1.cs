using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        DataClasses1DataContext db = new DataClasses1DataContext();

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            String str_Uid = txt_uid.Text;
            String str_Pwd = EncodePasswordToBase64(txt_pwd.Text);
            if (str_Uid =="" || str_Pwd =="")
            {
                if (str_Uid == "")
                {

                    MessageBox.Show("Fill User ID");
                }

                if (str_Pwd == "")
                {

                    MessageBox.Show("Fill Password");
                }
            }
            else
            {
                var data = (from s in db.m_users where s.user_id == Convert.ToInt64(str_Uid) select s).First();
                if (data.user_id == Convert.ToInt64(str_Uid) && data.password == str_Pwd)
                {
                    MessageBox.Show("Success login.");
                    SetValueForText1 = txt_uid.Text;
                    SetValueForText2 = txt_pwd.Text;
                    UserForm frm2 = new UserForm();
                    frm2.Show();
                }
                else
                {
                    if (data.user_id != Convert.ToInt64(str_Uid))
                    {
                        MessageBox.Show("User Not Found");
                    }
                    if (data.password != str_Pwd)
                    {
                        MessageBox.Show("Worng Password");
                    }
                }
            }

        }
    }
}
