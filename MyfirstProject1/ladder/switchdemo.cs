using System;

namespace MyfirstProject1.ladder
{
    class switchdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator number");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine("Addition of numbers is " + (first + second));
                    break;
                case '-':
                    Console.WriteLine("Substraction of numbers is " + (first - second));
                    break;
                case '*':
                    Console.WriteLine("Multiply of numbers is " + (first * second));
                    break;
                case '/':
                    Console.WriteLine("Division of numbers is " + (first / second));
                    break;
                default:
                    Console.WriteLine("Invalid char");
                    break;

            }



            /* Console.WriteLine("Enter the number to calculate");
             int i = int.Parse(Console.ReadLine());

             switch (i)
             {
                 case '1':
                     Console.WriteLine("Addition of numbers is " + (first + second));
                     break;
                 case '2':
                     Console.WriteLine("Substraction of numbers is " + (first - second));
                     break;
                 case '3':
                     Console.WriteLine("Multiply of numbers is " + (first * second));
                     break;
                 case '4':
                     Console.WriteLine("Division of numbers is " + (first / second));
                     break;
                 default:
                     Console.WriteLine("Invalid char");
                     break;

             }*/





        }
    }
}
