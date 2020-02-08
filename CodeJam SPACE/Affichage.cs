using System;
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
            Console.WriteLine("Commencon par choisir les pièces. ");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Il y a 3 compagnies que vous pouvez choisir");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("la provenance de la pièces : ");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("1. spaceX      (chère, légée)");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("2. espacioTaco (affordable, mais un peu lourd)");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA        (cheap, lourd)");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("(Appuyer sur une touche pour continuer)");
            Console.SetCursorPosition(51, 15);
            Console.ReadKey();
            effacerTextBox();
            //-------------------------------------------------------------
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Bienvenue au CODEJAM Space Program,");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Il y a 4 types de pièces :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. Le cockpit (le siège avant)");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("2. Le cargo (Pour le transport de matériaux)");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("3. Les ailerons (Pour l'aérodynamisme)");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("4. L'engine (le moteur)");
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
            Console.WriteLine("Choisisez le cockpit :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. spaceX lightCockpit mk2  : 0.83 T");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. espacioTaco dioCockpito  : 1.07 T");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA cockpit             : 1.67 T");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse :");
            Console.SetCursorPosition(27, 15);
        }
        public void choixEngine()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Choisisez l'engine(vide) :");
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
    }
}
