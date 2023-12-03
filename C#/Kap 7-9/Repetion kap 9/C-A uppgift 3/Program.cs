using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A_uppgift_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nu ska vi spela ett spel! Du skriver tiokompisen till talet, om du får rätt får du ett poäng annar ett minuspoäng. Spelet avslutas när du har 20, -10 poäng eller om du skriver BORING");
            Random rnd = new Random();
            int antalPoäng = 0;
            int antalRätt = 0;
            int antalFel = 0;
            bool avsluta = false;

            while (avsluta == false)
            {
                int random = rnd.Next(0, 11);
                Console.WriteLine("Skriv tio kompisen till " + random);
                string svar = Console.ReadLine();
                if (svar == "BORING")
                {
                    avsluta = true;
                }
                else if (int.Parse(svar) == (10 - random))
                {
                    antalPoäng++;
                    antalRätt++;
                }

                else
                {
                    antalPoäng--;
                    antalFel++;
                }

                if (antalPoäng == 20)
                {
                    avsluta = true;
                    Console.WriteLine("Grattis, du har klarat det");
                }
                else if (antalPoäng == -10)
                {
                    avsluta = true;
                    Console.WriteLine("Jobba med addition!");
                }

            }


            Console.ReadKey();
        }
    }
}
