using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Entities.Course
{
    public class CourseEntity
    {
        public int courseId { get; set; }

        public string courseName { get; set; }

        public int courseHour { get; set; }



        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int coursePrice { get; set; }

        public string description { get; set; }

        public CourseEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.courseId = 0;
            this.courseName = String.Empty;
            this.courseHour = 0;
            this.startDate = DateTime.Now;
            this.endDate = DateTime.Now;
            this.coursePrice = 0;
            this.description = String.Empty;
        }
    }
}
