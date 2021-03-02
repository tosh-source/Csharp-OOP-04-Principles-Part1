using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School.Models
{
    class Disciplines : School
    {
        private string name;
        private int numbOfLectures;
        private int numbOfExercises;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumbOfLectures
        {
            get { return numbOfLectures; }
            set { numbOfLectures = value; }
        }

        public int NumbOfExercises
        {
            get { return numbOfExercises; }
            set { numbOfExercises = value; }
        }

        public override string ToString()
        {
            var result = string.Empty;

            result += Name + Environment.NewLine;
            result += NumbOfLectures + Environment.NewLine;
            result += NumbOfExercises + Environment.NewLine;

            return result;
        }
    }
}
