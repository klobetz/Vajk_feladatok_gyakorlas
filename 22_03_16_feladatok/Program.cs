using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_03_16_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kérjünk be a felhasználótól egy számot és akkora tömböt hozzon létre és töltsük fel véletlen számokkal 1-100-ig

            Console.Write("Kérek egy számot: ");
            var valasz = int.Parse(Console.ReadLine());
            var r = new Random();
            var tomb = new int[valasz];

            for (int i = 0; i < valasz; i++)
            {
                tomb[i] = r.Next(101);
                Console.WriteLine(tomb[i]);
            }

            //vagyük ki a legkisebb és a legnagyobb elemet és írasuk ki a képernyőre
            Console.WriteLine($"A legnagyobb értéka a többől: {tomb.Max()} \nA legkisebb a: {tomb.Min()}");

            //rendezzük a tömb elemeit növekvő sorrendbe
            Console.WriteLine();
            Array.Sort(tomb);
            foreach (var elemek in tomb)
            {
                Console.WriteLine(elemek);
            }

            //rendezzük a tömb elemeit csökkenő sorrendbe
            Console.WriteLine();
            Array.Reverse(tomb);
            foreach (var elemek in tomb)
            {
                Console.WriteLine(elemek);
            }

            Console.WriteLine($"A tömb elemeinek az összege: {tomb.Sum()}");

            Console.ReadKey();
        }
    }
}
