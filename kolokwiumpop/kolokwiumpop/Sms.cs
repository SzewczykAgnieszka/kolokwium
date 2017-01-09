using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumpop
{
    class Sms : Usluga
    {
        private string numer;

        double ObliczCene(double cena)
        {
            return cena = 0.155;
        }

        private Sms(DateTime czas, string numer)
        {
            this.czas = czas;
            this.numer = numer;
        }

        public override string ToString()
        {
            return "Sms: numer " + numer + ", data i godzina smsa: " + czas + "łączny koszt: " + cena;
        }
    }
}
