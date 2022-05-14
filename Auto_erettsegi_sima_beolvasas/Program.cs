using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_erettsegi_sima_beolvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Adatszerkezet>();

            using (var fs = new FileStream("autok.txt", FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    //var fejlec = sr.ReadLine(); //a fejléc kivétele a fájlból
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine().Split();
                        var adat = new Adatszerkezet();

                        adat.Nap = int.Parse(sor[0]);
                        adat.Ido = sor[1];
                        adat.Rendszam = sor[2];
                        adat.Azonosito = int.Parse(sor[3]);
                        adat.Km = int.Parse(sor[4]);
                        adat.Kibehajtas = int.Parse(sor[5]);
                        
                        lista.Add(adat);
                    }
                }
            }

            foreach (var elem in lista)
            {
                Console.WriteLine(elem.Rendszam);
            }


            Console.ReadLine();
        }
    }
}
