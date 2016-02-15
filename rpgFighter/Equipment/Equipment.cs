using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Equipment
{
    abstract class Equipment
    {
        private string Name { get; set; }
        private int Weight { get; set; }
        private int MaxCap { get; set; }
        private int Value { get; set; }
        private string Description { get; set; }

        public Equipment(string name, int weight, int maxCap, int value, string description)
        {
            Name = name;
            Weight = weight;
            MaxCap = maxCap;
            Value = value;
            Description = description;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Weight: {1}, Max Capacity: {2}, Value: {3}, Description {4}.",
                                  Name, Weight, MaxCap, Value, Description);
        }
    }
}
