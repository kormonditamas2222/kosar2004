using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Merkozes
    {
        Csapat hazai;
        Csapat vendeg;
        string helyszin;
        DateTime idopont;

        public Merkozes(Csapat hazai, Csapat vendeg, string helyszin, DateTime idopont)
        {
            this.hazai = hazai;
            this.vendeg = vendeg;
            this.helyszin = helyszin;
            this.idopont = idopont;
        }

        public string Helyszin { get => helyszin; }
        public DateTime Idopont { get => idopont; }
        internal Csapat Hazai { get => hazai; }
        internal Csapat Vendeg { get => vendeg; }

        public override string? ToString()
        {
            return $"{hazai} {vendeg} {helyszin} {idopont}";
        }
    }
}
