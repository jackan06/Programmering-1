using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tio strängar");
            string[] sträng = new string[10];

            for (int i=0;i<sträng.Length;i++)
            {
                sträng[i] = Console.ReadLine();
            }

            Console.Write("\n");

            for (int j = 0; j < sträng.Length; j++) 
            {
                if (sträng[j].Length >= 6)
                {
                    Console.WriteLine(sträng[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
