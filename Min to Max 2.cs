using System;

namespace MIn_to_Max2
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Console.Write("How many number you want? : ");
                int x = int.Parse(Console.ReadLine());

                int[] Number1 = new int[x];

                for (int i = 0; i < x; i++)
                {
                    Console.Write("Number : ");
                    Number1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Mim to Max sort : ");
                for (int i = 0; i < x; i++)
                {

                    Array.Sort(Number1);
                    Console.Write("{0}  ", Number1[i]);
                }
                Console.WriteLine("");

                Console.WriteLine("Ez sort : ");
                for (int i = 0; i < x; i++)
                {
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Console.Write("{0}  ", Number1[i]);
                }


                Console.WriteLine("");

                Console.WriteLine("2EZ sort : ");
                for (int i = 0; i < x; i++)
                {
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Console.Write("{0}  ", Number1[i]);
                }
                Console.WriteLine("");

                Console.WriteLine("2EZ4ME sort : ");
                for (int i = 0; i < x; i++)
                {
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Array.Reverse(Number1);
                    Array.Sort(Number1);
                    Console.Write("{0}  ", Number1[i]);

                }

                Console.ReadLine();
            }
        }
    }

