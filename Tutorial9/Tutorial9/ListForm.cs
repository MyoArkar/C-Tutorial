using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        SqlDataAdapter adapt;
        DataTable dt;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_management_system_dbDataSet.m_user' table. You can move, or remove it, as needed.
            this.m_userTableAdapter.Fill(this.user_management_system_dbDataSet.m_user);
            conn.Open();
            adapt = new SqlDataAdapter("select * from m_user", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd= new SqlCommand("select * from m_user where user_id like @user_id or user_name like @user_name or address like @address", conn);
            cmd.Parameters.AddWithValue("@user_id", string.Format("%{0}%", txt_search.Text));
            cmd.Parameters.AddWithValue("@user_Name", string.Format("%{0}%", txt_search.Text));
            cmd.Parameters.AddWithValue("@address", string.Format("%{0}%", txt_search.Text));
            adapt = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapt.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                conn.Close();
                MessageBox.Show("data exist");
            }
            else
            {
                conn.Close();
                MessageBox.Show("data not found");
            }
        }
    }
}
