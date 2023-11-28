using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett heltal:");
            int heltal = int.Parse(Console.ReadLine());

            if (heltal%2 == 0)
            {
                Console.WriteLine("Det är ett jämnt tal");
            }
            else
            {
                Console.WriteLine("Det är inte ett jämnt tal");
            }

            Console.ReadKey();
        }
    }
}
