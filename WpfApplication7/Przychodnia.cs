using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace WpfApplication7
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();

        public void UstawLekarza(string imieNazwisko, string specjalnosc)
        {
            lekarz = new Lekarz(imieNazwisko,specjalnosc);
        }
        public  void DodajDoKolejki(string imieNazwisko,int wiek,string choroba)
        {
            Pacjent pacjent = new Pacjent(imieNazwisko,wiek,choroba);
            pacjenci.Enqueue(pacjent);
        }
        public string WykonajPorade()
        {
             Pacjent ktos = pacjenci.Dequeue();
             return "Wykonano poradę! Pacjent, imię i nazwisko: " + ktos.zwrocImieNazwisko() + ",wiek" + ktos.zwrocWiek() + "choroba:" + ktos.zwrocChorobe();
        }
        public string WykonajBadanie()
        {
            Pacjent ktos = pacjenci.Peek();
            return "Wykonano badanie! Pacjent, imię i nazwisko: " + ktos.zwrocImieNazwisko() + ",wiek" + ktos.zwrocWiek() + "choroba:" + ktos.zwrocChorobe();
        }
        public int CzasOczekiwania()
        {

            return pacjenci.Count() / 4;
        }
        public  override string ToString()
        {
            string pacj = "";
            foreach(var z in pacjenci)
            {
                pacj += z.ToString() + "/n";
            }
            return lekarz.ToString() + pacj + "CzasOczekiwania:" + CzasOczekiwania();
        }
        public void GenerujRaport()
        {
            DateTime x = DateTime.Now;
            using (StreamWriter sw = new StreamWriter(x.ToString() + ".txt"))
            {
                sw.Write(ToString());
            }
           
        }
        public bool CzyLekarz()
        {
            return lekarz != null;
        }
    }
}
