using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Common;
using OJT.Entities.Enrollment;
using System.Collections;


namespace OJT.DAO.Enrollment
{
    public class EnrollmentDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM enrollments_tb ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM enrollments_tb " +
                      "WHERE  student_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(EnrollmentEntity enrollmentEntity)
        {

            strSql = "INSERT INTO enrollments_tb(student_id,course_id,enrollment_date)" +
                     "VALUES(@student_id,@course_id,@enrollment_date)";

            SqlParameter[] sqlParam = { 
                                        new SqlParameter("@student_id", enrollmentEntity.studentId),
                                        new SqlParameter("@course_id", enrollmentEntity.courseId),
                                        new SqlParameter("@enrollment_date", enrollmentEntity.enrollmentdate)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
       
        public bool Update(EnrollmentEntity enrollmentEntity)
        {
            strSql = "UPDATE enrollments_tb SET course_id=@course_id,enrollment_date=@enrollment_date WHERE student_id=@student_id";


            SqlParameter[] sqlParam = {
                                        new SqlParameter("@student_id", enrollmentEntity.studentId),
                                        new SqlParameter("@course_id", enrollmentEntity.courseId),
                                        new SqlParameter("@enrollment_date", enrollmentEntity.enrollmentdate)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Delete(int id)
        {
            strSql = "DELETE FROM enrollments_tb  WHERE enrollment_id=@enrollment_id";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@enrollment_id", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
    }
}
