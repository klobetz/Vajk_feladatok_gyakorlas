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
            var valasz = Convert.ToInt32(Console.ReadLine());
            //var valasz2 = int.Parse(Console.ReadLine());
            valami = 0;
            valami2 = "Szövegem";
            

            var lista = new List<int>() { 1,5,7,4,8,5,6,};

            foreach (var szam in lista)
            {
                Console.Write($"{szam}, ");
            }

             
            


            Console.ReadLine();
        }
    }
}
