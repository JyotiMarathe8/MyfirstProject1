using System;

namespace MyfirstProject1.FirstTest
{
    class freq
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mobile number");
            long mb = long.Parse(Console.ReadLine());
            long temp = mb;
            for (int i = 0; i <= 9; i++)
            {
                int c = 0;
                while (mb > 0)
                {
                    long last = mb % 10;
                    if (last == i)
                        c++;
                    mb = mb / 10;
                }
                mb = temp;
                if (c > 0)
                {
                    Console.WriteLine("Freq of num " + i + " -" + c);
                }
            }
        }
    }
}
