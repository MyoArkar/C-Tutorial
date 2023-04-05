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

namespace Tutorial10
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=user_management_system_db;Integrated Security=True");
        SqlDataAdapter adapt;
        DataSet dt;

        public static string SetValueForUid = "";
        public static string SetValueForCounter = "";
        int scVal;
        int tindi;
        int cindi;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
            {   SetValueForUid=dataGridView1.CurrentCell.Value.ToString();
                SetValueForCounter= dataGridView1.CurrentCell.Value.ToString();
                UserForm frm= new UserForm();
                this.Hide();
                frm.Show();
                

            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {   
            
            conn.Open();
            
            adapt = new SqlDataAdapter("select * from m_user", conn);
            dt = new DataSet();
            adapt.Fill(dt,scVal,5,"cus");
            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "cus";
            string query = "SELECT Count(*) FROM m_user";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tindi = (Convert.ToInt32(reader[0].ToString()) / 5) +1;

            }
            conn.Close();
            reader.Close();
            cindi = 1;
            lbl_indi.Text = String.Format("{0}/{1}", cindi, tindi);


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from m_user where user_id like @user_id or user_name like @user_name or address like @address", conn);
            cmd.Parameters.AddWithValue("@user_id", string.Format("%{0}%", txt_search.Text));
            cmd.Parameters.AddWithValue("@user_Name", string.Format("%{0}%", txt_search.Text));
            cmd.Parameters.AddWithValue("@address", string.Format("%{0}%", txt_search.Text));
            adapt = new SqlDataAdapter(cmd);
            dt = new DataSet();
            adapt.Fill(dt, scVal, 5, "cus");
            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "cus";
            dataGridView1.DataSource = dt;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tindi +=1;
            }
            tindi = (tindi / 5) + 1;
            cindi = 1;
            lbl_indi.Text = String.Format("{0}/{1}", cindi, tindi);

            conn.Close();
            reader.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = "SELECT Count(*) FROM m_user";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int value= Convert.ToInt32(reader[0].ToString());
                SetValueForUid = Convert.ToString(value+1);
                SetValueForCounter = reader[0].ToString();
            }
            conn.Close();
            reader.Close();
            UserForm frm = new UserForm();
            this.Hide();
            frm.Show();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            scVal = scVal - 5;
            if(scVal <= 0)
            {
                cindi = 1;
                scVal = 0;
            }
            else
            {
               cindi -= 1;
            }
            dt.Clear();
            adapt.Fill(dt,scVal,5,"cus");
            
            lbl_indi.Text = String.Format("{0}/{1}", cindi, tindi);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
            if( cindi!= tindi)
            {
                scVal = scVal + 5;
                dt.Clear();
                adapt.Fill(dt, scVal, 5, "cus");
                cindi += 1;
                lbl_indi.Text = String.Format("{0}/{1}", cindi, tindi);

            }
                
            
            
        }
    }
}
