using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Csapat
    {
        string name;
        int pontszam;

        public Csapat(string name, int pontszam)
        {
            this.name = name;
            this.pontszam = pontszam;
        }

        public string Name { get => name; set => name = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
        public override string? ToString()
        {
            return $"{name} {pontszam}";
        }
    }
}
