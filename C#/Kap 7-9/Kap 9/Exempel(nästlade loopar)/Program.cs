using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_nästlade_loopar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for(int j=1; j <= 5; j++)
                {
                    Console.Write(i*j+"\t");
                }
                Console.WriteLine();
                //Console.Write("\n");
            }



            Console.ReadKey();
        }
    }
}
