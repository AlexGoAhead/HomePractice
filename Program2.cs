using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter a number in range 1 - 10");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection > 5 && selection < 10)
            { Console.WriteLine($"The number {selection} bigger than 5 and smaller than 10!"); }
            else
            { Console.WriteLine("Unknown number."); }
            Console.ReadKey();
        }
    }
}