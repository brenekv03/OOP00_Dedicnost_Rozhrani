using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP00_Dedicnost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamestnanec zamestnanec = new Zamestnanec("Eva", "Nováková", 100);
            MessageBox.Show(zamestnanec.GetJmeno());
            MessageBox.Show(zamestnanec.ToString());

            zamestnanec.SetPrijmeni("Pospíchalová");
            MessageBox.Show(zamestnanec.ToString());

            zamestnanec.OdpracujHodiny(20);
            MessageBox.Show(zamestnanec.ToString());
            zamestnanec.OdpracujHodiny(150);
            MessageBox.Show(zamestnanec.ToString());
        }
    }
}
