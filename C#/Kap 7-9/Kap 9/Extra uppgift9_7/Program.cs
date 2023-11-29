using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in tal, avsluta med 0");
            int tal = int.Parse(Console.ReadLine());
            int summa = tal;
            int antalTvåor = 0;

            while (tal != 0)
            {
                if (tal == 2)
                {
                    antalTvåor++;
                }

                tal = int.Parse(Console.ReadLine());
                summa += tal;
            }
            Console.WriteLine("Summan av alla tal är " + summa + " och antalet tvåor är " + antalTvåor);

            Console.ReadKey(); 
        }
    }
}
