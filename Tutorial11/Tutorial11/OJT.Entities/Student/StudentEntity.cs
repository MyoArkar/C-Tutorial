using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Entities.Student
{
    public class StudentEntity
    {
        public int studentId { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public byte[] photo { get; set; }

        public string gender { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public DateTime dateofbirth { get; set; }

        public StudentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.studentId = 0;
            this.firstname = String.Empty;
            this.lastname = String.Empty;
            this.photo = null;
            this.gender = String.Empty;
            this.email = String.Empty;
            this.address = String.Empty;
            this.phone = String.Empty;
            this.dateofbirth = DateTime.Now;
        }
    }
}
