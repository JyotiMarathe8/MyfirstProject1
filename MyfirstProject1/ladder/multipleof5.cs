using System;

namespace MyfirstProject1.ladder
{
    class multipleof5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int i = int.Parse(Console.ReadLine());
            if (i % 5 == 0)
            {
                Console.WriteLine("multiple of 5");
            }
            else
            {
                Console.WriteLine("not multiple of 5");

            }

            /* string result = (i % 5 == 0) ? "multiple of 5" : "not multiple of 5";
             Console.WriteLine(result);*/


        }



    }
}
