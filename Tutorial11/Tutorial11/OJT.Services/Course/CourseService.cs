using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJT.DAO.Course;
using OJT.Entities.Course;

namespace OJT.Services.Course
{
    public class CourseService
    {
        private CourseDao courseDao = new CourseDao();


        public DataTable GetAll()
        {
            DataTable dt = courseDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = courseDao.Get(id);
            return dt;
        }

        public bool Insert(CourseEntity courseEntity)
        {
            return courseDao.Insert(courseEntity);
        }

        public bool Update(CourseEntity courseEntity)
        {
            return courseDao.Update(courseEntity);
        }

        public bool Delete(int id)
        {
            return courseDao.Delete(id);
        }
    }
}
