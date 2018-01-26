using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class Marchandise
    {
      
        private static int nbMarchandise;
        private  int numero;
        private double poids;
        private double volume;
        public int Numero { get => numero; set => numero = value; }
        public double Volume { get => volume; set => volume = value; }
        public double Poids { get => poids; set => poids = value; }

        public Marchandise( double poids, double volume)
        {
            this.Numero=++nbMarchandise;
            this.Poids = poids;
            this.Volume = volume;
        }



        public override string ToString()
        {
            return "numero =" + Numero + "Poids=" + Poids + "volume" + Volume;
        }
        
        }
    }

