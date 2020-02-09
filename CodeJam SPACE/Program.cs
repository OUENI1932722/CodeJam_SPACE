using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Physique physique = new Physique();
            Affichage affichage = new Affichage();
            Station station = new Station();
            station.init();
            station.play();
            Console.ReadKey();
        }
    }
}

