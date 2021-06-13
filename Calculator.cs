using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        public static int m;
        static void Main(string[] args)
        {
            // โค้ดนี้จะรันค่าได้จริงแต่ว่ามีปัญหาตรงที่ถ้าผู้ใช้หรอกค่ามาที่ไม่ใช้ End จะระเบิด
            string[] number = new string[1000];

            string command = "end";

            int i = 0;
            while (command != "End")
            {

                Console.Write("Input number : ");
                number[i] = Console.ReadLine();
                i = i + 1;

                if (number.Contains("End"))
                {
                    break;
                }

            }

            int z = Array.FindIndex(number, w => w == "End");
            double[] number1 = new double[z];

            for (int x = 0; x < z; x++)
            {
                number1[x] = Double.Parse(number[x]);
            }

            string command1 = "1";

            while (command1 != "FindMax" && command1 != "FindMin" && command1 != "FindMean")
            {
                Console.Write("What you want to do next? : ");
                command1 = Console.ReadLine();

                if (command1 != "FindMax" && command1 != "FindMin" && command1 != "FindMean")
                {
                    Console.WriteLine("Invaild Input ");

                    Console.WriteLine("");
                    
                }

                if (command1 == "FindMax")
                {
                    double maxValue =number1.Max();
                    Console.WriteLine(maxValue);
                }
                if (command1 == "FindMin")
                {
                    double minValue = number1.Min();
                    Console.WriteLine(minValue);
                }
                if (command1 == "FindMean")
                {
                    double sum = 0;
                    for (int q = 0; q < number1.Length; q++)
                    {
                        
                        sum += number1[q];
                    }

                    double meanValue = sum / number1.Length;
                    
                    Console.WriteLine(meanValue);
                }
            }
            
            Console.ReadLine();
            
        }
    }
}
