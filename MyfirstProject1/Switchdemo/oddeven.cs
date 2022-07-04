using System;

namespace MyfirstProject1.Switchdemo
{
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int i = int.Parse(Console.ReadLine());
            int result = i % 2;
            switch (result)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Odd");
                    break;

            }
        }
    }
}
