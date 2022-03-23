using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szöveg_csere
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>() { 25,45,1,5,7,8,45,8,5,8,65,4635,4};


            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Sum());

            Console.ReadLine();
        }
    }
}
