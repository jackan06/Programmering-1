using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal:");
            int tal = int.Parse(Console.ReadLine());

            for (int i = 1; i <6; i++)
            {
                tal--;
                Console.WriteLine(tal);
            }

            Console.ReadKey();
        }
    }
}
