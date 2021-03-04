using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers.Models
{
    public abstract class Human
    {
        public abstract string FirstName
        {
            get;
            set;
        }

        public abstract string LastName
        {
            get;
            set;
        }
    }
}
