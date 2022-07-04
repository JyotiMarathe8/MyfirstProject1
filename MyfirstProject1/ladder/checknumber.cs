using System;

namespace MyfirstProject1.ladder
{
    class checknumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the character ");

            int ch = int.Parse(Console.ReadLine());


            if (ch > 0)
            {
                Console.WriteLine("positive ");

            }
            else if (ch < 0)
            {
                Console.WriteLine("negative ");

            }
            else
            {
                Console.WriteLine("zero ");
            }



        }
    }
}
