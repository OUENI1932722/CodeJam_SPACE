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
        private Carburant carburant;
        private Fusee fusee;
        private Physique physique;
        private int choix;
        private int quantiteCarburant;
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
                affichage.choixEngine();
                choix = Convert.ToInt16(Console.ReadLine());
            }
            while (choix != 1 && choix != 2 && choix != 3);
            switch (choix)
            {
                case 1:
                    moteur = new Moteur("RS-68",737, 3.01, 1, 241, 972000, 2972);
                    break;
                case 2:
                    moteur = new Moteur("Viking 5C", 826, 2.87, 0.99, 244, 960000, 2851);
                    break;
                case 3:
                    moteur = new Moteur("Engine", 911, 2.67, 0.93, 262, 952000, 2713);
                    break;
            }
            //Donner le choix du Carburant
            do
            {
                affichage.choixCarburant();
                choix = Convert.ToInt16(Console.ReadLine());
            }
            while (choix != 1 && choix != 2 && choix != 3);
            //Donner le choix de la quantité de carburant
            do
            {
                affichage.choixQuantite();
                quantiteCarburant = Convert.ToInt32(Console.ReadLine());
            }
            while (choix > 2000);
            switch (choix)
            {
                case 1:
                    carburant = new Carburant(Carburant.TypeCarburant.Kerosène, quantiteCarburant);
                    break;
                case 2:
                    carburant = new Carburant(Carburant.TypeCarburant.Hydrogène, quantiteCarburant);
                    break;
                case 3:
                    carburant = new Carburant(Carburant.TypeCarburant.Méthane, quantiteCarburant);
                    break;
            }
            Console.CursorVisible = false;
            fusee = new Fusee(cabine, moteur, carburant);
            physique = new Physique(fusee);
            physique.MiseAJour();
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
            affichage.tuto();
        }
    }
}
