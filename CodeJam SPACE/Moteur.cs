using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Moteur
    {
        public Moteur(string nom, double poids, double hauteur, double diametre, int consumationCarburant, int thrust)
        {
            Nom = nom;
            Poids = poids;
            Hauteur = hauteur;
            Diametre = diametre;
            ConsumationCarburant = consumationCarburant;
            Thrust = thrust;
        }
        public string Nom { get; set; }
        public double Poids { get; set; } //kg
        public double Hauteur { get; set; } //M
        public double Diametre { get; set; } //M
        public int ConsumationCarburant { get; set; } //kg/S
        public int Thrust { get; set; } //kN
    }
}
