﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A_uppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken talbas mellan 2 och 9 vill du skriva talet i?");
            double talbas = double.Parse(Console.ReadLine());
            Console.WriteLine("Vilket tal?");
            string tal = Console.ReadLine();
            int siffra = int.Parse(tal);
            double output = 0;
            bool tillåtet = false;

            for (int j = 0; j < tal.Length; j++)
            {
                for (int i = 0; i < tal.Length && tillåtet==false; i++)
                {
                    if ((tal[j]-48) == (talbas - 1 - i))
                    {
                        tillåtet = true;
                        Console.WriteLine((tal[j] - 48));
                        break;
                    }
                    else
                    {
                        tillåtet = false;
                    }
                }
                
            }

            if(tillåtet == true)
            {
                Console.WriteLine("Fel inmatning");
            }

            for (int i = 0; i < tal.Length && tillåtet==false; i++)
            {
                output += (tal[i] - 48) * Math.Pow(talbas, ((talbas - 1) - i));
            }

            

            Console.WriteLine("Output: " + output);

            Console.ReadKey();
        }
    }
}
