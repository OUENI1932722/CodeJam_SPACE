﻿using System;
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
            Station station = new Station();
            station.init();
            station.intro();
            station.play();
        }
    }
}
