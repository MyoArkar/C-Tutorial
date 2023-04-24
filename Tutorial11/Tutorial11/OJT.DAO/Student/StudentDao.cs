using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Common;
using OJT.Entities.Student;
using System.Collections;

namespace OJT.DAO.Student
{
    public class StudentDao
    {
        /// <summary>
        /// Defines Database Connection..
        /// </summary>
        private DbConnection connection = new DbConnection();

        /// <summary>
        /// Defines strSql..
        /// </summary>
        private string strSql = String.Empty;

        /// <summary>
        /// Defines the resultDataTable.
        /// </summary>
        private DataTable resultDataTable = new DataTable();

        /// <summary>
        /// Defines the existCount.
        /// </summary>

        #region==========Product========== 

        /// <summary>
        /// Get All
        /// </summary>
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM student_tb ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM student_tb " +
                      "WHERE  student_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(StudentEntity studentEntity)
        {
            
            strSql = "INSERT INTO student_tb(student_id,first_name,last_name,photo,gender,date_of_birth,email,phone,address)" +
                     "VALUES(@student_id,@first_name,@last_name,@photo,@gender,@date_of_birth,@email,@phone,@address)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@student_id", studentEntity.studentId),
                                        new SqlParameter("@first_name", studentEntity.firstname),
                                        new SqlParameter("@last_name", studentEntity.lastname),
                                        new SqlParameter("@photo", studentEntity.photo),
                                        new SqlParameter("@gender", studentEntity.gender),
                                        new SqlParameter("@date_of_birth", studentEntity.dateofbirth),
                                        new SqlParameter("@email", studentEntity.email),
                                        new SqlParameter("@phone", studentEntity.phone),
                                        new SqlParameter("@address", studentEntity.address)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Insert1(StudentEntity studentEntity)
        {

            strSql = "INSERT INTO student_tb(student_id,first_name,last_name,gender,date_of_birth,email,phone,address)" +
                     "VALUES(@student_id,@first_name,@last_name,@gender,@date_of_birth,@email,@phone,@address)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@student_id", studentEntity.studentId),
                                        new SqlParameter("@first_name", studentEntity.firstname),
                                        new SqlParameter("@last_name", studentEntity.lastname),
                                        new SqlParameter("@gender", studentEntity.gender),
                                        new SqlParameter("@date_of_birth", studentEntity.dateofbirth),
                                        new SqlParameter("@email", studentEntity.email),
                                        new SqlParameter("@phone", studentEntity.phone),
                                        new SqlParameter("@address", studentEntity.address)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(StudentEntity studentEntity)
        {
            strSql = "UPDATE student_tb SET first_name=@first_name,last_name=@last_name,photo=@photo,gender=@gender,date_of_birth=@date_of_birth,email=@email,phone=@phone,address=@address WHERE student_id = @student_id";

            SqlParameter[] sqlParam = {
                                       new SqlParameter("@student_id", studentEntity.studentId),
                                        new SqlParameter("@first_name", studentEntity.firstname),
                                        new SqlParameter("@last_name", studentEntity.lastname),
                                        new SqlParameter("@photo", studentEntity.photo),
                                        new SqlParameter("@gender", studentEntity.gender),
                                        new SqlParameter("@date_of_birth", studentEntity.dateofbirth),
                                        new SqlParameter("@email", studentEntity.email),
                                        new SqlParameter("@phone", studentEntity.phone),
                                        new SqlParameter("@address", studentEntity.address)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Update1(StudentEntity studentEntity)
        {
            strSql = "UPDATE student_tb SET first_name=@first_name,last_name=@last_name,gender=@gender,date_of_birth=@date_of_birth,email=@email,phone=@phone,address=@address WHERE student_id = @student_id";

            SqlParameter[] sqlParam = {
                                       new SqlParameter("@student_id", studentEntity.studentId),
                                        new SqlParameter("@first_name", studentEntity.firstname),
                                        new SqlParameter("@last_name", studentEntity.lastname),
                                        new SqlParameter("@gender", studentEntity.gender),
                                        new SqlParameter("@date_of_birth", studentEntity.dateofbirth),
                                        new SqlParameter("@email", studentEntity.email),
                                        new SqlParameter("@phone", studentEntity.phone),
                                        new SqlParameter("@address", studentEntity.address)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM student_tb  WHERE student_id =@student_id";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@student_id", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
