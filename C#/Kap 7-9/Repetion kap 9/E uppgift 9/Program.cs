using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_uppgift_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Hur många tal vill du slumpa?");
            int antal = int.Parse(Console.ReadLine());
            int[] slumptal = new int[antal];
            int antalJämna = 0;

            for (int i = 0; i < slumptal.Length; i++)
            {
                slumptal[i] = random.Next(2,51);

                if(slumptal[i]%2 == 0)
                {
                    antalJämna++;
                }
            }

            Console.WriteLine("\nDe slumpade talen är: ");
            foreach (int i in slumptal)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Antal jämna heltal är: " + antalJämna);


            Console.ReadKey();
        }
    }
}
