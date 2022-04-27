using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00_Dedicnost
{
    class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private int odpracHodiny = 0;
        public double HodinovaMzda { get; }
        public Zamestnanec(string jmeno, string prijmeni, double hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            HodinovaMzda = hodinovaMzda;
        }
        public string GetJmeno()
        {
            return jmeno;
        }
        public string GetPrijmeni()
        {
            return prijmeni;
        }
        public void SetPrijmeni (string prijmeni)
        {
            this.prijmeni = prijmeni;
        }
        public void OdpracujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }
        public double VypoctiMzdu()
        {
            return odpracHodiny * HodinovaMzda;
        }
        public bool Bonusy ()
        {
            return odpracHodiny >= 160;
        }
        public override string ToString()
        {
            string maBonus = "NE (Nemá nárok)";
            if (Bonusy()) maBonus = "ANO (Má nárok)";
            string s = "Jméno: " + jmeno
                     + "\nPříjmení: " + prijmeni
                     + "\nOdpracované hodiny: " + odpracHodiny
                     + "\nHodinová mzda: " + HodinovaMzda
                     + "\nVypočtená mzda: " + VypoctiMzdu()
                     + "\nZaměstnanecké bonusy: " + maBonus;
            return s;
        }
    }
}
