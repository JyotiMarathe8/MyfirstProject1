using System;

namespace MyfirstProject1.loop
{
    class sumof_digits
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;

            }
            Console.WriteLine(sum);
        }
    }





    class even1
    {
        static void Main(string[] args)
        {
            int sum = 0, even = 0, odd = 0, count = 0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int last = n % 10;
                count = count + 1;
                if (last % 2 == 0)
                {
                    even = even + 1;

                }
                else
                {
                    odd = odd + 1;
                }
                sum = sum + last;
                n = n / 10;


            }
            Console.WriteLine(odd + " " + even);
            Console.WriteLine("count" + count);
        }
    }




    class neon
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sqare = 1;
            int last = 0;

            int n = int.Parse(Console.ReadLine());
            sqare = n * n;
            while (sqare > 0)
            {
                last = sqare % 10;

                sum = sum + last;
                sqare = sqare / 10;

            }
            if (last == n)
            {
                Console.WriteLine("Neon number ");

            }
            else
            {
                Console.WriteLine("not neon");
            }

        }
    }





    class palindrome
    {
        static void Main(string[] args)
        {
            int sum = 0, reverse = 0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last;
                reverse = reverse * 10 + last;
                n = n / 10;

            }
            Console.WriteLine(reverse);
        }
    }





    class krishnamurthy
    {
        static void Main(string[] args)
        {
            int sum = 0, fact = 0;
            int n = 456;
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last;

                n = n / 10;



                for (int i = 1; i <= n; i++)
                {
                    fact = fact * n;
                }
                sum = sum + fact;
            }
            if (sum == n)
            {


                Console.WriteLine("Krishnamurthy" + sum);
            }
            else
            {
                Console.WriteLine("not krishnamurthy");
            }
        }


    }





    class armstrong
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0, n = 153;

            int copy = n;
            while (copy > 0)
            {
                count = count + 1;
                copy = copy / 10;
            }
            copy = n;
            while (n > 0)
            {

                int last = n % 10;
                int p = (int)Math.Pow(last, count);
                sum = sum + p;
                n = n / 10;

            }

            if (sum == copy)
            {

                Console.WriteLine("armstng number " + sum);
            }
            else
            {
                Console.WriteLine("NOt armstrng" + sum);
            }




        }
    }
}

