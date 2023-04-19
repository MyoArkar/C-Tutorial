using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OJT.App.Views.Menu;
using OJT.App.Views.Enrollment;
using OJT.Services;
using OJT.Services.Enrollment;

namespace OJT.App.Views.Student
{
    public partial class UCStudentList : UserControl
    {
        private StudentService studentService = new StudentService();
        private EnrollmentService enrollmentService = new EnrollmentService(); 
        public UCStudentList()
        {
            InitializeComponent();
        }

        private void UCStudentList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            DataTable dt = studentService.GetAll();
            dgvStudentList.DataSource = dt;

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Enrollment";
            btn2.Text = "Enroll";
            btn2.Name = "btn2";
            btn2.UseColumnTextForButtonValue = true;
            dgvStudentList.Columns.Add(btn2);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dgvStudentList.Columns.Add(btn);

            
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            UCStudent uCStudent = new UCStudent();
            uCStudent.ID = null;
            FrmMenu main = Application.OpenForms["FrmMenu"] != null ? (FrmMenu)Application.OpenForms["FrmMenu"] : null;
            if(main == null)
            {
                main = new FrmMenu();
            }
            main.pnUC.Controls.Clear();
            main.pnUC.Controls.Add(uCStudent);
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int studentId = Convert.ToInt32(dgvStudentList.Rows[e.RowIndex].Cells["gc_studentid"].Value);
                if (e.ColumnIndex == dgvStudentList.Columns["gc_studentid"].Index)
                {
                    UCStudent ucStudent = new UCStudent();
                    ucStudent.ID = studentId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(ucStudent);

                }
            }
            if(dgvStudentList.CurrentCell.ColumnIndex.Equals(10)) {
                int studentId = Convert.ToInt32(dgvStudentList.Rows[e.RowIndex].Cells["gc_studentid"].Value);
                DataTable dtb = enrollmentService.Get(studentId);
                int e_id = Convert.ToInt32(dtb.Rows[0]["enrollment_id"]);
                bool success = false;
                if (studentService.Delete(studentId) && enrollmentService.Delete(e_id))
                {
                    success = true;
                }
                  
                if (success)
                {
                    MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                }
                this.Controls.Clear();
                UCStudentList ucStudentList = new UCStudentList();
                this.Controls.Add(ucStudentList);
            }
            if (dgvStudentList.CurrentCell.ColumnIndex.Equals(9))
            {
                int studentId = Convert.ToInt32(dgvStudentList.Rows[e.RowIndex].Cells["gc_studentid"].Value);
                
                this.Controls.Clear();
                 UCEnrollment uCEnrollment = new UCEnrollment();
                uCEnrollment.student_id = studentId;
                this.Controls.Add(uCEnrollment);
            }
        }
    }
}
