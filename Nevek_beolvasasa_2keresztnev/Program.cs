using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevek_beolvasasa_2keresztnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Adatszerkezet>()                ;
            using (var fs = new FileStream("Nevek.txt", FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    var fejlec = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine().Split(' ');
                        var adat = new Adatszerkezet(
                            sor[0],
                            sor[1],
                            sor.Length > 2 ? sor[2] : ""      //egy soros if-el lehet megcsinálni ha konstruktorba szeretnéd beolvasni
                                                              //mert a 3. elemet is fel kell tölteni ilyenkor valamivel PL: "" (üres karakter)
                        );

                        lista.Add(adat);
                    }
                }
            }

            foreach (var item in lista)
            {

                Console.WriteLine($"{item.knev2}");


            }

            Console.ReadLine();
        }

    }
    
}
