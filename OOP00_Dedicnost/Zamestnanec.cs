using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00_Dedicnost
{
    class Zamestnanec
    {
        protected string jmeno; //protected - soukromý atribut určený k dědění
        protected string prijmeni;
        protected int odpracHodiny = 0;
        public double HodinovaMzda { get;}
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
        public virtual void OdpracujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }
        public virtual double VypoctiMzdu() //virtual - potomci mohou metodu přepsat
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
