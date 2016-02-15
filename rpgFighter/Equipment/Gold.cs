using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Items
{
    class Gold
    {
        private int Value { get; set; }
        //TODO: Define position
        //private Position Location;

        public Gold(int value)
        {
            Value = value;

        }
        public override string ToString()
        {
            return String.Format("Gold: {0}", Value);
        }
    }
}
