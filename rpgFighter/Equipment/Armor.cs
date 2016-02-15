using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Equipment
{
    class Armor : Equipment
    {
        public int Defense { get; set; }

        public Armor(string name, int weight, int maxCap, int value, string description)
            : base(name, weight, maxCap, value, description)
        {

        }
        public Armor(string name, int weight, int maxCap, int value, string description, int defense)
            : base(name, weight, maxCap, value, description)
        {
            Defense = defense;
        }
    }
}
