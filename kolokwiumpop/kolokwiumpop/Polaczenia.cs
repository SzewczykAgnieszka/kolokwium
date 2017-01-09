using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumpop
{
    class Polaczenia : Usluga
    {
        private string numer;
        private int czasP;

        double ObliczCene(double cena, int czas)
        {
            return cena = czasP * 0.29;
        }

        Polaczenie(DateTime czas, string numer, int czasP)
        {
            this.czas = czas;
            this.numer = numer;
            this.czasP = czasP;
        }

        public override string ToString()
        {
            return "Połączenie: numer " + numer + ", data i godzina rozmowy: " + czas + ", długość trwania:  " + czasP + "łączny koszt: " + cena;
        }
    }
}
