using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Physique
    {
        /*Décolage:
         *          https://tpefusee.wordpress.com/previsions-de-la-mission-les-parametre-de-lancement/ 
         * 1 tonne = 1000kg
         */

        private readonly double INTENSITE_GRAV_TERRE = 9.8/*N/kg*/, VITESSE_SATELLISATION = 7.9/*km/s*/;
        private double poidsFusee, masseFusee = 500000, quantiteCarburant = 190000, pousseeFusee = 2280000, debitMassiqueGaz, aireMoteur, densiteGaz, volumeGaz, accelerationFusee, velociteGaz = 0,  vitesseFusee = 1;
        private Fusee fusee;


        public Physique(/*Fusee fusee*/)
        {
           // this.fusee = fusee;
        }
        void CalculerPoidsFusee()
        {
            poidsFusee = (masseFusee + quantiteCarburant) * INTENSITE_GRAV_TERRE;
        }
        void CalculerAcceleration()
        {
            accelerationFusee = (pousseeFusee - poidsFusee) / masseFusee;
        }
        void CalculerVelociteGaz()
        {
            velociteGaz = velociteGaz + accelerationFusee;
        }
        void CalculerPerteMasse()
        {
            debitMassiqueGaz = densiteGaz * velociteGaz * aireMoteur;
        }
        public void MiseAJour()
        {
            int timer = 0;
            while (vitesseFusee != 0)
            {
                CalculerPoidsFusee();
                CalculerAcceleration();
                CalculerVelociteGaz();
                CalculerPerteMasse();
                quantiteCarburant -= debitMassiqueGaz;
                if (quantiteCarburant <= 0)
                    pousseeFusee = 0;
                timer++;
                if (timer == 1000)
                {
                    timer = 0;
                    Console.SetCursorPosition(0,0);
                    Console.Write("Vitesse : " + vitesseFusee + "\nPoids : " + poidsFusee + "\nAcceleration : " + accelerationFusee + "\nQuantité de carburant : " + quantiteCarburant);
                }
            }
        }
        /*double CalculerVitesseEjectionGaz()
        {
            //Ve = Rac((2k/k-1)(RTc/M)(1-Pe/Pc)^(k-1/k)) || Pe = 1bar, M = déclaré avec carburant, Pc = déclaré avec chambre combustion(moteur), Tc = déclaré avec carburant, R = 8.31, K = Gamma(voir https://fr.wikipedia.org/wiki/Indice_adiabatique) 
            vitesseEjectionGaz = Math.Sqrt(Math.Pow((((2*gammaGaz)/(gammaGaz-1))*((CONSTANTE_GAZ_PARFAITS - 1)/CONSTANTE_GAZ_PARFAITS)*(1 - (pressionExterieure/pressionCombustion))),((gammaGaz - 1)/gammaGaz)));
            return vitesseEjectionGaz; //m/s
        }
        double CalCulerVitesseDecollage()
        {
            //F = Dm * Ve|| F = poussée, Dm= débit massique de gaz éjecté(déclaré avec moteur)
            pousseeFusee = debitMassiqueGaz * vitesseEjectionGaz;
            return pousseeFusee;
        }*/
        bool DecollageFusee()
        {
            if (pousseeFusee > poidsFusee)
                return true;
            return false;
        }

    }
}
