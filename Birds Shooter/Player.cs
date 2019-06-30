using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Player
    {
        public string name { get; set; }
        public int points { get; set; }

        public Player(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public override string ToString()
        {
            return this.name + "   -   " + this.points;
        }
    }
}
