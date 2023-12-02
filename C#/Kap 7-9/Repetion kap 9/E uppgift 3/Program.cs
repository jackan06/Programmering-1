using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            int tal = int.Parse(Console.ReadLine());

            if (tal % 7 == 0)
            {
                Console.WriteLine("Talet är jämnt delbart med 7");
            }
            else
            {
                Console.WriteLine("Talet är inte jämnt delbart med 7, det blir rest");
            }


            Console.ReadKey();
        }
    }
}
