using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tutorial5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "^[a-zA-Z0-9][a-zA-Z0-9_\\-]{0,4}[a-zA-Z0-9]$";
            string pass = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";


            Regex re = new Regex(user);
            Regex re1 = new Regex(pass);

            String str_Uid = txt_Uid.Text;
            String str_Pwd = EncodePasswordToBase64(txt_Pwd.Text);

            conn.Open();
            String query = "SELECT * FROM m_user WHERE user_id = '"+str_Uid+"' AND password = '"+str_Pwd+"'";
            SqlCommand command;
            SqlDataReader dataReader;
            
            command = new SqlCommand(query, conn);
            dataReader = command.ExecuteReader();

            if (!re.IsMatch(txt_Uid.Text) || !re1.IsMatch(txt_Pwd.Text))
            {
                if (!re.IsMatch(txt_Uid.Text))
                {

                    MessageBox.Show("Fill Valid User ID");
                }

                if (!re1.IsMatch(txt_Pwd.Text))
                {

                    MessageBox.Show("Password with \nAt least one lower case letter,\nAt least one upper case letter,\nAt least special character,\nAt least one number\nAt least 8 characters length");
                }
            }
            else
            {
                while (dataReader.Read())
                {
                    if (str_Uid == Convert.ToString(dataReader.GetValue(0)) && str_Pwd == Convert.ToString(dataReader.GetValue(2)))
                    {
                        SetValueForText1 = txt_Uid.Text;
                        SetValueForText2 = txt_Pwd.Text;
                        UserForm frm3 = new UserForm();
                        frm3.Show();
                    }
                }
            }
            
            conn.Close();
            dataReader.Close();
            command.Dispose();
        }
            
    }
}
