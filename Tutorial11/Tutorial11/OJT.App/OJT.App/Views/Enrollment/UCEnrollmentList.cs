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
using Microsoft.Office.Interop.Excel;

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
            System.Data.DataTable dt = enrollmentService.GetAll();
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Worksheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "EnrollmentList";

            for (int i = 1; i <= dgvEnrollList.Columns.Count -1; i++)
            {
                worksheet.Cells[1, i] = dgvEnrollList.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvEnrollList.Rows.Count-1; i++)
            {
               for (int j = 0; j < dgvEnrollList.Columns.Count; j++)
                {
                   worksheet.Cells[i + 2, j + 1] = dgvEnrollList.Rows[i].Cells[j].Value.ToString();
                }
           }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "enrollmentoutput";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
