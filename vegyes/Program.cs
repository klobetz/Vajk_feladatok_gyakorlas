using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegyes
{
    internal class Program
    {
       
        //golbalis változók
        public static int valami { get; private set; }
        public static string valami2 { get; private set; }

        static void Main(string[] args)
        {            
           
            Console.WriteLine("Kérek egy számot: ");
            var valasz = double.Parse(Console.ReadLine());
            //var valasz2 = int.Parse(Console.ReadLine());
            valami = 0;
            valami2 = "Szövegem";
            

            var lista = new List<int>() { 1,5,7,4,8,5,6,};

            foreach (var szam in lista)
            {
                Console.Write($"{szam}, ");
            }

            
            //páros vagy páratlan vizsgálata
            var maradekososztas = valasz / 2;
            var egeszszam = Convert.ToInt32(valasz/2);

            Console.WriteLine();
            if (maradekososztas == egeszszam)
            {
                Console.WriteLine($"a beírt szám {valasz} páros");
            }
            else
            {
                Console.WriteLine($"a beírt szám {valasz} páratlan");
            }
            
            var paros = 11 % 7;
            var paratlan = valasz % 3;

            Console.WriteLine(paros);

            if (valasz%2==0)
            {
                Console.WriteLine("páros");
            }

            else
            {
                Console.WriteLine("páratlan");
            }




            Console.ReadLine();
        }
    }
}
