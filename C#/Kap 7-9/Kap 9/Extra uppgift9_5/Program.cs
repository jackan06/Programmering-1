using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_uppgift9_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string utskrift = "";
            char svar = 'j';

            while (svar == 'j')
            {
                Console.WriteLine("Skriv tal:");
                utskrift += Console.ReadLine() + "\t";
                Console.WriteLine("Vill du fortsätta (j/n)");
                svar = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dina tal är " + utskrift);
            
            


            Console.ReadKey();
        }
    }
}
