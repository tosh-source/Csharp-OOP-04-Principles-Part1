using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School.Models
{
    class Teachers : Persons
    {
        private List<Disciplines> disciplines;

        public List<Disciplines> Disciplines
        {
            get //ENCAPSULATION, this is needed to prevent direct access to the object.
            {
                return new List<Disciplines>(this.disciplines);
            }
            set
            {
                if (this.disciplines == null)
                {
                    this.disciplines = new List<Disciplines>();
                }

                this.disciplines.Clear();
                this.disciplines = value;
            }
        }

        public Teachers()
        {
            this.Disciplines = new List<Disciplines>();
        }

        public void AddDisciplines(params Disciplines[] disciplines)
        {
            foreach (var discipline in disciplines)
            {
                this.disciplines.Add(discipline); 
            }
        }
    }
}
