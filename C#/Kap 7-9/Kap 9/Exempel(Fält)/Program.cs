using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_Fält_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Slumpar 
            int[] slumpadeTal = new int[100];
            Random random = new Random();
            //slumpadeTal[0]=random.Next(1, 7);
            //slumpadeTal[1] = random.Next(1, 7);
            //slumpadeTal[2] = random.Next(1, 7);
            //Console.WriteLine(slumpadeTal[0]);

            for (int i = 0; i < slumpadeTal.Length; i++)
            {
                slumpadeTal[i] = random.Next(1, 7);
                Console.Write(slumpadeTal[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
