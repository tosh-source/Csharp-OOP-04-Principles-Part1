using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy.Models
{
    class QueryOperations
    {
        public static double AverageAge(params Animals[] animals)
        {
            var result = animals.Select(animal => animal.Age).ToList().Average();

            return result;
        }
    }
}
