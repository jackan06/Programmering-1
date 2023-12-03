using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A_uppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tio strängar");
            string[] sträng = new string[10];

            for (int i=0;i<sträng.Length;i++)
            {
                sträng[i]=Console.ReadLine();
            }

            Console.WriteLine();

            for (int i=0;i<sträng.Length; i++)
            {
                if (sträng[i][0] == 'a' || sträng[i][0] == 'A') 
                {
                    Console.WriteLine(sträng[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
