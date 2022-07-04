using System;

namespace MyfirstProject1
{
    class secondTest
    {
        int length, breadth, area, perimeter;
        public void input()
        {
            Console.WriteLine("Enter length and breadth");
            length = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());

        }
        public int area1()
        {
            area = length * breadth;
            return area;

        }
        public int perimeter1()
        {
            perimeter = 2 * (length + breadth);
            return perimeter;

        }
        public void display()
        {
            Console.WriteLine("Area of rectangle :" + area);
            Console.WriteLine("Perimeter of rectangle :" + perimeter);
        }
        static void Main(string[] args)
        {
            secondTest s1 = new secondTest();
            s1.input();
            s1.area1();
            s1.perimeter1();
            s1.display();

        }
    }




    class time
    {
        int hour, min, sec;
        public void set_time()
        {
            Console.WriteLine("Enter the time in hour, min, sec");
            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
        }
        public void set_display()
        {
            Console.WriteLine(hour + "hr:" + min + "min:" + sec + "sec");
        }
        static void Main(string[] args)
        {
            time t1 = new time();
            t1.set_time();
            t1.set_display();


        }

    }



    class twinprime
    {
#pragma warning disable CS0414 // The field 'twinprime.c1' is assigned but its value is never used
        int n1, n2, c1 = 0;
#pragma warning restore CS0414 // The field 'twinprime.c1' is assigned but its value is never used

        public void input()
        {
            Console.WriteLine("Enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
        }
        public void prime()

        {
            int c = 0;

            for (int j = 1; j <= n1; j++)
            {
                if (n1 % j == 0)
                {
                    c++;
                }

            }


            int c1 = 0;

            for (int i = 1; i <= n1; i++)
            {
                if (n2 % i == 0)
                {
                    c1++;
                }

            }
            if (c == 2 && c1 == 2)
            {
                if (n1 - n2 == 2)
                {
                    Console.WriteLine("twin Prime");
                }

                else
                {
                    Console.WriteLine("Not twin");
                }
            }

        }


        static void Main(string[] args)
        {
            twinprime t1 = new twinprime();

            t1.input();
            t1.prime();

        }
    }
    /*12345
     *1234
     *123
     *12
     *1
     *12
     *123
     *1234
     *12345 */
    class s2
    {
        static void Main(string[] args)
        {
            for (int r = 6; r > 1; r--)
            {
                for (int c = 1; c <= r - 1; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


            for (int r1 = 2; r1 <= 5; r1++)
            {
                for (int c1 = 1; c1 <= r1; c1++)
                {
                    Console.Write(c1);
                }
                Console.WriteLine();
            }
        }
    }



    /*
     * 1
     *222
     33333
   44444444  */




    class s3
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= line; r++)
            {
                for (int sp = 1; sp <= line - r; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c < r * 2; c++)
                {

                    Console.Write(r);

                }
                Console.WriteLine();

            }

        }

    }







    class s4
    {
        static void Main(string[] args)
        {
            for (int r = 4; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }


    class amicable
    {
        static void Main(string[] args)
        {
            int count = 0, count1 = 0;
            Console.WriteLine("Enter 2 numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int copy1 = n1, copy2 = n2;
            for (int i = 1; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    count = count + i;

                }
            }
            for (int i = 1; i < n2; i++)
            {
                if (n2 % i == 0)
                {
                    count1 = count1 + i;
                }
            }

            if (count == copy2 && count1 == copy1)
            {
                Console.WriteLine("Amicable");
            }
        }
    }



    class practice
    {
        static void Main(string[] args)
        {
            for (int c = 5; c >= 1; c--)
            {
                for (int r = c; r >= 1; r--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



    }


}
