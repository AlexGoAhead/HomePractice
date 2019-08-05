using System;

namespace ConsoleApp4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sum of deposit: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            if (deposit < 100)
            {
                Console.WriteLine("Your bank deposit interest less than 100 dollars and will be 5%");
                double receive = deposit * 1.05;
                Console.WriteLine($"Your deposit is {deposit}$ and you will receive in a year {receive} dollars.");
            }
            else if (deposit >=100 && deposit <= 200)
            {
                Console.WriteLine("Your bank deposit interest more than 100 dollars and less than 200 dollars will be 7%");
                double receive = deposit * 1.07;
                Console.WriteLine($"Your deposit is {deposit}$ and you will receive in a year {receive} dollars.");
            }
            else if (deposit > 200)
            {
                Console.WriteLine("Your bank deposit interest more than 100 dollars and will be 10%");
                double receive = deposit * 1.1;
                Console.WriteLine($"Your deposit is {deposit}$ and you will receive in a year {receive} dollars.");
            }
            else
            {
                Console.WriteLine("Unkown error.");
            }
            Console.ReadKey();
        }
    }
}
