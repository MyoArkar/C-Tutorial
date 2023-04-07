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
    }
}
