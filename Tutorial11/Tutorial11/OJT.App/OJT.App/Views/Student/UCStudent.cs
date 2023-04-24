using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OJT.Entities.Student;
using OJT.Services;
using System.Configuration;

namespace OJT.App.Views.Student
{
    public partial class UCStudent : UserControl
    {
       public static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();
        public static  SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter adapt;
        String rdbtnValue = "";
        public byte[] pic = null;
        public string ID = string.Empty;
        StudentService studentService = new StudentService();
        UCStudentList ucStudentList = new UCStudentList();
        public UCStudent()
        {
            InitializeComponent();
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {   if(txt_fname.Text=="" || txt_lname.Text=="" || (rdbtn_male.Checked==false && rdbtn_female.Checked==false)|| pic==null|| txt_email.Text == "" || txt_phone.Text == "" || txt_addr.Text == "")
            {
                if (txt_fname.Text == "")
                {
                    txt_fname.Focus();
                    MessageBox.Show("Fill First Name");
                    return;
                }
                if (txt_lname.Text == "")
                {
                    txt_lname.Focus();
                    MessageBox.Show("Fill First Last Name");
                    return;
                }
                if ((rdbtn_male.Checked == false && rdbtn_female.Checked == false))
                {
                    rdbtn_male.Focus();
                    rdbtn_female.Focus();
                    MessageBox.Show("Check Gender");
                    return;
                }
                if (pic == null)
                {
                    pbPhoto.Focus();
                    MessageBox.Show("Select Photo");
                    return;
                }
                if (txt_email.Text == "")
                {
                    txt_email.Focus();
                    MessageBox.Show("Fill Email");
                    return;
                }
                if (txt_phone.Text == "")
                {
                    txt_fname.Focus();
                    MessageBox.Show("Fill Phone");
                    return;
                }
                if (txt_addr.Text == "")
                {
                    txt_fname.Focus();
                    MessageBox.Show("Fill Address");
                    return;
                }

            }
            else
            {
                AddorUpdate();
            }
            
        }
        private void AddorUpdate()
        {
            StudentService studentService = new StudentService();
            StudentEntity studentEntity = CreateData();
            bool success = false;

            if (btn_addnew.Text == "Add New")
            {
                success = studentService.Insert(studentEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
           }
           else
            {
                success = studentService.Update(studentEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(ucStudentList);
        }
        private StudentEntity CreateData()
        {
            if (rdbtn_male.Checked == false)
            {
                rdbtnValue = "2";
            }
            else
            {
                rdbtnValue = "1";
            }
           
            StudentEntity studentEntity = new StudentEntity();
            if (String.IsNullOrEmpty(ID))
            {
                string query = "SELECT TOP 1 student_id FROM student_tb ORDER BY student_id DESC";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = reader[0].ToString();
                }
                conn.Close();
                reader.Close();
                studentEntity.studentId = (Convert.ToInt32(ID) + 1);
            }
            else
            {
              studentEntity.studentId = Convert.ToInt32(ID);
            }
            
            studentEntity.firstname = txt_fname.Text;
            studentEntity.lastname = txt_lname.Text;
            studentEntity.photo = pic;
            studentEntity.gender = rdbtnValue;
            studentEntity.dateofbirth = Convert.ToDateTime(dtpDateOfBirth.Text);
            studentEntity.email = txt_email.Text;
            studentEntity.phone = txt_phone.Text;
            studentEntity.address = txt_addr.Text;


            return studentEntity;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool success = studentService.Delete(Convert.ToInt32(ID));
            if (success)
            {
                MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
            }
            this.Controls.Clear();
            this.Controls.Add(ucStudentList);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(ucStudentList);
        }

        private void UCStudent_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
            
        }
        private void BindData()
        {
            if (!String.IsNullOrEmpty(ID))
            {
                DataTable dt = studentService.Get(Convert.ToInt32(ID));

                if (dt.Rows.Count > 0)
                {
                    txt_fname.Text = dt.Rows[0]["first_name"].ToString();
                    txt_lname.Text = dt.Rows[0]["last_name"].ToString();
                    pic = (byte[])dt.Rows[0]["photo"];
                    MemoryStream ba = new MemoryStream(pic);
                    pbPhoto.Image = Image.FromStream(ba);
                    
                    rdbtnValue = dt.Rows[0]["gender"].ToString();
                    dtpDateOfBirth.Text = dt.Rows[0]["date_of_birth"].ToString();
                    txt_email.Text = dt.Rows[0]["email"].ToString();
                    txt_phone.Text = dt.Rows[0]["phone"].ToString();
                    txt_addr.Text = dt.Rows[0]["address"].ToString();

                    if (rdbtnValue == "1")
                    {
                        rdbtn_male.Checked = true;
                    }
                    else
                    {
                        rdbtn_female.Checked = true;
                    }
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
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image files(*.jpg;*.png;*.bmp) | *.jpg;*.png;*.bmp";
            if(opd.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(opd.FileName);
                Image img = pbPhoto.Image;
                pic = converterDemo(img);
                /*using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    pic = ms.ToArray();
                }*/

            }
        }

        
    }
}
