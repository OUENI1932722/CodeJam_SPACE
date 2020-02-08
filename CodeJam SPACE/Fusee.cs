using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Fusee
    {
        private Moteur moteur;
        private Aileron ailerons;
        private Cabine cabine;
        private Carburant carburant;
        private Charge charge;
        public Fusee(Moteur moteur, Aileron ailerons, Cabine cabine, Carburant carburant, Charge charge)
        {
            this.moteur = moteur;
            this.ailerons = ailerons;
            this.cabine = cabine;
            this.carburant = carburant;
            this.charge = charge;
        }
    }
}
