using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;

        public Pacjent()
        {

        }
        public Pacjent(string imieNazwisko,int wiek,string choroba)
        {
            this.imieNazwisko = imieNazwisko;
            this.wiek = wiek;
            this.choroba = choroba;
        }
        
        public override string ToString()
        {
            return "Pacjent,imie,nazwisko:" + imieNazwisko + ",wiek" + wiek + ",choroba:" + choroba + ".";
        }
        public string zwrocImieNazwisko()
        {
            return imieNazwisko;
        }
        public int zwrocWiek()
        {
            return wiek;
        }
        public string zwrocChorobe()
        {
            return choroba;
        }
    }
}
