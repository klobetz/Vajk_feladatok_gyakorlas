using System;

namespace aouto_erettsegi
{
    public class Adatszerkezet
    {
        public int Nap { get; set; }
        public string Ido { get; set; }
        public string Rendszam { get; set; }
        public int Azonosito { get; set; }
        public int Km { get; set; }
        public int Kibehajtas { get; set; }

        public Adatszerkezet(int nap, string ido, string rendszam, int azonosito, int km, int kibehajtas)
        {
            this.Nap = nap;
            this.Ido = ido;
            this.Rendszam = rendszam;
            this.Azonosito = azonosito;
            this.Km = km;
            this.Kibehajtas = kibehajtas;
        }


        //public DateTime MyProperty { get; set; }

    }
}