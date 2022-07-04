using System;

namespace MyfirstProject1.Basic
{
    class swap
    {
        static void Main(string[] args)

        {
            int num1 = 40;
            int num2 = 60;
            int temp;
            temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine("swap of number =" + num1 + "    " + num2);
            //without temp
            int num3 = 40;
            int num4 = 60;
            num3 = num4 + num3;
            num4 = num3 - num4;
            num3 = num3 - num4;
            Console.WriteLine($"swap of number   { num3} ,{num4}");


        }
    }
}
