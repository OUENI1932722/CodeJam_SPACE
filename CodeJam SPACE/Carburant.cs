using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Carburant
    {
        public enum TypeCarburant
        {
            Kerosène, Hydrogène, Méthane
        }
        public Carburant(TypeCarburant typeCarburant, double quantite)
        {
            switch (typeCarburant)
            {
                case TypeCarburant.Kerosène:
                    Pousee = 3510; //m/s
                    Densite = 1.03; //kg/m^3
                    Prix = 0.73; //$/kg
                    Quantite = quantite;
                    break;
                case TypeCarburant.Hydrogène:
                    Pousee = 4462;
                    Densite = 0.32;
                    Prix = 5;
                    Quantite = quantite;
                    break;
                case TypeCarburant.Méthane:
                    Pousee = 3615;
                    Densite = 0.83;
                    Prix = 1.35;
                    Quantite = quantite;
                    break;
            }
        }
        public double Pousee { get; }
        public double Densite { get; }
        public double Prix { get; }
        public double Quantite { get; }
    }
}