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
        private Random random = new Random();
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
        public void tuto()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Bienvenue au CODEJAM Space Program!");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Commençons par choisir les pièces. ");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Il y a 3 compagnies d'où vous pouvez choisir");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("la provenance de la pièces : ");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("1. SpaceX      (Léger)");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("2. EspacioTaco (Peu lourd)");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA        (Lourd)");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("(Appuyer sur une touche pour continuer)");
            Console.SetCursorPosition(51, 15);
            Console.ReadKey();
            effacerTextBox();
            //-------------------------------------------------------------
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Bienvenue au CODEJAM Space Program!");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Il y a 2 types de pièces :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. La cabine (Le siège avant)");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. Le moteur");
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
            Console.WriteLine("1. SpaceX lightCockpit mk2  : 0.83 T");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. EspacioTaco dioCockpito  : 1.07 T");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA cockpit             : 1.67 T");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse : ");
            Console.SetCursorPosition(28, 15);
        }
        public void choixEngine()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Choisisez l'engine(vide) :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. SpaceX RS-68: 737kg");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. EspacioTaco Viking 5C rocket engine: 826kg");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. CNSA Engine :  1251kg");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse : ");
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(13, 10);
            Console.WriteLine("Consommation : 241 kg/s ");
            Console.SetCursorPosition(13, 12);
            Console.WriteLine("Consommation : 244 kg/s");
            Console.SetCursorPosition(13, 14);
            Console.WriteLine("Consommation : 262 kg/s");
            Console.SetCursorPosition(28, 15);

            Console.ForegroundColor = ConsoleColor.White;
        }
        public void choixCarburant()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Choisisez le carburant :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("1. Kerosène  | Pousee = 3510");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2. Hydrogène | Pousee = 4462");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("3. Méthane   | Pousee = 3615");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse : ");
            Console.SetCursorPosition(28, 15);
        }
        public void choixQuantite()
        {
            effacerTextBox();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Phase de contruction....");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Veuillez choisir la quantité de carburant :");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Vous pouvez choisir jusqu'à 20000 Litres");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine("Votre réponse : ");
            Console.SetCursorPosition(28, 15);
        }
        public void update(string hauteur, string vitesse, string carburant, string poids)
        {
            Console.SetCursorPosition(147, 2);
            Console.Write(hauteur + " m");
            Console.SetCursorPosition(156, 4);
            Console.Write(carburant + " kg   ");
            Console.SetCursorPosition(156, 6);
            Console.Write(poids + " kg");
            Console.SetCursorPosition(136, 6);
            Console.Write(vitesse + " m/s    ");
            if (Convert.ToDouble(carburant) > 0)
            {
                effacerFusee();
                fusee(random.Next(136,138), 16, 6);
            }
            else
            {
                effacerFusee();
                fusee(random.Next(136,138), 16, 0);
            }

        }
        public void Lancement()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(ascii.terreLancement);
        }
        public void sequenceDeLancement()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(129, 36);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(129, 37);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(129, 38);
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(129, 39);
            Console.WriteLine("FIRE !");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(136, 26, 1);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(137, 25, 2);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(136, 24, 3);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(137, 23, 4);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(136, 22, 5);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(137, 21, 6);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(137, 20, 6);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(136, 19, 6);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(137, 18, 6);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(136, 17, 6);
            System.Threading.Thread.Sleep(100);
            effacerFusee();
            fusee(135, 16, 6);
        }
        private void effacerFusee()
        {
            for (int i = 0; i < 33; i++)
            {
                Console.SetCursorPosition(124, (i + 9));
                Console.WriteLine("                                           ");
            }           
        }
        private void fusee(int posX, int posY, int nbFlames)
        {
            Console.SetCursorPosition(posX,posY);
            Console.WriteLine("         /\\");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("        |==|");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("        |  |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("        |  |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("        |  |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       /____\\");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       |    |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       |    |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       |    |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       |    |");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("      /| |  |\\");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("     / | |  | \\");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("    /__|_|__|__\\");
            posY++;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("       /_\\/_\\");            
            if(nbFlames > 0)
            {
                posY++;
                Console.SetCursorPosition(posX, posY);
                Console.WriteLine("       ######");
                if(nbFlames > 1)
                {
                    posY++;
                    Console.SetCursorPosition(posX, posY);
                    Console.WriteLine("      ########");
                    if(nbFlames > 2)
                    {
                        posY++;
                        Console.SetCursorPosition(posX, posY);
                        Console.WriteLine("       ######");
                        if(nbFlames > 3)
                        {
                            posY++;
                            Console.SetCursorPosition(posX, posY);
                            Console.WriteLine("        ####");
                            if(nbFlames > 4)
                            {
                                posY++;
                                Console.SetCursorPosition(posX, posY);
                                Console.WriteLine("        ####");
                                if(nbFlames > 5)
                                {
                                    posY++;
                                    Console.SetCursorPosition(posX, posY);
                                    Console.WriteLine("         ##");
                                    if(nbFlames > 6)
                                    {
                                        posY++;
                                        Console.SetCursorPosition(posX, posY);
                                        Console.WriteLine("         ##");
                                    }                                    
                                }                               
                            }                           
                        }                       
                    }                    
                }                
            }           
        }
    }
}
