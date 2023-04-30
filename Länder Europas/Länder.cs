using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Länder_Europas
{
    class Länder
    {
        //Attribute
        public string name;
        public string haubtstadt;
        public string fläche;
        public string einwohner;
        public string BIP;
        //public string einwohnerProFläche;

        //Konstruktor
        public Länder(string name, string haubtstadt, string fläche, string einwohner, string BIP )
           // string einwohnerProFläche
        {

            this.name = name;
            this.haubtstadt = haubtstadt;
            this.fläche = fläche;
            this.einwohner = einwohner;
            this.BIP = BIP;
            try { int Menschen = Convert.ToInt32(einwohner); }
            catch { Console.WriteLine(einwohner); }
            //this.einwohnerProFläche = einwohnerProFläche;
        }

        //Methoden
        public void datenAusgeben(TextBox txtBox)
        {
            txtBox.Text += "Name: " + this.name + "\r\nHaubtstadt: " + this.haubtstadt + "\r\nFläche: " + this.fläche + "\r\nEinwohner: " + this.einwohner + "\r\nBIP in Mrd.: " + this.BIP  +"\r\n";
            //txtBox.Text += "\r\nPasswort: " + this.passwort + "\r\n"; 
            //"\r\nEinwohner pro Fläche" + this.einwohnerProFläche

        }

    }
}
