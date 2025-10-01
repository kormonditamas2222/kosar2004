using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Feladatok
    {
        List<Merkozes> lista;

        public Feladatok()
        {
            lista = new List<Merkozes>();
            Beolvas("eredmenyek.csv");
        }

        internal List<Merkozes> Lista { get => lista; set => lista = value; }

        private void Beolvas(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(";");
                Csapat hazai = new Csapat(adatok[0], int.Parse(adatok[2]));
                Csapat vendeg = new Csapat(adatok[1], int.Parse(adatok[3]));
                string helyszin = adatok[4];
                DateTime idopont = Convert.ToDateTime(adatok[5]);
                lista.Add(new Merkozes(hazai, vendeg, helyszin, idopont));
            }
        }
    }
}
