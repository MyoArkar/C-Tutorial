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
using OJT.App.Views.Student;
using OJT.Entities.Course;
using OJT.Services;
using OJT.Services.Course;

namespace OJT.App.Views.Course
{
    public partial class UCCourse : UserControl
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GAIQ5AI;Initial Catalog=StudentDB;Integrated Security=True");
        SqlDataAdapter adapt;
        public string ID = string.Empty;
        CourseService courseService = new CourseService();  
        UCCourseList uCCourseList = new UCCourseList();
        public UCCourse()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            if (txt_cname.Text=="" || txt_chour.Text=="" || txt_price.Text=="" || txt_desc.Text=="")
            {
                if (txt_cname.Text == "")
                {
                    txt_cname.Focus();
                    MessageBox.Show("Fill Course Name");
                }
                if (txt_chour.Text == "")
                {
                    txt_chour.Focus();
                    MessageBox.Show("Fill Course Hour");
                }
                if (txt_price.Text == "")
                {
                    txt_price.Focus();
                    MessageBox.Show("Fill Course Price");
                }
                if (txt_desc.Text == "")
                {
                    txt_desc.Focus();
                    MessageBox.Show("Fill Course Description");
                }
            }
            else
            {
                AddorUpdate();
            }
            
        }

        private void AddorUpdate()
        {
            CourseService courseService = new CourseService();
            CourseEntity courseEntity = CreateData();
            bool success = false;
            
            if (btn_addnew.Text == "Add New")
            {
                
                success = courseService.Insert(courseEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
               success = courseService.Update(courseEntity);
               if (success)
               {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
           }
            this.Controls.Clear();
            this.Controls.Add(uCCourseList);
        }
        private CourseEntity CreateData()
        {

            CourseEntity courseEntity = new CourseEntity();
            if (String.IsNullOrEmpty(ID))
            {
                string query = "SELECT TOP 1 course_id FROM course_tb ORDER BY course_id DESC";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = reader[0].ToString();
                }
                conn.Close();
                reader.Close();
                courseEntity.courseId = (Convert.ToInt32(ID) + 1);
            }
            else
           {
               courseEntity.courseId = Convert.ToInt32(ID);
            }

            courseEntity.courseName = txt_cname.Text;
            courseEntity.courseHour = Convert.ToInt32(txt_chour.Text);
            courseEntity.startDate = Convert.ToDateTime(dtp_sdate.Text);
            courseEntity.endDate = Convert.ToDateTime(dtp_edate.Text);
            courseEntity.coursePrice = Convert.ToInt32(txt_price.Text);
            courseEntity.description = txt_desc.Text;


            return courseEntity;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool success = courseService.Delete(Convert.ToInt32(ID));
            if (success)
            {
                MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
            }
            this.Controls.Clear();
            this.Controls.Add(uCCourseList);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(uCCourseList);
        }

        private void UCCourse_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }

        private void BindData()
        {
            if (!String.IsNullOrEmpty(ID))
            {
                DataTable dt = courseService.Get(Convert.ToInt32(ID));

                if (dt.Rows.Count > 0)
                {
                    txt_cname.Text = dt.Rows[0]["course_name"].ToString();
                    txt_chour.Text = dt.Rows[0]["course_hours"].ToString();
                    dtp_sdate.Text = dt.Rows[0]["start_date"].ToString();
                    dtp_edate.Text = dt.Rows[0]["end_date"].ToString();
                    txt_price.Text = dt.Rows[0]["course_price"].ToString();
                    txt_desc.Text = dt.Rows[0]["course_description"].ToString();

                    
                }

            }


        }
        private void BtnControl()
        {
            if (String.IsNullOrEmpty(ID))
            {
                btn_addnew.Text = "Add New";
                btn_delete.Enabled = false;
            }
            else
            {
                btn_addnew.Text = "Update";
                btn_delete.Enabled = true;
            }
        }
    }
}
