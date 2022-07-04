using System;

namespace MyfirstProject1.FirstTest
{
    class automorphic
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int square = n * n;
            bool condition = true;
            while (n > 0)
            {
                if (n % 10! == square % 10)
                {
                    condition = false;
                    break;
                }
                n = n / 10;
                square = square / 10;
            }
            if (condition == true)
            {
                Console.WriteLine("automporphic");
            }
        }
    }
}
