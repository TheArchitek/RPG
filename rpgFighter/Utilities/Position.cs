using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Utilities
{
    class Position
    {
        private int Xcoordinate { get; set; }
        private int Ycoordinate { get; set; }

        public Position(int x, int y)
        {
            Xcoordinate = x;
            Ycoordinate = y;
        }
        public override string ToString()
        {
             return String.Format("Your position is: {0}, {1}", Xcoordinate, Ycoordinate);
        }
       
    }
}
