using System;

namespace MyfirstProject1.ladder.tarnery
{
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int i = int.Parse(Console.ReadLine());
            String num = (i % 2 == 0) ? "Even" : "odd";
            Console.WriteLine(num);
        }
    }
}
