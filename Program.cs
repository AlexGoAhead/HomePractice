using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"First number {a} bigger than second number {b}");
            }
            else if (a == b)
            {
                Console.WriteLine($"First number {a} equal to second number {b}");
            }
            else
            {
                Console.WriteLine($"First number {a} smaller than second number {b}");
            }
            
            Console.ReadKey();
        }
    }
}
