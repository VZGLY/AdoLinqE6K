using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLinqE6K.Entities
{
    public class Student
    {

        public int StudentId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime? Birthdate { get; set; }

        public string Login { get; set; }

        public int? SectionId { get; set; }

        public int? YearResult { get; set; }

        public string CourseId { get; set; }
    }
}
