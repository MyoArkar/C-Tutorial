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
using Microsoft.Office.Interop.Excel;
using OJT.Entities.Course;
using System.Data.SqlClient;

namespace OJT.App.Views.Course
{
    public partial class UCCourseList : UserControl
    {
        public string ID = string.Empty;
        private CourseService courseService = new CourseService();
        public UCCourseList()
        {
            InitializeComponent();
        }

        private void UCCourseList_Load(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                btn_import.Enabled = false;
            }
            BindGrid();
        }
        private void BindGrid()
        {
            System.Data.DataTable dt = courseService.GetAll();
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
            FrmMenu main = System.Windows.Forms.Application.OpenForms["FrmMenu"] != null ? (FrmMenu)System.Windows.Forms.Application.OpenForms["FrmMenu"] : null;
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

        private void btn_export_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Worksheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CourseList";

            for (int i = 1; i <= dgvCourseList.Columns.Count - 1; i++)
            {
                worksheet.Cells[1, i] = dgvCourseList.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvCourseList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCourseList.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvCourseList.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Courseoutput";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = txtFileName.Text;
            fdlg.Filter = "Excel Sheet(*.xls; *.xlsx)|*.xls; *.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fdlg.FileName;
                btn_import.Enabled = true;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {   CourseEntity courseEntity = new CourseEntity();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;


            wb = excel.Workbooks.Open(txtFileName.Text);
            ws = wb.Worksheets[1];
            Range range = ws.UsedRange;

            
            bool success = false;
            if (Convert.ToString(ws.Cells[1, 1].Value) == "course_id")
            {
                for (int i = 2; i < range.Rows.Count + 1; i++)
                {
                    for (int j = 1; j < range.Columns.Count + 1; j++)
                    {

                        switch (j)
                        {
                            case 1: courseEntity.courseId = Convert.ToInt32(ws.Cells[i, j].Value); break;
                            case 2: courseEntity.courseName = Convert.ToString(ws.Cells[i, j].Value); break;
                            case 3: courseEntity.courseHour = Convert.ToInt32(ws.Cells[i, j].Value); break;
                            case 4: courseEntity.startDate = Convert.ToDateTime(Convert.ToString(ws.Cells[i, j].Value)); break;
                            case 5: courseEntity.endDate = Convert.ToDateTime(Convert.ToString(ws.Cells[i, j].Value)); break;
                            case 6: courseEntity.coursePrice = Convert.ToInt32(ws.Cells[i, j].Value); break;
                            case 7: courseEntity.description = Convert.ToString(ws.Cells[i, j].Value); break;
                        }

                        

                    }
                    System.Data.DataTable dt = courseService.Get(courseEntity.courseId);
                    if (dt.Rows.Count > 0)
                    {
                        success = courseService.Update(courseEntity);


                    }
                    else
                    {
                        success = courseService.Insert(courseEntity);

                    }
                }
            }
            else
            {
                MessageBox.Show("Select CourseList File");
            }
            
            if (success)
            {
                MessageBox.Show("Data Insert Successfully");
            }
            this.Controls.Clear();
            UCCourseList uCCourseList = new UCCourseList();
            this.Controls.Add(uCCourseList);
        }
    }
}