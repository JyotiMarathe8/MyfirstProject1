using System;

namespace MyfirstProject1.ladder
{
    class Leapyear
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the year");

            int i = int.Parse(Console.ReadLine());
            if (i % 4 == 0)
            {
                Console.WriteLine("Given year is Leap Year ");

            }
            else
            {
                Console.WriteLine("Given year is not Leap Year");

            }
        }
    }
}
