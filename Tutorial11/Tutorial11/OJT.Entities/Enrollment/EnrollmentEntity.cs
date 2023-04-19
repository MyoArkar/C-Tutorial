using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Entities.Enrollment
{
    public class EnrollmentEntity
    {
        public int enrollmentId { get; set; }

        public int studentId { get; set; }

        public int courseId { get; set; }
        public DateTime enrollmentdate { get; set; }
        public EnrollmentEntity() 
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.enrollmentId = 0;
            this.studentId = 0;
            this.courseId = 0;
            this.enrollmentdate = DateTime.Now;
        }
    }
}
