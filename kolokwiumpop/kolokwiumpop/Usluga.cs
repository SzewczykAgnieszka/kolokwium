using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumpop
{
    class Usluga
    {
        protected DateTime czas;
        protected double cena;

        void ObliczCene() { }

        public Usluga() { }

        protected internal Usluga(DateTime czas, double cena)
        {
            this.czas = czas;
            this.cena = cena;
        }
    }
}
