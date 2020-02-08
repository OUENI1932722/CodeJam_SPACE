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
            ASCII ascii = new ASCII();
            Interface.SetTailleConsole();
            Console.Write(ascii.terre);
            Console.ReadKey();
        }
    }
}

