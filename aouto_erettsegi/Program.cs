using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aouto_erettsegi
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

                        var adat = new Adatszerkezet(
                            int.Parse(sor[0]),
                            sor[1],
                            sor[2],
                            int.Parse(sor[3]),
                            int.Parse(sor[4]),
                            int.Parse(sor[5])
                            );
                        lista.Add(adat);
                    }
                }
            }
            //lista bejárása
            foreach (var adat in lista)
            {
                Console.WriteLine(adat.Rendszam);                
            }
            
            Console.WriteLine($"A lista {lista.Count} db elemet tartalmaz");

            //az azonosító kiíratása növekvő sorrendben
            lista.OrderBy(x => x.Azonosito).ToList().ForEach(x => Console.WriteLine(x.Azonosito));

            Console.ReadLine();
        }
    }
}
