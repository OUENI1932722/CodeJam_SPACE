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
            ASCII ascii = new ASCII();
            Console.Write(ascii.terre);
            physique.MiseAJour();
            Console.ReadKey();
        }
    }
}

