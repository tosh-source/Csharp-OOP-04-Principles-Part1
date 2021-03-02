using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School.Models
{
    class Persons : School
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
