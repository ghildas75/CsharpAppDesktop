using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    abstract class Cargaision
    {
        protected int distance;
        protected List<Marchandise> marchandises = new List<Marchandise>();

        public Cargaision(int distance)
        {
            this.distance = distance;
        }
        public void Add(Marchandise m)
        {
            marchandises.Add(m);
        }
        public void Afficher()
        {
            foreach (var item in marchandises)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Marchandise GetMarchandiseBynum(int num)
        {
            foreach (Marchandise item in marchandises)
            {
                if (item.Numero == num) return item;

            }
            throw new Exception("MARACHANDISE INTROUVABLE");
        }
        public double getVolumeTotale()
        {
            double volumTotal = 0;
            foreach (var item in marchandises)
            {
                volumTotal += item.Volume;
            }
            return volumTotal;
        }

        public double getPoidsTotale()
        {
            double PoidsTotal = 0;
            foreach (var item in marchandises)
            {
                PoidsTotal += item.Poids;
            }
            return PoidsTotal;
        }
        public List<Marchandise> getMarchandises()
        {
            return marchandises;
        }
        public abstract double Cout();
    }
}
