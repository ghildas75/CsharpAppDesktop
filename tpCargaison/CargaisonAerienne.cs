using System;

namespace entity
{
    class CargaisonAerienne : Cargaision
    {
        public CargaisonAerienne(int distance) : base(distance)
        {

        }
        public override double Cout()
        {
            if (getVolumeTotale() < 80000)
                return 10 * distance * getPoidsTotale();
            else
                return 12 * distance * getPoidsTotale();
        }
        public override string ToString()
        {
            return "Cargaison Aerienne Distance =" + distance;
        }
    }
}

