using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School.Models
{
    class Students : Persons
    {
        private string uniqueClassNumber;

        public string UniqueClassNumber
        {
            get { return uniqueClassNumber; }
            set { uniqueClassNumber = value; }
        }

    }
}
