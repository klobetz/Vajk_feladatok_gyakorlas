using System;

namespace aouto_erettsegi
{
    public class Adatszerkezet
    {
        public int nap { get; set; }
        public string ido { get; set; }
        public string rendszam { get; set; }
        public int azonosito { get; set; }
        public int km { get; set; }
        public int kibehajtas { get; set; }

        public Adatszerkezet(int nap, string ido, string rendszam, int azonosito, int km, int kibehajtas)
        {
            this.nap = nap;
            this.ido = ido;
            this.rendszam = rendszam;
            this.azonosito = azonosito;
            this.km = km;
            this.kibehajtas = kibehajtas;
        }


        //public DateTime MyProperty { get; set; }

    }
}