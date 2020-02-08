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
         * Poids de la fusée: P = m * g, où P est le poids, m la masse(kg) et g, la gravité (m/s^2)
         * 
         * 
         * Pour décoller, il faut que la force de poussée soit supèrieur au poids de la Terre.
         * Formule de la vitesse d'éjection des gazs: ΔE = ΔEc + ΔEp + ΔU = Q + W
         * Où ΔU = variation de l’energie interne
         *
         * ΔEc = energie cinétique = 1/2 mVf² – 1/2 mVi² ( ici = 0)
         *
         * ΔEp= energie potentielle= mghf – mghc (ici =0)
         *
         * Q= échange de chaleur ( ici =o car la fusée est isolée)
         *
         * W= travail de force de pression
         * 
         * Formule de la vitesse de satellisation: v = Rac. (2GM/R), où G est la constante gravitationelle, M la masse de la Terre(kg) et R, le rayon de la terre(m)
         * 
         * 1 tonne = 1000kg
         */

        private readonly int RAYON_TERRE = 6371000/*m*/;
        private readonly double VITESSE_ECHAPPEMENT = 11.2/*km/s*/, MASSE_TERRE = (5.97342*Math.Pow(10,24))/*kg*/, CONSTANTE_GRAVITATIONNELLE = (6.67*Math.Pow(10,(-11)))/*(N*m^2)/kg^2*/, INTENSITE_GRAV_TERRE = 9.8/*N/kg*/, VITESSE_SATELLISATION = 7.9/*km/s*/, CONSTANTE_GAZ_PARFAITS = 8.314/*kPaL/molK*/;
        private double poidsFusee, masseFusee, quantiteCarburant, pressionCombustion, pressionExterieure = 101.3/*kPa*/, masseMoleculaireCarburant/*initié avec chaque carburant, masse molaire*/, vitesseEjectionGaz, gammaGaz, pousseeFusee, debitMassiqueGaz;

        double CalculerPoidsFusee()
        {
            poidsFusee = masseFusee * INTENSITE_GRAV_TERRE;
            return poidsFusee;
        }
        double CalculerVitesseEjectionGaz()
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
        }
        bool DecollageFusee()
        {
            if (CalCulerVitesseDecollage() > CalculerPoidsFusee())
                return true;
            return false;
        }

    }
}
