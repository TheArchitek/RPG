using rpgFighter.Items;
using rpgFighter.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.People
{
    class Person
    {
        //public bool IsGood { get; set; }
        //private int Health { get; set; }
        //private string Name { get; set; }
        //private int Level { get; set; }

        public bool IsGood { get; set; }
        private int Health { get; set; }
        private string Name { get; set; }
        private int Level { get; set; }

        //TODO: define these properties
        private Gold Bank { get; set; }
        private Storage Inventory { get; set; }
        //private Position Location;
        //private list<attack> Attacks;

        /// <summary>
        /// Person constructor will create a new person. 
        /// </summary>
        /// <param name="name"></param>Character's name.
        /// <param name="good"></param>Character's alliance.
        /// <param name="health"></param>Character's health. 

        public Person(string name, bool good, int health)
        {
            IsGood = good;
            Health = health;
            Name = name;
            Level = 1;
        }
        public Person(string name, int level = 1, bool good = true, int health = 100)
        {
            IsGood = good;
            Health = health;
            Name = name;
            Level = level;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Level: {1}, Type: {2}, Health: {3}", Name, Level, IsGood, Health);
        }

    }
}
