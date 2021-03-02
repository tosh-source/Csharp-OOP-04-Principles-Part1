using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School.Models
{
    //In the school there are classes of students.
    class Classes : School
    {
        private List<Teachers> teachers;
        private List<Students> students;
        private string uniqueTextIdentifier;

        public List<Teachers> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public List<Students> Students
        {
            get { return students; }
            set { students = value; }
        }

        public string UniqueTextIdentifier
        {
            get { return uniqueTextIdentifier; }
            set { uniqueTextIdentifier = value; }
        }
    }
}
