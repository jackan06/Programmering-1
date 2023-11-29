using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal ska matas in?");
            int antal = int.Parse(Console.ReadLine());
            int[] tal = new int [antal];

            Console.WriteLine("Skriv dina tal?");

            for (int i = 0; i < tal.Length; i++) 
            {
                tal[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Utskrift:");

            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write(tal[i] + "\t");
            }
            


            Console.ReadKey();
        }
    }
}
