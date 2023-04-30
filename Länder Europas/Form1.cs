using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Länder_Europas
{
    public partial class Form1 : Form
    {
        //Attribute

        StreamReader myReader = new StreamReader("LaenderEuropasMehr.csv");
        List<Länder> LänderListe = new List<Länder>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            myReader.ReadLine();
            while (!myReader.EndOfStream)
            {
                string eineZeile = myReader.ReadLine();
                string[] UserArayEineZeile = eineZeile.Split(',');
                LänderListe.Add(new Länder(UserArayEineZeile[0], UserArayEineZeile[1], UserArayEineZeile[2], UserArayEineZeile[3], UserArayEineZeile[4]));
            }

            foreach (var item in LänderListe)
            {
                Liste.Items.Add(item.name);
            }
            AlleLänderAusgeben();

        }
        private void AlleLänderAusgeben()
        {
            foreach (Länder person in LänderListe)
            {
                person.datenAusgeben(textBox1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Länder person in LänderListe)
            {
                if (Liste.SelectedItem.ToString() == person.name)
                {
                    person.datenAusgeben(textBox1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "  ";
            Länder MaxEinwohner = LänderListe[0];
            foreach (Länder Max in LänderListe)
            {
               if (Convert.ToInt32( Max.einwohner )> Convert.ToInt32(MaxEinwohner.einwohner))
                {
                    MaxEinwohner = Max;
                }
            }
            MaxEinwohner.datenAusgeben(textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "  ";
            Länder MinEinwohner = LänderListe[0];
            foreach (Länder Min in LänderListe)
            {
                if (Convert.ToInt32(Min.einwohner) < Convert.ToInt32(MinEinwohner.einwohner))
                {
                    MinEinwohner = Min;
                }
            }
            MinEinwohner.datenAusgeben(textBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "  ";
            int Durchschnitt = 0;
            foreach (Länder land in LänderListe)
            {
                Durchschnitt += Convert.ToInt32( land.einwohner);
            }
            textBox4.Text = "Einwohnerdurchschnitt: " + Durchschnitt / LänderListe.Count();
        }
    }
}
