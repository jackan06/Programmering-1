using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[1000];
            Random rnd = new Random();
            int[] siffra = new int[6];

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = rnd.Next(1,7);
                Console.Write(tal[i] + "\t");
                siffra[(tal[i] - 1)]++;
                
                //for (int j = 1; j < 7; j++)
                //{
                //    if (tal[i] == j)
                //    {
                //        siffra[j-1] ++;
                //    }
                //}
            }

            Console.Write("\n");

            for (int j = 0;j< siffra.Length; j++)
            {
                Console.WriteLine("Antal tärningsslag med siffran "+(j+1)+" är " + siffra[j]);
                Console.WriteLine("Sannolikheten att slå tärningen och få siffran " + (j + 1) + " är " +  siffra[j]/1000.0);
            }

            Console.ReadKey();
        }
    }
}
