using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal");
            int[] tal = new int[2];
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }

            if (tal[0] > tal[1])
            {
                Console.WriteLine("Tal " + tal[0] + " är stört");
            }
            else if (tal[0] < tal[1])
            {
                Console.WriteLine("Tal " + tal[1] + " är stört");
            }
            else
            {
                Console.WriteLine("Talen är lika stora");   
            }
            Console.ReadKey();
        }
    }
}
