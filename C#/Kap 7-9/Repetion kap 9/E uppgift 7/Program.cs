using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tio decimaltal");
            double[] tal = new double[10];

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int j = 0; j < tal.Length; j++)
            {
                if (tal[j]>=2.78 && tal[j] <= 3.14)
                {
                    Console.WriteLine(tal[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
