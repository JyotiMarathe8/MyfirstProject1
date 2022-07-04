using System;

namespace MyfirstProject1.ladder.tarnery
{
    class greatestnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            int max;
            //int temp = i1 > i2 ? (i1 > i3 ? i1 : i3) : (i2 > i3 ? i2 : i3);
            if (i1 > i2 && i1 > i3)
            {
                max = i1;
            }
            else if (i2 > i3)
            {
                max = i2;
            }
            else
            {
                max = i3;
            }

            Console.WriteLine("greatest number is " + max);
        }
    }
}
