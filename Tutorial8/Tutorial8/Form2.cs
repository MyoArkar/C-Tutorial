﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial8
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        String rdbtnValue = "";
        String counterid = Login.SetValueForUid;
        private void UserForm_Load(object sender, EventArgs e)
        {
            
            txt_uid.Text = Login.SetValueForUid;
            conn.Open();
            String query = "SELECT * FROM m_user WHERE user_id = '" + txt_uid.Text +"'";

            
            SqlCommand command = new SqlCommand(query,conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txt_name.Text = Convert.ToString(dataReader.GetValue(1));
                txt_pwd.Text = Convert.ToString(dataReader.GetValue(2));
                rdbtnValue = Convert.ToString(dataReader.GetValue(3));
                rtxt_addr.Text = Convert.ToString(dataReader.GetValue(4));
            }
            if (rdbtnValue == "1")
            {
                rdbtn_male.Checked= true;
            }
            else
            {
                rdbtn_female.Checked= true;
            }
            if (txt_uid.Text == "")
            {
                btn_delete.Enabled = false;
            }
            conn.Close();
            dataReader.Close();
            command.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_uid.Text = "";
            txt_name.Text = "";
            txt_pwd.Text = "";
            rdbtn_male.Checked = false;
            rdbtn_female.Checked = false;
            rtxt_addr.Text = "";
            MessageBox.Show("Data Cleared");
            btn_delete.Enabled=false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();


            String query = "Delete m_user where user_id ="+ txt_uid.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(query, conn);

            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();


            conn.Close();
            command.Dispose();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
            if (rdbtn_male.Checked == false)
            {
                rdbtnValue = "2";
            }
            else
            {
                rdbtnValue = "1";
            }

            if (txt_uid.Text != counterid)

            {
                counterid = txt_uid.Text;
                
                conn.Open();
                String query = "Insert into m_user values (@user_id,@user_name,@password,@gender,@address)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@user_id", int.Parse(txt_uid.Text));
                command.Parameters.AddWithValue("@user_Name", txt_name.Text);
                command.Parameters.AddWithValue("@password", txt_pwd.Text);
                command.Parameters.AddWithValue("@gender", int.Parse(rdbtnValue));
                command.Parameters.AddWithValue("@address", rtxt_addr.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted");

            }
            else
            {
                conn.Open();
                String query = "Update m_user set user_name=@user_name , password=@password , gender=@gender , address=@address where user_id=@user_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@user_id", int.Parse(txt_uid.Text));
                command.Parameters.AddWithValue("@user_Name", txt_name.Text);
                command.Parameters.AddWithValue("@password", txt_pwd.Text);
                command.Parameters.AddWithValue("@gender", int.Parse(rdbtnValue));
                command.Parameters.AddWithValue("@address", rtxt_addr.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Updated");
            }
        }
    }
}