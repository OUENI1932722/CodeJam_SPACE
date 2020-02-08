using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_SPACE
{
    class MeteoActuel
    {      
        private List<Meteo> meteos = new List<Meteo>();
        private Random random = new Random();

        public MeteoActuel(List<Meteo> meteos)
        {
            this.meteos = meteos;
            changerMeteo();
        }
        public string Nom { get; set; }
        public void changerMeteo()
        {
            Pression = random.Next(970, 1041);
            int i = 0;
            bool meteo = false;
            while (!(meteo))
            {
                if (meteos[i].estMeteo(Pression))
                {
                    meteo = true;
                    Nom = meteos[i].Nom;
                    Temperature = meteos[i].getTemperature();
                }
                i++;
            }
        }
        public int Pression { get; private set; }
        public double Temperature { get; private set; }
        public override string ToString()
        {
            return "Météo currente : " + Nom + "\nTempérature : " + Temperature + " Celcius\nPression : " + Pression + " hectoPascal";
        }
    }
}
