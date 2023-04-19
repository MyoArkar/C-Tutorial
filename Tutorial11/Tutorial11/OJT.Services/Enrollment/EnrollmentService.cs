using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJT.DAO.Course;
using OJT.DAO.Enrollment;
using OJT.Entities.Course;
using OJT.Entities.Enrollment;

namespace OJT.Services.Enrollment
{
    public class EnrollmentService
    {
        private EnrollmentDao enrollmentDao = new EnrollmentDao();

        public DataTable GetAll()
        {
            DataTable dt = enrollmentDao.GetAll();
            return dt;
        }
        public DataTable Get(int id)
        {
            DataTable dt = enrollmentDao.Get(id);
            return dt;
        }

        public bool Insert(EnrollmentEntity enrollmentEntity)
        {
            return enrollmentDao.Insert(enrollmentEntity);
        }
        public bool Update(EnrollmentEntity enrollmentEntity)
        {
            return enrollmentDao.Update(enrollmentEntity);
        }
        public bool Delete(int id)
        {
            return enrollmentDao.Delete(id);
        }
    }
}
