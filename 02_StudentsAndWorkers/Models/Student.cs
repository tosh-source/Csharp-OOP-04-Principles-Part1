using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers.Models
{
    public class Student : Human
    {
        private string firstName;
        private string lastName;
        private string grade;

        public string Grade  //Letter Grade/Score: A (90%), B (80%), C (70%), D (60%) F (59-0%)
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string FirstName
        {
            get => this.firstName ;
            set => this.firstName = value;
        }
        public override string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }
    }
}
