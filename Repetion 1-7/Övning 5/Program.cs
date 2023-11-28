using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en bokstav:");
            char bokstav = char.Parse(Console.ReadLine());
            
            if (bokstav >='a' && bokstav <= 'z')
            {
                Console.WriteLine("Du skrev en liten bokstav");
            }
            else if (bokstav >='A' && bokstav <= 'Z')
            {
                Console.WriteLine("Du skrev en stor bokstav");
            }
            else
            {
                Console.WriteLine("Du skrev ett annat tecken, det var inte någon bokstav");
            }

         
            Console.ReadKey();
        }
    }
}
