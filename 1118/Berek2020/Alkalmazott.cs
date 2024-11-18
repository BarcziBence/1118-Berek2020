using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class Alkalmazott
    {
        private string nev;
        private bool nem;
        private string reszleg;
        private int belepes;
        private int fizetes;

        public string Nev { get => nev; set => nev = value; }
        public bool Nem { get => nem; set => nem = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int Belepes { get => belepes; set => belepes = value; }
        public int Fizetes { get => fizetes; set => fizetes = value; }

        public Alkalmazott(string r)
        {
            var split = r.Split(';');
            Nev = split[0];
            Reszleg = split[2];
            Belepes = int.Parse(split[3]);
            Fizetes = int.Parse(split[4]);
            Nem = true;
            if (split[1] == "férfi") { Nem = false; }
        }

        public override string ToString()
        {
            return $"{Nev} " +
                (Nem ? "nő " : "férfi ")  +
                $"{Reszleg} " +
                $"{Belepes} " +
                $"{Fizetes}";
        }
    }
}
