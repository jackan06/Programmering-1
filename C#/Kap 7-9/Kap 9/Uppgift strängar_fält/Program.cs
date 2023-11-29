using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_strängar_fält
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool avsluta = false;
            while (avsluta == false)
            {
                Console.WriteLine("Meny.\n1.Skriv ut strängar.\n2.Beräkning.\n3.Byt ut.\n4.Antal a och n.\n5.Avsluta\n");
                int val = int.Parse(Console.ReadLine());
                Console.Write("\n");
                switch (val)
                {
                    case 1:
                        string[] sträng = new string[10];
                        Console.WriteLine("Skriv tio strängar:");
                        for (int i = 0; i < sträng.Length; i++)
                        {

                            sträng[i] = Console.ReadLine();
                        }
                        Console.Write("\n");

                        //Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Utskrift:");

                        for (int j = 0; j < sträng.Length; j++)
                        {
                            if (sträng[j].Length >= 6)
                            {
                                Console.WriteLine(sträng[j]);
                            }
                        }
                        Console.Write("\n");
                        break;

                    case 2:
                        Console.WriteLine("Skriv text:");
                        string text = Console.ReadLine();
                        int antalMellanslag = 0;
                        int antalA = 0;

                        //Med split för att beräkna antal mellanslag
                        //string[] delar = text.Split(' ');
                        //Console.WriteLine("Antal mellanslag är " + (delar.Length - 1));

                        for (int i= 0; i < text.Length; i++)
                        {
                            if (text[i] == 'a')
                            {
                                antalA++;
                            }

                            if (text[i]==' ')
                            {
                                antalMellanslag++;
                            }
                        }
                        Console.WriteLine("Antal mellanslag är "+antalMellanslag+" och antal a i texten är "+antalA+"\n");
                        break;

                    case 3:
                        Console.WriteLine("Skriv text:");
                        text = Console.ReadLine();
                        text = text.Replace(' ', '*');
                        text = text.Replace('a', '_');
                        Console.WriteLine("Nya texten blir:" + text + "\n");
                        break;

                    case 4:
                        Console.WriteLine("Skriv 10 tecken:");
                        char[] tecken = new char[10];
                        int antalAB = 0;

                        for (int i = 0; i < tecken.Length; i++)
                        {
                            tecken[i]= char.Parse(Console.ReadLine());
                            if (tecken[i] == 'a' || tecken[i] == 'A' || tecken[i] == 'b' || tecken[i] == 'B') 
                            {
                                antalAB++;
                            }

                        }

                        Console.WriteLine("De skrivna tecken är:");
                        //for (int i = 0; i < tecken.Length; i++)
                        //{
                        //    Console.Write( tecken[i] +"\t");
                        //}

                        foreach(char ch in tecken)
                        {
                            Console.Write(ch + "\t");
                        }

                            Console.WriteLine("\nAntal a och b i fältet är " + antalAB+"\n");
                        break;

                    case 5:
                        avsluta = true;
                        break;

                    default:
                        Console.WriteLine("Du har skrivit fel");
                        break;




                        Console.ReadKey();
                }//Avsluta switch
            }//Avsluta while


        }
    }
}
