using System;

namespace entity
{
      class CargaisonRoutiere:Cargaision
    {
        public CargaisonRoutiere(int distance) : base(distance)
        {

        }
        public override double Cout()
        {
            if (getVolumeTotale() < 38000)
                return 4 * distance * getPoidsTotale();
            else
                return 6 * distance * getPoidsTotale();
        }
        public override string ToString()
        {
            return "Cargaison Routiere Distance ="+distance;
        }
    }
}
