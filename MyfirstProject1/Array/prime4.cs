using System;

namespace MyfirstProject1.Array3
{
    class prime4
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 3, 8, 10, 12, 18 };
            int length = arr.Length;
            int c = 0;
            int x = 0;
            for (int i = 0; i <= length - 1; i++)
            {
                x = arr[i];
                for (int j = 1; j <= x; j++)
                {

                    if (x % j == 0)
                    {

                        c++;
                    }
                }
                    if (c == 2)
                    {
                            Console.WriteLine(x);
                    }
                c = 0;
            }


        }
    }



    //even number in array
    class even2
    {
        static void Main(string[] args)
        {
            even2 e = new even2();
            e.even();
        }
        public void even()
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = arr[i]; i < size - 1; i++, j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.WriteLine("even number :" + j);
                    }

                }
            }
        }


    }

    class average
    {
        static void Main(string[] args)
        {
            int[] marks = { 65, 61, 59, 58, 65, 70 };
            int avg = 0, sum = 0;
            for (int i = 0; i <= marks.Length - 1; i++)
            {
                sum = sum + marks[i];

            }
            avg = sum / marks.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }

    class secndlargest
    {

        //second largest in array
        static void Main(string[] args)
        {
            int x = 0;
            int[] a = { 7, 8, 4, 2, 9 };
            Array.Sort(a);
            for (int i = 0; i <= a.Length - 1; i++)
            {
                x = a.Length - 2;

            }
            Console.WriteLine(a[x]);
        }

    }

    class prgm8
    {
        //sum of 2 matrix
        static void Main(string[] args)
        {
            int c, d;
            int sum = 0;
            int[,] arr1 = new int[2, 2]
            {
                {2,5 },{5,4}
            };
            int[,] arr2 = new int[2, 2]
            {
                {1,2 },{5,4}
            };
            for (c = 0; c < 2; c++)
                for (d = 0; d < 2; d++)
                    sum = arr1[c, d] + arr2[c, d];
            for (c = 0; c < 2; c++)
            {
                for (d = 0; d < 2; d++)
                    Console.Write(sum);
                Console.WriteLine();
            }

        }

    }

    class prgm7
    {
        static void Main(string[] args)
        {
            int a2 = 4;
            int a3 = 5;
            int n = 7;
            int cd = a3 - a2;
            for (int i = 1; i < n; i++)
            {
                a3 = a3 + cd;
                Console.WriteLine(a3);
            }
            Console.WriteLine(a3);

        }
    }

    class prgm4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gcd = 0;
            int coprime1 = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && n % j == 0)
                    {
                        gcd = j;
                        coprime1 = i;
                    }
                }

                if (gcd == 1)
                {
                    Console.WriteLine("coprime :" + coprime1);
                }
                gcd = 0;
            }

        }
    }


}