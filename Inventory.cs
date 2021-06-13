using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inventory capacity : ");
            int x = int.Parse(Console.ReadLine());

            string[] inventory = new string[x];
            string[] type = new string[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Item : ");
                inventory[i] = Console.ReadLine();

                Console.Write("Type : ");
                type[i] = Console.ReadLine();


                Console.WriteLine(" ");
            }          

                while (true)
                {                                                                          
                    Console.Write("Search item? : ");
                   string command = Console.ReadLine();

                string a = command;

                for (int k = 0; k < x; k++)
                {
                    if (type[k] == command)
                    {
                        a ="2";
                    }

                }
                
                if (a == command && a != "Showall")
                {
                    break; 
                }
               

                    if (command == "Showall")
                    {
                        for (int g = 0; g < x; g++)
                        {
                            Console.WriteLine(inventory[g]);

                            Console.WriteLine(type[g]);

                            Console.WriteLine("");

                            
                    }
                    }

                    for (int k = 0; k < x; k++)
                    {
                        if (type[k] == command)
                        {
                            Console.WriteLine(inventory[k]);

                        Console.ReadLine();
                        }
                      
                    }

                    

                }
            
        }

       
    }
}
