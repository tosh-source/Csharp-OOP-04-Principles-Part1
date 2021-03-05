using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy.Models
{
    class Frogs : Animals
    {
        public override void Sound()
        {
            Console.WriteLine("Frogs say kwak..");
        }
    }
}
