using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OJT.App.Views.Student;
using OJT.App.Views.Course;
using OJT.App.Views.Enrollment;

namespace OJT.App.Views.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCStudentList ucStudentList = new UCStudentList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(ucStudentList);
        }

        private void crudStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCStudent ucStudent = new UCStudent();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(ucStudent);
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UCCourseList ucCourseList = new UCCourseList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add((ucCourseList));
        }

        private void courseCrudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCourse ucCourse = new UCCourse();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(ucCourse);
        }

        private void enrollmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEnrollmentList uCEnrollmentList = new UCEnrollmentList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCEnrollmentList);
        }
    }
}
