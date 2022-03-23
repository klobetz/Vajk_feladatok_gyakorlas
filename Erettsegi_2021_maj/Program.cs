using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erettsegi_2021_maj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var fajl = "melyseg.txt";

            var tomb = new int[2000];
            var list = new List<int>();

            using (var fs = new FileStream("melyseg.txt", FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    //var elsosor = sr.ReadLine(); ha az első sort ki kell hagyni!
                    while (!sr.EndOfStream)
                    {
                        //ez ha listát használsz
                        var sor = sr.ReadLine();
                        list.Add(int.Parse(sor));
                    }
                }
            }

            Console.WriteLine($"A lista elemei: {list.Count()}");


            foreach (var item in list)
            {
                Console.Write($" ,{item}");
            }





            Console.ReadKey();

        }
    }
}
