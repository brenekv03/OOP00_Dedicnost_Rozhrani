using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00_Dedicnost
{
    class Ridic : Zamestnanec
    {
        private string skupina;
        private int ujetoCelkem = 0;
        public Ridic(string jmeno, string prijmeni, double hodinovaMzda):base(jmeno,prijmeni,hodinovaMzda)
        {

        }
        public Ridic(string jmeno, string prijmeni, double hodinovaMzda, string skupina) : base(jmeno, prijmeni, hodinovaMzda)
        {
            this.skupina = skupina;
        }
        public string GetSkupina()
        {
            return skupina;
        }
        public int GetUjetoCelkem()
        {
            return ujetoCelkem;
        }
        public int GetOdpracovaneHodiny()
        {
            return odpracHodiny;
        }
        public void SetSkupina(string skupina)
        {
            this.skupina = skupina;
        }
        public override void OdpracujHodiny(int hodiny, int ujedKilometry)
        {
            ujetoCelkem += ujedKilometry;
            base.OdpracujHodiny(hodiny);
        }
        public override double VypoctiMzdu()
        {
            double priplatek = base.VypoctiMzdu();
            if (ujetoCelkem > 5000) priplatek += 3000;
            return priplatek;
        }
        public override string ToString()
        {
            return base.ToString() + "\nSkupina ŘO: " + skupina + "\nUjeto celkem: " + ujetoCelkem ;
        }
    }
}
