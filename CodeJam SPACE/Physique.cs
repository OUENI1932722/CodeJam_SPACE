﻿using System;
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

        private readonly double INTENSITE_GRAV_TERRE = 9.8/*N/kg*/;
        private double poidsFusee, masseFusee = 78000, masseCarburant = 15000, pousseeFusee = 5255000, debitMasique, densiteGaz = 1.03, accelerationFusee, vitesseFusee = 0, hauteur = 0, impulsionSpecifique = 16056;
        private Fusee fusee;


        public Physique(/*Fusee fusee*/)
        {
           // this.fusee = fusee;
        }
        void CalculerPoidsFusee()
        {
            poidsFusee = (masseFusee + masseCarburant) * INTENSITE_GRAV_TERRE;
        }
        void CalculerAcceleration()
        { 
            accelerationFusee = (pousseeFusee - poidsFusee) / (masseFusee + masseCarburant); //wrong? Voir http://www.rocket-simulator.com/simulator_calc.php  et https://en.wikipedia.org/wiki/Tsiolkovsky_rocket_equation#Examples et https://fr.wikipedia.org/wiki/Moteur-fusée_à_ergols_liquides#Caractéristiques_de_quelques_moteurs-fusées_à_ergols_liquides
        }
        void CalculerPerteMasse()
        {
            debitMasique = pousseeFusee / impulsionSpecifique;
        }
        void CalculerVitesseFusee()
        {
            vitesseFusee += accelerationFusee;
        }
        void CalculerHauteurFusee()
        {
            hauteur += vitesseFusee;
        }
        public void MiseAJour()
        {
            int timer = 0;
            while (hauteur >= 0)
            {
                System.Threading.Thread.Sleep(1000);
                CalculerPoidsFusee();
                CalculerAcceleration();
                CalculerVitesseFusee();
                CalculerHauteurFusee();
                if (masseCarburant > 0)
                {
                    CalculerPerteMasse();
                    masseCarburant -= debitMasique;
                }
                else
                {
                    pousseeFusee = 0;
                    masseCarburant = 0;
                }
                Console.SetCursorPosition(0,0);
                Console.Write("Vitesse : " + vitesseFusee + "\nPoids : " + poidsFusee + "\nAcceleration : " + accelerationFusee + "\nQuantité de carburant : " + masseCarburant + "\nHauteur : " + hauteur + "\nDebit massique: " + debitMasique);
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
