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
        private double poidsFusee, masseFusee, quantiteCarburant, pousseeFusee, debitMassiqueGaz, aireMoteur, densiteGaz, volumeGaz, accelerationFusee, velociteGaz = 0;
        private Fusee fusee;


        public Physique(Fusee fusee)
        {
            this.fusee = fusee;
        }
        double CalculerPoidsFusee()
        {
            poidsFusee = masseFusee * INTENSITE_GRAV_TERRE;
            return poidsFusee;
        }
        double CalculerAcceleration()
        {
            accelerationFusee = (pousseeFusee - CalculerPoidsFusee()) / masseFusee;
            return accelerationFusee;
        }
        double CalculerVelociteGaz()
        {
            velociteGaz = velociteGaz + CalculerAcceleration();
            return velociteGaz; //m/s
        }
        double CalculerPerteMasse()
        {
            debitMassiqueGaz = densiteGaz * CalculerVelociteGaz() * aireMoteur;
            return debitMassiqueGaz; //kg/s
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
            if (pousseeFusee > CalculerPoidsFusee())
                return true;
            return false;
        }

    }
}
