using System;

namespace MyfirstProject1.practiceAll
{
    class A
    {
        //print * in Rectangle
        static void Main(string[] args)
        {
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 8; c++)
                {
                    if (c == 1 || c == 8 || r == 1 || r == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }


    class B
    {
        //remove specified char from string
        static void Main(string[] args)
        {
            string str = "java";
            string str2 = "java";




            //equal method

            Console.WriteLine("using Equals :" + str.Equals(str2));
            //remove method

            Console.WriteLine("remove :" + str.Remove(2));
            string str3 = "java";
            string str4 = str3;


            // == operator is used for objects
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("java" == "java" + 0);
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("using equals for object :" + str3.Equals(str4));


            string s1 = new string("ho");
            string s2 = new string("lava123");
            Console.WriteLine("//////////////////////////");
            Console.WriteLine(s1 == s2);
            Console.WriteLine("//////////////////////////");
            int x = 10;
            x = 11;
            //compare 
            Console.WriteLine(x.CompareTo(x));//difference of address

        }

    }
    //implement for loop, while loop,do while loop
    class loop
    {
        //print even number from 1 to 10

        static void Main(string[] args)
        {
            for (int r = 2; r <= 10; r = r + 2)
            {
                Console.WriteLine(r);
            }
            int s = 2;
            while (s <= 10)
            {
                Console.WriteLine(s);
                s = s + 2;
            }
            Console.WriteLine("////////////////////");
            int T = 2;
            do
            {
                Console.WriteLine(T);
                T = T + 2;
            } while (T <= 10);

        }
    }

    //freq of numbers in mobile number
    class fre1
    {
        static void Main(string[] args)
        {
            long mb = 9096172414;
            long copy = mb;
            long last = 0;
            int c = 0;
            for (int i = 0; i <= 9; i++)
            {
                while (mb > 0)
                {
                    last = mb % 10;
                    if (last == i)
                        c++;
                    mb = mb / 10;
                }
                Console.WriteLine($" count of {i} : " + c);
                c = 0;
                mb = copy;
            }

        }
    }

    // freq in string
    class fresting
    {
        static void Main(string[] args)
        {
            string s = "oofoo";
            char[] c = new char[5];
            char[] c1 = new char[5];
            int count = 0;
            c = s.ToCharArray();
            for (int i = c.Length; i >= 0; i--)
            {

                for (int j = count; j < c.Length-1; j++)

                {
                    c1[j] = c[i];
                    break;
                }
                count++;
            }
            string s1 = new string(c1);
            Console.WriteLine(s1);
        }
    }
}
