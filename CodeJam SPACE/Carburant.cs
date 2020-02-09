using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Carburant
    {
        /*
         Kerosene, Oxygène liquide, hydrogène liquide, hydrazine(diazane), aérozine 50, 1,1-diméthylhydrazine, peroxyde d'azote
         https://en.wikipedia.org/wiki/Liquid_rocket_propellant#Present_use
         */
        private double poussee, densite, quantite;

        public enum TypeCarburant
        {
            Kerosène, Hydrogène, Méthane
        }
        public Carburant(TypeCarburant typeCarburant, double quantite)
        {
            switch(typeCarburant)
            {
                case TypeCarburant.Kerosène:
                    poussee = 3510; //m/s
                    densite = 1.03; //kg/m^3
                    this.quantite = quantite;
                    break;
                case TypeCarburant.Hydrogène:
                    poussee = 4462;
                    densite = 0.32;
                    this.quantite = quantite;
                    break;
                case TypeCarburant.Méthane:
                    poussee = 3615;
                    densite = 0.83;
                    this.quantite = quantite;
                    break;
            }
        }
    }
}
