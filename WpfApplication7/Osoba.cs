using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    abstract class Osoba
    {
        protected string imieNazwisko;

        public Osoba()
        {

        }
        public Osoba(string imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
        }
        
    }
}
