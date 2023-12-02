using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tio tecken");
            char[] tecken = new char[10];
            int antalAB = 0;

            for(int i = 0; i < tecken.Length; i++)
            {
                tecken[i]=char.Parse(Console.ReadLine());

                if (tecken[i] == 'a' || tecken[i] == 'b' || tecken[i] == 'A' || tecken[i] == 'B')
                {
                    antalAB++;
                }
            }

            Console.WriteLine("\nDe skrivna tecken är: ");
            foreach(char c in tecken)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Antal a och b i fältet är " + antalAB);


            Console.ReadKey();
        }
    }
}
