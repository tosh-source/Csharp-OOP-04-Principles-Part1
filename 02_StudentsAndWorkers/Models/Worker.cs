using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers.Models
{
    public class Worker : Human
    {
        private string firstName;
        private string lastName;
        private decimal weekSalary;
        private int workHoursPerDay;

        public override string FirstName
        {
            get => this.firstName;
            set => this.firstName = value ;
        }
        public override string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            return (weekSalary / 40) * this.WorkHoursPerDay;  //5 days in week, 8 hours per day = 40 working hours in week
        }
    }
}
