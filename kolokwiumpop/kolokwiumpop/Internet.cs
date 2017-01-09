using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumpop
{
    class Internet : Usluga
    {
        private int iloscMB;

        double ObliczCene(int iloscMB, double cena)
        {
            return cena = iloscMB / 756;
        }

        private Internet(DateTime czas, int iloscMB)
        {
            this.czas = czas;
            this.iloscMB = iloscMB;
        }
        public override string ToString()
        {
            return "Internet, data i godzina internetu: " + czas + ", ilośćMB: " + iloscMB + "łączny koszt: " + cena;
        }
    }
}
