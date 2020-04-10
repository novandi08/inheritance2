using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Teacher : Person
    {
        public Teacher(string aName, int aAge, string aTeacherId, string aSubject) : base(aName, aAge)
        {
            TeacherId = aTeacherId;
            Subject = aSubject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }
    }
}
