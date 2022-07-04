using System;

namespace MyfirstProject1.Basic
{
    class Demo
    {
        static void Main()
        {

            Console.WriteLine("Enter the first car price");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second car price");
            int j = int.Parse(Console.ReadLine());
            if (i < j)
            {
                Console.WriteLine("First");
            }
            else if (j == i)
            {
                Console.WriteLine("Second");
            }
            else
            {
                Console.WriteLine("Any");
            }



        }
    }
}
