using OJT.Services.Course;
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
using OJT.Services.Enrollment;
using OJT.App.Views.Course;
using OJT.Entities.Course;
using OJT.Entities.Enrollment;
using OJT.App.Views.Student;

namespace OJT.App.Views.Enrollment
{
    public partial class UCEnrollment : UserControl
    {
        public int student_id = 0;
        public int course_id = 0;
        EnrollmentService enrollmentService= new EnrollmentService();
        CourseService courseService = new CourseService();
        UCEnrollmentList ucenrollmentList = new UCEnrollmentList();
        public UCEnrollment()
        {
            InitializeComponent();
        }

        private void UCEnrollment_Load(object sender, EventArgs e)
        {
            
            BindData();
            BtnControl();
        }
        private void BindData()
        {
            DataTable dt = courseService.GetAll();
            dgv_courseLIst.DataSource = dt;
            if (student_id!=0)
            {
                txt_studentid.Text=student_id.ToString();
                DataTable dtb = enrollmentService.Get(student_id);

                if (dtb.Rows.Count > 0)
                {
                    int cid= Convert.ToInt32(dtb.Rows[0]["course_id"]);
                    DataTable dtc = courseService.Get(cid);
                    if(dtc.Rows.Count > 0)
                    {
                        txt_cname.Text = dtc.Rows[0]["course_name"].ToString();
                    }
                   



                }
            }


        }
        private void BtnControl()
        {
            DataTable dtb = enrollmentService.Get(student_id);
            if (dtb.Rows.Count > 0)
            {
                btn_enroll.Text = "Update";
            }
            else
            {
                btn_enroll.Text = "Enroll";
            }
        }

        private void dgv_courseLIst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_courseLIst.CurrentCell.ColumnIndex.Equals(1) || dgv_courseLIst.CurrentCell.ColumnIndex.Equals(0))
            {
                string cname = Convert.ToString(dgv_courseLIst.Rows[e.RowIndex].Cells["gc_name"].Value);
                course_id= Convert.ToInt32(dgv_courseLIst.Rows[e.RowIndex].Cells["gc_id"].Value);
                txt_cname.Text = cname; 
            }
        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            if (txt_cname.Text == "")
            {
                txt_cname.Focus();
                MessageBox.Show("Select Course");
            }
            else
            {
                AddorUpdate();
                
            }
            
        }
        private void AddorUpdate()
        {
            EnrollmentService enrollmentService = new EnrollmentService();
            EnrollmentEntity enrollmentEntity = CreateData();
            bool success = false;
            DataTable dtb = enrollmentService.Get(student_id);

            if (dtb.Rows.Count > 0)
            {

                success = enrollmentService.Update(enrollmentEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = enrollmentService.Insert(enrollmentEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }

            }
            this.Controls.Clear();
            this.Controls.Add(ucenrollmentList);
        }
        private EnrollmentEntity CreateData()
        {

            EnrollmentEntity enrollmentEntity = new EnrollmentEntity();
            if(student_id != 0)
            {
                
                                
                enrollmentEntity.courseId = course_id;
                enrollmentEntity.studentId = student_id;
                enrollmentEntity.enrollmentdate = DateTime.Now;
            }
            
            return enrollmentEntity;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UCStudentList uCStudentList = new UCStudentList();
            this.Controls.Clear();
            this.Controls.Add(uCStudentList);
        }
    }
}
