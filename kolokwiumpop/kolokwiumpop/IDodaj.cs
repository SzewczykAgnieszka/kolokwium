using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumpop
{
    interface IDodaj
    {
        void DodajPolaczenie(string numer, int czas);
        void DodajSms(string numer);
        void DodajInternet(int iloscMB);
    }
}
