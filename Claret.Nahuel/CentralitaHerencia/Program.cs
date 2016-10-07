using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Lopez");

            Local local1 = new Local("CABA", 30, "CABA", (float)2.65);
            Provincial prov1 = new Provincial("CABA", Franja.Franja_1, 21, "CORDOBA");
            Local local2 = new Local("CABA", 45, "CABA", (float)1.99);
            Provincial prov2 = new Provincial(Franja.Franja_3, prov1);

            centralita.

        }
    }
}
