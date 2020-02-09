using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Station
    {
        private MeteoActuel meteo;
        private Affichage affichage = new Affichage();
        private List<Meteo> meteos = new List<Meteo>();
        private Cabine cabine;
        private Moteur moteur;
        private int choix;
        public void play()
        {
            //Instancier la météo
            meteo = new MeteoActuel(meteos);
            //Donner le choix de la Cabine
            do
            {
                affichage.choixCockpit();
                choix = Convert.ToInt16(Console.ReadLine());
            }
            while (choix != 1 && choix != 2 && choix != 3);
            switch (choix)
            {
                case 1:
                    cabine = new Cabine("Light Cockpit MK2", 832);
                    break;
                case 2:
                    cabine = new Cabine("Dio Cockpito", 1071);
                    break;
                case 3:
                    cabine = new Cabine("CNSA Cockpit", 1674);
                    break;
            }
            //Donner le choix du Moteur
            do
            {
                //affichage.choixEngine();
                choix = Convert.ToInt16(Console.ReadLine());
            }
            while (choix != 1 && choix != 2 && choix != 3);
            switch (choix)
            {
                case 1:
                    moteur = new Moteur("RS-68",737,3.01,1,241, 972);
                    break;
                case 2:
                    moteur = new Moteur("Viking 5C", 826, 2.87, 0.99,244, 960);
                    break;
                case 3:
                    moteur = new Moteur("Engine", 911,2.67,0.93,262,952);
                    break;
            }
        }
        public void init()
        {
            affichage.init();
            Meteo pluie = new Meteo("pluie", 14, 20, 990, 1005); // 15
            Meteo soleil = new Meteo("soleil", 21, 30, 1006, 1040); // 34
            Meteo orageux = new Meteo("orageux", 13, 20, 970, 989); // 19
            meteos.Add(pluie);
            meteos.Add(soleil);
            meteos.Add(orageux);
            
        }
        public void intro()
        {
            Console.ReadKey();
            affichage.intro();
        }
    }
}
