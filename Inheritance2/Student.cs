using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Student : Person
    {
        public Student(string aName, int aAge, string aStudentId, string aEmail) : base(aName, aAge)
        {
            StudentId = aStudentId;
            Email = aEmail;
        }

        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}
