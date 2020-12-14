using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaOBjekt
{
    class Klasa
    {
        string ime;
        int godRod;

        public string Ime { get => ime; set => ime = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            string ispis = "String: " + this.ime + "\rInt:  " + this.godRod;
            return base.ToString();
        }

        public Klasa(string ime, int godRod)
        {
            this.ime = ime;
            this.godRod = godRod;
        }

    }
}
