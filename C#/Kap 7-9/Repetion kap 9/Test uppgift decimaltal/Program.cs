using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_uppgift_decimaltal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett decimaltal");
            string decimaltal = Console.ReadLine();
            int summa = 0;
            int[] tal = new int[decimaltal.Length];
            bool felInmatning = false;

            for (int i = 0; i < decimaltal.Length && felInmatning==false; i++)
            {

                if (((int)decimaltal[i] - 48) >= 0 && ((int)decimaltal[i] - 48) <= 9)
                {
                    tal[i] = ((int)decimaltal[i]-48);
                    summa += ((int)decimaltal[i]-48);
                }
                else if (decimaltal[i]!=','&& decimaltal[i] != '.' || ((int)decimaltal[i] - 48) >= 9)
                {
                    felInmatning=true;
                }

            }

            if (felInmatning==false)
            {
                Console.WriteLine(summa);
            }
            else
            {
                Console.WriteLine("Fel inmatning");
            }



            Console.ReadKey();
        }
    }
}
