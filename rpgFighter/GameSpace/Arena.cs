using rpgFighter.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.GameSpace
{
    class Arena
    {
        private int MaxXLength { get; set; }
        private int MaxYLength { get; set; }
        public List<Person> People = new List<Person>();

        public Arena()
        {
            MaxXLength = 10;
            MaxYLength = 10;
            
        }

        public Arena(int maxX, int maxY)
        {
            MaxXLength = maxX;
            MaxYLength = maxY;
        }

        public void addPersonToArena(Person person)
        {
            People.Add(person);
        }

        public string PrintPeople()
        {
            string personList = "";
            foreach (Person p in People)
            {
                personList += p.ToString() + Environment.NewLine;
            }
            return personList;
        }
    }
}
