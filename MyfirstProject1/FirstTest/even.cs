using System;

namespace MyfirstProject1.FirstTest
{
    class even
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers from  121 to 129  :");
            for (int i = 122; i < 229; i = i + 2)
            {
                Console.WriteLine(i);

            }
        }
    }


    class odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd froms form 521 to 229");
            for (int i = 521; i > 229; i = i - 2)
            {
                Console.WriteLine(i);
            }

        }
    }



    /*class gcdlcm
      {
          static void Main(string[] args)
          {
              int gcd = 0, lcm = 0;
              Console.WriteLine("Enter two numbers");
              int a = int.Parse(Console.ReadLine());
              int b = int.Parse(Console.ReadLine());

              for (int i = 1; i < a; i = i++)
              { 
  ,            
                  if (a % i == 0 && b % i == 0)
                  {
                      gcd = i;
                  }
              }
              Console.WriteLine("gcd of numbers " + gcd);
              lcm = a * b / gcd;
              Console.WriteLine("LCM of numbers  " + lcm);
          }
      }*/












    class sumeven1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n; i = i + 2)
            {
                sum = sum + i;

            }
            Console.WriteLine("sum of even numbers " + sum);
        }
    }



    class sumodd
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i = i + 2)
            {
                sum = sum + 1;

            }
            Console.WriteLine("sum of odd numbers " + sum);
        }
    }



    class productdigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int i = 1, prod = 1, last = 0;
            while (i < n)
            {
                last = n % 10;
                prod = prod * last;
                n = n / 10;

            }
            Console.WriteLine("Product of digits " + prod);

        }
    }


    class prime40to300
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 400; i > 300; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count = count + 1;

                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }
    }


    class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + n * i);
            }
        }

    }


    class square1to20
    {
        static void Main(string[] args)
        {
            int square = 0;
            for (int i = 1; i <= 20; i++)
            {
                square = (int)Math.Pow(i, 2);
                Console.WriteLine("square of 1 to 20  " + square);
            }
        }
    }


    class krishna
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int n = int.Parse(Console.ReadLine());
            int last = 0, fact = 0, sum = 0, copy = 0;
            while (n > 0)
            {
                last = n % 10;
                for (int i = 1; i < last; i++)
                {
                    fact = last * i;

                }
                sum = sum + fact;
                n = n / 10;


            }
            if (sum == copy)
            {
                Console.WriteLine("Krishnamurthy");
            }
            else
            {
                Console.WriteLine("not krishnamurthy");
            }
        }
    }



    class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int n = int.Parse(Console.ReadLine());
            int last = 0, rev = 0, copy = n;
            while (n > 0)
            {
                last = n % 10;
                rev = rev * 10 + last;
                n = n / 10;

            }
            if (copy == rev)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }


    class palindrome100to500
    {
        static void Main(string[] args)
        {
            int last = 0, rev = 0;
            for (int n = 2; n <= 2; n++)
            {
                int copy = n;
                while (n > 0)
                {
                    Console.WriteLine("h");
                    last = n % 10;
                    rev = rev * 10 + last;
                    n = n / 10;
                    Console.WriteLine(rev);

                }


            }
        }
    }




















}



