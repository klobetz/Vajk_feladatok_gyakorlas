using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyedeves_sima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Adatszerkezet>();

            using (var fs = new FileStream("Negyedeves.txt", FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    //var elsosor = sr.ReadLine(); ha az első sort ki kell hagyni!
                    while (!sr.EndOfStream)
                    {
                        var a = new Adatszerkezet();
                        a.megye = sr.ReadLine();
                        a.elson = int.Parse(sr.ReadLine().Replace(" ", ""));
                        a.masodikn = sr.ReadLine().Replace(" ", "");
                        a.harmadikn = sr.ReadLine();
                        a.negyedikn = sr.ReadLine();

                        list.Add(a);

                    }
                }
            }

            Console.WriteLine($"a fájl {list.Count()} elemet tartalmaz\n");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.megye,-25}{item.elson}{item.masodikn,20}{item.harmadikn,20}");
            }

            Console.ReadLine();
        }
    }
}
