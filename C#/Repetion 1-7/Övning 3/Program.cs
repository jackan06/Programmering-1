using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tre-siffrigt tal:");
            int tal = int.Parse(Console.ReadLine());
            int siffra1 = tal / 100;
            int siffra2 = (tal % 100) / 10;
            int siffra3 = tal % 10;
            int summa= siffra1 + siffra2 + siffra3;

            Console.WriteLine("Summan av siffrorna är " + summa);

            Console.ReadKey();
        }
    }
}
