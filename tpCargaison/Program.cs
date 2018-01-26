using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity;
namespace test
{
    class Program
    {
        static void Main2(string[] args)
        {
            Cargaision c1 = new CargaisonRoutiere(80);
            c1.Add(new Marchandise( 60, 70));
            c1.Add(new Marchandise( 80, 70));
            c1.Add(new Marchandise(90, 70));
            c1.Afficher();
            Console.WriteLine("cout de la caragaison routier" + c1.Cout());
            Console.ReadKey();


        }
    }
}
