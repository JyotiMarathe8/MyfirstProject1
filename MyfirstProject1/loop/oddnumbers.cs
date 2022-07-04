using System;

namespace MyfirstProject1.loop
{
    class oddnumbers
    {
        static void Main(string[] args)
        {
            for (int i = 299; i >= 200; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }




    class multipleof
    {
        static void Main(String[] args)
        {
            for (int i = 4; i <= 40; i = i + 4)
            {
                Console.WriteLine(i);
            }
        }
    }




    class squareof
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                // int j;
                Console.WriteLine(i * i);
            }
        }
    }

    class mutliply
    {
        static void Main(string[] args)
        {
            int sum = 1;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum * i;
                Console.WriteLine(sum);
            }
        }
    }


    class fact
    {
        static void Main(string[] args)
        {
            int fac = 1;

            int i = int.Parse(Console.ReadLine());
            for (int j = 1; j <= i; j++)
            {
                fac = fac * j;
                // Console.WriteLine(fac);
            }
            Console.WriteLine(fac);

        }
    }


    class prime1

    {
        static void Main(string[] args)
        {

            int c = 0;
            for (int i = 400; i >= 300; i--)
            {
                c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c = c + 1;
                    }

                }

                if (c == 2)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }





    class gcd1
    {
        static void Main(string[] args)
        {


            int gcd = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    gcd = i;
                }
                Console.WriteLine("gcd" + gcd);

            }
        }
    }



    class prime
    {
        static void Main(string[] args)
        {



            int c = 0;

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c = c + 1;


                    }
                    Console.WriteLine(c);
                }
                if (c == 2)
                {
                    Console.WriteLine("prime " + i);
                }
            }




        }
    }



}



