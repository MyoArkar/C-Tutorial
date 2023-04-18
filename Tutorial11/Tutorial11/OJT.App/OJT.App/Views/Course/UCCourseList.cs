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
using OJT.App.Views.Student;
using OJT.Services;
using OJT.Services.Course;

namespace OJT.App.Views.Course
{
    public partial class UCCourseList : UserControl
    {
        private CourseService courseService = new CourseService();
        public UCCourseList()
        {
            InitializeComponent();
        }

        private void UCCourseList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            DataTable dt = courseService.GetAll();
            dgvCourseList.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dgvCourseList.Columns.Add(btn);
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            UCCourse uCCourse = new UCCourse();
            uCCourse.ID = null;
            FrmMenu main = Application.OpenForms["FrmMenu"] != null ? (FrmMenu)Application.OpenForms["FrmMenu"] : null;
            if (main == null)
            {
                main = new FrmMenu();
            }
            main.pnUC.Controls.Clear();
            main.pnUC.Controls.Add(uCCourse);
        }

        private void dgvCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int courseId = Convert.ToInt32(dgvCourseList.Rows[e.RowIndex].Cells["gc_id"].Value);
                if (e.ColumnIndex == dgvCourseList.Columns["gc_id"].Index)
                {
                    UCCourse uCCourse = new UCCourse();
                    uCCourse.ID = courseId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCCourse);

                }
            }
            if (dgvCourseList.CurrentCell.ColumnIndex.Equals(7))
            {
                int courseId = Convert.ToInt32(dgvCourseList.Rows[e.RowIndex].Cells["gc_id"].Value);
                bool success = courseService.Delete(courseId);
                if (success)
                {
                    MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                }
                this.Controls.Clear();
                UCCourseList uCCourseList = new UCCourseList();
                this.Controls.Add(uCCourseList);
            }
        }
    }
}
