using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy.Models
{
    class Kittens : Cats
    {
        public const Sex kittensSex = Models.Sex.FEMALE;

        public override void Sound()
        {
            Console.WriteLine("Kittens say miauuu..");
            //base.Sound();
        }
    }
}
