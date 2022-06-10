using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sorozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("Meddig írassam ki a sorozat elemeit: ");
            var valasz = Console.ReadLine();

            int szam;
            while (!int.TryParse(valasz, out szam)||szam<0)
            {
                Console.WriteLine("Nem megfelelő az érték!");
                valasz = Console.ReadLine();
            }

            for (int i = 0; i < int.Parse(valasz); i++)
            {

            }



            Console.ReadLine();

        }
    }
}
