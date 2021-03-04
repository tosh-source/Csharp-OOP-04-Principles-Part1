using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_StudentsAndWorkers.Models;

namespace _02_StudentsAndWorkers
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Initialize a list of 10 students.
            List<Student> students = new List<Student>();
            students.Add(new Student { FirstName = "Ivan", LastName = "Dimov", Grade = "C" });
            students.Add(new Student { FirstName = "Vera", LastName = "Georgieva", Grade = "A" });
            students.Add(new Student { FirstName = "Dragan", LastName = "Tsankov", Grade = "B" });
            students.Add(new Student { FirstName = "Khan", LastName = "Asparuh", Grade = "D" });
            students.Add(new Student { FirstName = "Vera", LastName = "Aleksieva", Grade = "B" });
            students.Add(new Student { FirstName = "Jon", LastName = "Brown", Grade = "F" });
            students.Add(new Student { FirstName = "Ivan", LastName = "Stefanov", Grade = "A" });
            students.Add(new Student { FirstName = "Gero", LastName = "Karamfilov", Grade = "C" });
            students.Add(new Student { FirstName = "Hary", LastName = "Vidov", Grade = "D" });
            students.Add(new Student { FirstName = "Geny", LastName = "Kirov", Grade = "A" });

            Console.WriteLine("List of students." + string.Join("\n", students.SortByGrade()));

            //Initialize a list of 10 workers.
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker { FirstName = "Ivan", LastName = "Dimov", WeekSalary = 150, WorkHoursPerDay = 7 });
            workers.Add(new Worker { FirstName = "Vera", LastName = "Georgieva", WeekSalary = 240, WorkHoursPerDay = 8 });
            workers.Add(new Worker { FirstName = "Dragan", LastName = "Tsankov", WeekSalary = 130, WorkHoursPerDay = 8 });
            workers.Add(new Worker { FirstName = "Khan", LastName = "Asparuh", WeekSalary = 1500, WorkHoursPerDay = 4 });
            workers.Add(new Worker { FirstName = "Vera", LastName = "Aleksieva", WeekSalary = 150, WorkHoursPerDay = 7 });
            workers.Add(new Worker { FirstName = "Jon", LastName = "Brown", WeekSalary = 400, WorkHoursPerDay = 6 });
            workers.Add(new Worker { FirstName = "Ivan", LastName = "Stefanov", WeekSalary = 340, WorkHoursPerDay = 8 });
            workers.Add(new Worker { FirstName = "Gero", LastName = "Karamfilov", WeekSalary = 345, WorkHoursPerDay = 6 });
            workers.Add(new Worker { FirstName = "Hary", LastName = "Vidov", WeekSalary = 4250, WorkHoursPerDay = 4 });
            workers.Add(new Worker { FirstName = "Geny", LastName = "Kirov", WeekSalary = 780, WorkHoursPerDay = 5 });

            Console.WriteLine("\n" + "\nList of workers." + "\n"
                              + string.Join("\n", workers.SortMoneyPerHour()));
        }
    }
}
