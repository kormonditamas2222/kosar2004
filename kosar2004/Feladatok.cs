using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        string harom;
        string negy;
        string ot;
        List<string> hat;
        string het;

        public Feladatok()
        {
            lista = new List<Merkozes>();
            Beolvas("eredmenyek.csv");
            harom = Harom();
            negy = Negy();
            ot = Ot();
            hat = Hat();
        }

        public string Harom1 { get => harom; }
        public string Negy1 { get => negy; set => negy = value; }
        public string Ot1 { get => ot; set => ot = value; }
        public List<string> Hat1 { get => hat; set => hat = value; }
        public string Het1 { get => het; set => het = value; }
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
        private string Harom() 
        {
            int hazai_szam = 0, vendeg_szam = 0;
            foreach (Merkozes item in lista) 
            {
                if (item.Hazai.Name == "Real Madrid")
                {
                    hazai_szam++;
                }
                else if (item.Vendeg.Name == "Real Madrid")
                {
                    vendeg_szam++;
                }
            }
            return $"3. feladat: Real Madrid: Hazai: {hazai_szam}, Vendég: {vendeg_szam}";
        }
        private string Negy()
        {
            bool dontetlen = false;
            string output = "4. feladat: Volt döntetlen? ";
            foreach (Merkozes item in lista)
            {
                if (item.Hazai.Pontszam == item.Vendeg.Pontszam)
                {
                    dontetlen = true;
                } 
            }
            if (dontetlen)
            {
                return output + "igen";
            }
            else { return output + "nem";}
        }
        private string Ot()
        {
            bool jatszottE = false;
            string csapatNeve = "";
            string output = "5. feladat: barcelonai capat neve: ";
            foreach (Merkozes item in lista)
            {
                if (item.Hazai.Name.ToLower().Contains("barcelona"))
                {
                    csapatNeve = item.Hazai.Name;
                    jatszottE = true;
                }
            }
            if (jatszottE)
            {
                return output + csapatNeve;
            }
            else
            {
                return output + " nincs ilyen";
            }
        }
        private List<string> Hat()
        {
            List <string> outputs = new List<string>();
            foreach (Merkozes item in lista)
            {
                if (item.Idopont.Equals(21/11/2004)) // hogyan datetime
                {
                    outputs.Add($"{item.Hazai.Name}-{item.Vendeg.Name} ({item.Hazai.Pontszam}-{item.Vendeg.Pontszam})");
                }
            }
            return outputs;
        }
        
    }
}
