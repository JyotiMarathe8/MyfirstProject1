using System;

namespace MyfirstProject1.Switchdemo
{
    class areas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the char for area ");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'c':
                    Console.WriteLine("Area of circle " + 3.44 * length * length);
                    break;
                case 's':
                    Console.WriteLine("Area of square " + length * length);
                    break;
                case 'r':
                    Console.WriteLine("Area of rectangle " + length * width);
                    break;
                case 't':
                    Console.WriteLine("Area of Triangle " + 0.5 * length * width);
                    break;
                default:
                    Console.WriteLine("Invalid char");
                    break;


            }


        }
    }
}
