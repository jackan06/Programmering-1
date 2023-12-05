using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_uppgift_fält_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många gånger ska det köras");
            int antal= int.Parse(Console.ReadLine());
            int[] omvandlat = new int[antal];
            int tal = 5;
            int summa = 0;
           

            for (int i=0; i<antal; i++)
            {
                tal *= 2;
                tal += 4;
                summa += tal;
                omvandlat[i] = tal;
            }

            Console.WriteLine(summa);

            Console.ReadKey();
        }
    }
}
