using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_School.Models;

namespace _01_School
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Disciplines in School
            Disciplines math = new Disciplines();
            math.Name = "Mathematics";
            math.NumbOfLectures = 40;
            math.NumbOfExercises = 2;

            Disciplines biology = new Disciplines();
            biology.Name = "Biology";
            biology.NumbOfLectures = 36;
            biology.NumbOfExercises = 3;

            Disciplines informatics = new Disciplines();
            informatics.Name = "Informatics";
            informatics.NumbOfLectures = 60;
            informatics.NumbOfExercises = 5;

            //Teachers in School
            Teachers teachers = new Teachers();
            teachers.AddDisciplines(math);
            teachers.AddDisciplines(biology);

            foreach (var item in teachers.Disciplines)
            {
                Console.WriteLine(item);
            }

            //Use inherited property from classes "School -> Persons -> Teachers". 
            teachers.Comments = " optional comments";
        }
    }
}
