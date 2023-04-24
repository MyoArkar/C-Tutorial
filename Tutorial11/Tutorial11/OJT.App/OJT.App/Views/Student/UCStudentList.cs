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
using Microsoft.Office.Interop.Excel;
using OJT.Entities.Student;
using OJT.App.Views.Course;
using OJT.Entities.Course;
using OJT.Services.Course;

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
            if (txtFileName.Text == "")
            {
                btn_import.Enabled = false;
            }
            BindGrid();
        }
        private void BindGrid()
        {
            System.Data.DataTable dt = studentService.GetAll();
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
            FrmMenu main = System.Windows.Forms.Application.OpenForms["FrmMenu"] != null ? (FrmMenu)System.Windows.Forms.Application.OpenForms["FrmMenu"] : null;
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
                System.Data.DataTable dtb = enrollmentService.Get(studentId);
                int e_id = 0;
                if(dtb.Rows.Count > 0)
                {
                     e_id = Convert.ToInt32(dtb.Rows[0]["enrollment_id"]);
                }
                
                bool success = false;
                if (studentId != 0)
                {   
                    if(e_id != 0)
                    {
                        enrollmentService.Delete(e_id);
                    }
                    studentService.Delete(studentId);
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Worksheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "StudentList";

            for(int i = 1; i <= dgvStudentList.Columns.Count-2; i++) 
            {
                worksheet.Cells[1, i] = dgvStudentList.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < dgvStudentList.Rows.Count; i++)
            {
                for(int j = 0; j < dgvStudentList.Columns.Count-2; j++)
                {
                    worksheet.Cells[i+2, j+1] = dgvStudentList.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Studentoutput";
            saveFileDialoge.DefaultExt = ".xlsx";
            if(saveFileDialoge.ShowDialog() == DialogResult.OK)
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
        {
            StudentEntity studentEntity = new StudentEntity();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;


            wb = excel.Workbooks.Open(txtFileName.Text);
            ws = wb.Worksheets[1];
            Range range = ws.UsedRange;

            bool success = false;
            if (Convert.ToString(ws.Cells[1, 1].Value) == "student_id")
            {
                for (int i = 2; i < range.Rows.Count + 1; i++)
                {
                for (int j = 1; j < range.Columns.Count + 1; j++)
                {

                switch (j)
                {
                  case 1: studentEntity.studentId = Convert.ToInt32(ws.Cells[i, j].Value); break;
                  case 2: studentEntity.firstname = Convert.ToString(ws.Cells[i, j].Value); break;
                  case 3: studentEntity.lastname = Convert.ToString(ws.Cells[i, j].Value); break;
                  //case 4: studentEntity.photo = (byte[])(Convert.ToString(ws.Cells[i,j].value));break;
                  case 5: studentEntity.gender = Convert.ToString(ws.Cells[i, j].Value); break;
                 case 6: studentEntity.dateofbirth = Convert.ToDateTime(Convert.ToString(ws.Cells[i, j].Value)); break;
                 case 7: studentEntity.email = Convert.ToString(ws.Cells[i, j].Value); break;
                 case 8: studentEntity.phone = Convert.ToString(ws.Cells[i, j].Value); break;
                 case 9: studentEntity.address = Convert.ToString(ws.Cells[i, j].Value); break;
                }



                }
                System.Data.DataTable dt = studentService.Get(studentEntity.studentId);
                if (dt.Rows.Count > 0)
                {
                        //success = studentService.Update1studentEntity);
                        success = studentService.Update1(studentEntity);


                }
                else
                {
                        //success = studentService.Insert(studentEntity);
                        success = studentService.Insert1(studentEntity);

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
            UCStudentList uCStudentList = new UCStudentList();
            this.Controls.Add(uCStudentList);
        }

       
    }
    
}
