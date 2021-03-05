using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy.Models
{
    class Tomcat : Cats
    {
        public const Sex tomcatSex = Models.Sex.MALE;

        public override void Sound()
        {
            Console.WriteLine("Tomcat say miauuu..");
            //base.Sound();
        }
    }
}
