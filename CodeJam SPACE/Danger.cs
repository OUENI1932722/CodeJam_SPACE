using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Danger
    {
        private Random random = new Random();
        public bool toucherParEclair(string meteo)
        {
            if(meteo == "orageux" && random.Next(1,4167) == 1)
                return true;
            else
                return false;
        }
        public bool toucherParOiseaux()
        {
            if (random.Next(1, 5) == 1)
                return true;
            else
                return false;
        }
        public bool toucherParMeteoriteSpace()
        {
            if (random.Next(1, 51) == 1)
                return true;
            else
                return false;
        }
    }
}
