using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_AnimalHierarchy.Models;

namespace _03_AnimalHierarchy
{
    class Tests
    {
        static void Main(string[] args)
        {
            Dogs[] dogs =
            {
                new Dogs { Name = "Sharo", Sex = Sex.MALE.ToString(), Age = 4 },
                new Dogs { Name = "Kevin", Sex = Sex.MALE.ToString(), Age = 2 },
                new Dogs { Name = "Alex", Sex = Sex.FEMALE.ToString(), Age = 6 }
            };

            Console.WriteLine("Average age of all dogs: " + QueryOperations.AverageAge(dogs));

            Kittens[] kittens =
            {
                new Kittens { Name = "Venom", Sex = Sex.MALE.ToString(), Age = 200 },
                new Kittens { Name = "Kim", Sex = Sex.FEMALE.ToString(), Age = 5 },
                new Kittens { Name = "Abi", Sex = Sex.FEMALE.ToString(), Age = 9 }
            };

            Console.WriteLine("Average age of all kittens: " + QueryOperations.AverageAge(kittens));
        }
    }
}
