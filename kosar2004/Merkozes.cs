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

        public string Helyszin { get => helyszin; set => helyszin = value; }
        public DateTime Idopont { get => idopont; set => idopont = value; }
        internal Csapat Hazai { get => hazai; set => hazai = value; }
        internal Csapat Vendeg { get => vendeg; set => vendeg = value; }

        public override string? ToString()
        {
            return $"{hazai} {vendeg} {helyszin} {idopont}";
        }
    }
}
