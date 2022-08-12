using System;
using System.Collections.Generic;
using System.Text;

namespace Prius_Service
{
    class Termek
    {
        private string nev;
        private string cikkszam;
        private string vonalkod;
        private string marka;
        private int darabszam;
        private int ar;

        public Termek(string nev, string cikkszam, string vonalkod, string marka, int darabszam, int ar)
        {
            this.Nev = nev;
            this.Cikkszam = cikkszam;
            this.Vonalkod = vonalkod;
            this.Marka = marka;
            this.Darabszam = darabszam;
            this.Ar = ar;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Vonalkod { get => vonalkod; set => vonalkod = value; }
        public string Marka { get => marka; set => marka = value; }
        public int Darabszam { get => darabszam; set => darabszam = value; }
        public int Ar { get => ar; set => ar = value; }
    }
}
