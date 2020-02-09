using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Vent
    {
        private Random random = new Random();
        public Vent(string meteo)
        {
            Direction = getDirectionVent();
            Force = getForceVent(meteo);
        }
        public int getForceVent(string meteo)
        {
            if (meteo == "pluie")
                return random.Next(3, 10);
            else if (meteo == "orageux")
                return random.Next(6, 15);
            else
                return random.Next(1, 3);
        }
        private string getDirectionVent()
        {
            if (random.Next(1, 3) == 1)
                return "left";
            else
                return "right";
        }
        public string Direction { get; set; }
        public int Force { get; set; }
    }
}
