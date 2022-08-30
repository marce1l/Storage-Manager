using System;
using System.Collections.Generic;
using System.Text;

namespace Prius_Service
{
    public class Termek
    {
        private string nev;
        private string cikkszam;
        private string marka;
        private string vonalkod;
        private int darabszam;
        private int minDarabszam;
        private int beszerzesiAr;
        private int eladasiAr;

        public Termek(string nev, string cikkszam, string marka, string vonalkod, int darabszam, int minDarabszam, int beszerzesiAr, int eladasiAr)
        {
            this.Nev = nev;
            this.Cikkszam = cikkszam;
            this.Marka = marka;
            this.Vonalkod = vonalkod;
            this.Darabszam = darabszam;
            this.MinDarabszam = minDarabszam;
            this.BeszerzesiAr = beszerzesiAr;
            this.EladasiAr = eladasiAr;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Vonalkod { get => vonalkod; set => vonalkod = value; }
        public int Darabszam { get => darabszam; set => darabszam = value; }
        public int MinDarabszam { get => minDarabszam; set => minDarabszam = value; }
        public int BeszerzesiAr { get => beszerzesiAr; set => beszerzesiAr = value; }
        public int EladasiAr { get => eladasiAr; set => eladasiAr = value; }
    }
}
