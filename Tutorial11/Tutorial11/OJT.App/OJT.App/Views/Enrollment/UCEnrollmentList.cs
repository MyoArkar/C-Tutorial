using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OJT.App.Views.Course;
using OJT.App.Views.Menu;
using OJT.Services.Course;
using OJT.Services.Enrollment;

namespace OJT.App.Views.Enrollment
{
    public partial class UCEnrollmentList : UserControl
    {   
        private EnrollmentService enrollmentService = new EnrollmentService();
        public UCEnrollmentList()
        {
            InitializeComponent();
        }

        private void UCEnrollmentList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DataTable dt = enrollmentService.GetAll();
            dgvEnrollList.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dgvEnrollList.Columns.Add(btn);
        }

        private void dgvEnrollList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEnrollList.CurrentCell.ColumnIndex.Equals(4))
            {
                int id = Convert.ToInt32(dgvEnrollList.Rows[e.RowIndex].Cells["gc_id"].Value);
                bool success = enrollmentService.Delete(id);
                if (success)
                {
                    MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                }
                this.Controls.Clear();
                UCEnrollmentList uCEnrollmentList = new UCEnrollmentList();
                this.Controls.Add(uCEnrollmentList);
            }
        }
    }
}
