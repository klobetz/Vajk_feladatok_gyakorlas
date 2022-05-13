﻿using System;
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
                        var a = new Adatszerkezet();
                        a.nap = int.Parse(sor[0]);
                        a.ido = sor[1];
                        a.rendszam = sor[2];
                        a.azonosito = int.Parse(sor[3]);
                        a.kibehajtas = int.Parse(sor[4]);
                        lista.Add(a);
                    }
                }
            }

            foreach (var adat in lista)
            {
                Console.WriteLine(adat.rendszam);
            }

            Console.ReadLine();
        }
    }
}