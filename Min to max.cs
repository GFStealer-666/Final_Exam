using System;

namespace Min_to_Max
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
            for (int i =0; i < x; i++)
            {
                
                Array.Sort(Number1);
                Console.Write("{0} , ",Number1[i]);                
            }
            Console.WriteLine("");

            Console.WriteLine("Max to Min sort : ");
            for (int i = 0; i < x; i++)
            {               
                Array.Sort(Number1);
                Array.Reverse(Number1);
                Console.Write("{0} , ", Number1[i]);
            }

            int[] Number2 = new int[x];

            for(int i =0; i <x; i++)
            {
               Number2[i] = Math.Abs(Number1[i]);

            }
            Console.WriteLine("");

            Console.WriteLine("Abs Min to Max sort : ");
            for (int i = 0; i < x; i++)
            {
                Array.Sort(Number2);
                Console.Write("{0} , ", Number2[i]);

            }
            Console.WriteLine("");

            Console.WriteLine("Abs Max to Min sort : ");
            for (int i = 0; i < x; i++)
            {
                Array.Sort(Number2);
                Array.Reverse(Number2);
                Console.Write("{0} , ", Number2[i]);

            }

            Console.ReadLine();
        }
    }
}
