using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Common;
using OJT.Entities.Course;
using System.Collections;

namespace OJT.DAO.Course
{
    public class CourseDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM course_tb ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM course_tb " +
                      "WHERE  course_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(CourseEntity courseEntity)
        {

            strSql = "INSERT INTO course_tb(course_id,course_name,course_hours,start_date,end_date,course_price,course_description)" +
                     "VALUES(@course_id,@course_name,@course_hours,@start_date,@end_date,@course_price,@course_description)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@course_id", courseEntity.courseId),
                                        new SqlParameter("@course_name", courseEntity.courseName),
                                        new SqlParameter("@course_hours", courseEntity.courseHour),
                                        new SqlParameter("@start_date", courseEntity.startDate),
                                        new SqlParameter("@end_date", courseEntity.endDate),
                                        new SqlParameter("@course_price", courseEntity.coursePrice),
                                        new SqlParameter("@course_description", courseEntity.description)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Update(CourseEntity courseEntity)
        {
            strSql = "UPDATE course_tb SET course_name=@course_name,course_hours=@course_hours,start_date=@start_date,end_date=@end_date,course_price=@course_price,course_description=@course_description WHERE course_id = @course_id";

            SqlParameter[] sqlParam = {
                                      new SqlParameter("@course_id", courseEntity.courseId),
                                        new SqlParameter("@course_name", courseEntity.courseName),
                                        new SqlParameter("@course_hours", courseEntity.courseHour),
                                        new SqlParameter("@start_date", courseEntity.startDate),
                                        new SqlParameter("@end_date", courseEntity.endDate),
                                        new SqlParameter("@course_price", courseEntity.coursePrice),
                                        new SqlParameter("@course_description", courseEntity.description)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM course_tb  WHERE course_id =@course_id";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@course_id", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
    }
}