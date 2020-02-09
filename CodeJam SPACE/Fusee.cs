using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Fusee
    {
        private Cabine cabine;
        private Moteur moteur;
        private Carburant carburant;
        public Fusee(Cabine cabine, Moteur moteur, Carburant carburant)
        {
            this.cabine = cabine;
            this.moteur = moteur;
            this.carburant = carburant;
        }
        public double getPoidsTotal()
        {
            return cabine.Poids + moteur.Poids + 500 /*Poids du réservoir*/;
        }
        public double thrust()
        {
            return moteur.Thrust;
        }
        public double impulsionSpecifique()
        {
            return moteur.ImpSpecifique;
        }
        public double getQuantiteCarburant()
        {
            return carburant.Quantite;
        }
    }
}
