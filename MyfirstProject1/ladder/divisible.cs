using System;

namespace MyfirstProject1.ladder
{
    class divisile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the number");
            int i = int.Parse(Console.ReadLine());
            if (i % 3 == 0 && i % 9 == 0)
            {
                Console.WriteLine("number is divisible by 3 &9");
            }
            else
            {
                Console.WriteLine("number is not divisible by 3&9");

            }

        }
    }
}
