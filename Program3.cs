using System;

namespace ConsoleApp3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 5 || selection == 10)
            {
                Console.WriteLine("The number is equal 5 or 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
            Console.ReadKey();
        }
    }
}

//class Program3
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter any number: ");
//        int selection = Convert.ToInt32(Console.ReadLine());
//        switch (selection)
//        {
//            case (5):
//                Console.WriteLine("The number equal 5 or 10!");
//                break;
//            case (10):
//                Console.WriteLine("The number equal 5 or 10!");
//                break;
//            default:
//                Console.WriteLine("Unknown number.");
//                break;
//        }
//        Console.ReadKey();
//    }
//}
