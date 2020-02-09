﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Affichage
    {
        private ASCII ascii = new ASCII();
        public void init()
        {
            Console.SetWindowSize(170, 44);
            Console.WriteLine(ascii.terre);
            Console.SetCursorPosition(51, 15);
        }
        public void effacerTextBox()
        {
            Console.SetCursorPosition(7, 4);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 8);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 9);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 10);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 11);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 12);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 13);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 14);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 15);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 16);
            Console.WriteLine("                                                 ");
            Console.SetCursorPosition(7, 17);
            Console.WriteLine("                                                 ");
        }
        public void intro()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Bienvenue au CODEJAM Space Program,");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Commençons par choisir les pièces.");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Il y a 3 compagnies que vous pouvez choisir");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("La provenance de la pièces : ");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("1. SpaceX      (Cher, léger)");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("2. EspacioTaco (Abordable, un peu lourd)");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA        (Pas cher, lourd)");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("(Appuyer sur une touche pour continuer)");
            Console.SetCursorPosition(51, 15);
            Console.ReadKey();
            effacerTextBox();
            //-------------------------------------------------------------
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Bienvenue au CODEJAM Space Program,");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Il y a 3 types de pièces :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. La cabine (Le siège avant)");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("2. Le cargo (Pour le transport de matériaux)");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("3. Le moteur");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("(Appuyer sur une touche pour continuer)");
            Console.SetCursorPosition(51, 15);
            Console.ReadKey();
        }
        public void choixCockpit()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Choisisez la cabine :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. SpaceX LightCockpit mk2  : 0.83 T");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. EspacioTaco DioCockpito  : 1.07 T");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA Cockpit             : 1.67 T");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse :");
            Console.SetCursorPosition(27, 15);
        }
        public void choixMoteur()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Choisisez le moteur(vide) :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. spaceX RS-68: 737kg");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. espacioTaco Viking 5C rocket engine: 826kg");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA Engine :  1251kg");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse :");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(13, 10);
            Console.WriteLine("Fuel : 241 kg/s ");
            Console.SetCursorPosition(13, 12);
            Console.WriteLine("Fuel : 244 kg/s");
            Console.SetCursorPosition(13, 14);
            Console.WriteLine("Fuel : 262 kg/s");
            Console.SetCursorPosition(27, 15);

            Console.ForegroundColor = ConsoleColor.White;
        }
        public void updateFusee(Vent vent, int totalDistance)
        {

        }
    }
}
