using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class Meteo
    {
        private Random random = new Random();
        private int temperatureMin;
        private int temperatureMax;
        private int pressionMin;
        private int pressionMax;
        public Meteo(string nom, int temperatureMin, int temperatureMax, int pressionMin, int pressionMax)
        {
            Nom = nom;
            this.temperatureMin = temperatureMin;
            this.temperatureMax = temperatureMax;
            this.pressionMin = pressionMin;
            this.pressionMax = pressionMax;
        }
        public string Nom { get; private set; }
        public double getTemperature()
        {
            return Math.Round(random.Next(temperatureMin, temperatureMax) + random.NextDouble(),1);
        }
        public bool estMeteo(int pression)
        {
            if (pression >= pressionMin && pression <= pressionMax)
                return true;
            else
                return false;
        }
    }
}
