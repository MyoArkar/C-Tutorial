using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        public static SqlCommand command;
        public static SqlDataReader dataReader;
        public static String SetValueForUid="";
        public static String SetValueForName = "";
        public static String SetValueForPassword= "";
        public static String SetValueForAddr = "";
        public static String SetValueForGender = "";
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
        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            String str_Uid = txt_uid.Text;
            String str_Pwd = EncodePasswordToBase64(txt_pwd.Text);

            
            String query = "SELECT * FROM m_user WHERE user_id = '" + str_Uid + "' AND password = '" + str_Pwd + "'";
            

            command = new SqlCommand(query, conn);
            dataReader = command.ExecuteReader();

            if (str_Uid == "" || str_Pwd == "")
            {
                if (str_Uid == "")
                {
                    txt_uid.Focus();
                    MessageBox.Show("Fill User ID");
                }

                if (str_Pwd == "")
                {
                    txt_pwd.Focus();
                    MessageBox.Show("Fill Password");
                }
            }
            else
            {
                while (dataReader.Read())
                {
                    if (str_Uid == Convert.ToString(dataReader.GetValue(0)) && str_Pwd == Convert.ToString(dataReader.GetValue(2)))
                    {
                        SetValueForUid = Convert.ToString(dataReader.GetValue(0));
                        SetValueForName = Convert.ToString(dataReader.GetValue(1));
                        SetValueForPassword = Convert.ToString(dataReader.GetValue(2));
                        SetValueForAddr = Convert.ToString(dataReader.GetValue(4));
                        SetValueForGender = Convert.ToString(dataReader.GetValue(3));
                        
                    }
                }
                if(str_Uid == SetValueForUid && str_Pwd == SetValueForPassword)
                {
                    MessageBox.Show("Login Success");
                    UserForm frm3 = new UserForm();
                    frm3.Show();
                }
                else
                {
                    if(str_Uid != SetValueForUid)
                    {
                        txt_uid.Focus();
                        MessageBox.Show("User Not Found");
                    }
                    if(str_Uid != SetValueForPassword)
                    {   
                        txt_pwd.Focus();
                        MessageBox.Show("Wrong Password");
                    }

                }
            }
            conn.Close();
            dataReader.Close();
            command.Dispose();

        }

        
    }
}
