using System;

namespace MyfirstProject1.Basic
{
    class arithmatic
    {
        static void Main(String[] args)
        {
            int num1 = 30;
            int num2 = 15;
            double add, sub, mul, div;

            add = num1 + num2;
            Console.WriteLine("Addition  =" + add);
            sub = num1 - num2;
            Console.WriteLine("Substraction  =" + sub);
            mul = num1 * num2;
            Console.WriteLine("Multiply  =" + mul);
            div = (num1 / num2);
            Console.WriteLine("Division  =" + div);


        }
    }
}
