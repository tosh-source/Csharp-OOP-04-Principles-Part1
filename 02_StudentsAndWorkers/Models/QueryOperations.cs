using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers.Models
{
    public static class QueryOperations
    {
        public static IEnumerable<string> SortByGrade(this List<Student> students)
        {
            var result = students.OrderBy(student => student.Grade)
                                 .Select(student => student.FirstName + " " + student.LastName);

            return result;
        }

        public static IEnumerable<string> SortMoneyPerHour(this List<Worker> workers)
        {
            var result = workers.OrderByDescending(worker => worker.MoneyPerHour())
                                .Select(worker => worker.FirstName + " " + worker.LastName);

            return result;
        }
    }
}
