using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        public static String SetValueForUid = "";
        public static String SetValueForPassword = "";


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String str_Uid = txt_uid.Text;
            String str_Pwd = txt_pwd.Text;


            String query = "SELECT * FROM m_user WHERE user_id = '" + str_Uid + "'";


            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader dataReader = command.ExecuteReader();

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
                    if (str_Uid == Convert.ToString(dataReader.GetValue(0)))
                    {
                        SetValueForUid = Convert.ToString(dataReader.GetValue(0));
                        SetValueForPassword = Convert.ToString(dataReader.GetValue(2));
                    }
                }
                if (str_Uid == SetValueForUid && str_Pwd == SetValueForPassword)
                {
                    
                    MessageBox.Show("Login Success");
                    UserForm frm3 = new UserForm();
                    frm3.Show();
                    
                }
                else
                {
                    if (str_Uid != SetValueForUid)
                    {
                        txt_uid.Focus();
                        MessageBox.Show("User Not Found");
                    }
                    if (str_Pwd != SetValueForPassword)
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
