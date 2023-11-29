using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] slumptal = new int[8];
            Random random = new Random();
            int summa = 0;
            
            for (int i = 0; i < slumptal.Length; i++)
            {
                slumptal[i] = random.Next(1, 11);
                Console.Write(slumptal[i] +"\t");
                summa += slumptal[i];
                
            }
            Console.WriteLine("\nSumman är: " + summa);

            double medelvärde = (double)summa / slumptal.Length;
            Console.WriteLine("Medelvärdet är: " + Math.Round(medelvärde,2));


            Console.ReadKey();
           
        }
    }
}
