﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Lekarz : Osoba
    {
        private string specjalnosc;
        public Lekarz(string imieNazwisko, string specjalnosc)
        {
            this.imieNazwisko = imieNazwisko;
            this.specjalnosc = specjalnosc;
        }
        public override string ToString()
        {
            return "Lekarz,imię i nazwisko:" + imieNazwisko + ", specjalność:" + specjalnosc;
        }
    }
}
