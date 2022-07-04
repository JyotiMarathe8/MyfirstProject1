using System;

namespace MyfirstProject1
{
    /* F */

    class forloop
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (c == 1 || r == 1 || r == 3)

                        Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }



    class I
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (r == 1 || r == 10 || c == 5)
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


    class L
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 10)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }
    }




    class T
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (r == 1 || c == 5)
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





    class P
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {


                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 5 || r == 1 || (c == 10 && r <= 5))
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







    class X
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c <= 6)
                    {
                        if (c == r || r + c == 7)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    else if (c == 7 || c == 8)
                    {
                        Console.Write(" ");
                    }

                    //y
                    else
                    {

                        if (c == 9)
                        {
                            Console.Write("*");
                        }
                    }
                }

                Console.WriteLine();



            }


        }





    }




    class w
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    /*1
     * 22
     * 333
     * 4444
     * 55555*/
    class w1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    /*54321
    5432
    543
    54
    5*/

    class w2
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 5; c >= r; c--)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }


    /* 5
     * 54
     * 543
     * 5432
     * 54321*/

    class w3
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 5; c >= r; c--)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }



    /* 6
     * 67
     * 678
     * 6789
     */
    class w4
    {
        static void Main(string[] args)
        {
            for (int r = 6; r <= 9; r++)
            {
                for (int c = 6; c <= r; c++)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    /*1
     * 21
     * 321
     * 4321
     * 54321*/

    class w5
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c >= 1; c--)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    /*54321
     * 4321
     * 321
     * 21
     * 1*/

    class w6
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = r; c >= 1; c--)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    /* 12345
     * 2345
     * 345
     * 45
     * 5*/



    class w7
    {
        static void Main(string[] args)
        {
            char c1 = 'A';
            for (int r = 1; r <= 6; r++)
            {

                for (int c = 1; c <= 6 - r; c++)
                {


                    Console.Write(c1);
                    c1++;
                }
                c1 = 'A';
                Console.WriteLine();
            }

        }
    }



    /*12345
    * 2345
    * 345
    * 45
    * 5
    * 45
    * 345
    * 2345
    * 12345*/



    class w8
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 9; r++)
            {

                for (int c = r; c <= 5; c++)
                {

                    Console.Write(c);

                }
                Console.WriteLine();

            }


            for (int r1 = 4; r1 >= 1; r1--)
            {
                for (int c = r1; c <= 5; c++)
                {

                    Console.Write(c);
                }
                Console.WriteLine();
            }

        }




    }


    /*A
     * AB
     * ABC
     * ABCD
     * ABCDE
     * ABCDEF
     * ABCDE
     * ABCD
     * ABC
     * AB
     * A*/


    class w9
    {
        static void Main(string[] args)
        {
            for (char r = 'A'; r <= 'F'; r++)
            {

                for (char c = 'A'; c <= r; c++)
                {

                    Console.Write(c);

                }
                Console.WriteLine();

            }


            for (char r1 = 'E'; r1 >= 'A'; r1--)
            {
                for (char c1 = 'A'; c1 <= r1; c1++)
                {

                    Console.Write(c1);
                }
                Console.WriteLine();
            }


        }





    }

    /*1
     * 10
     * 101
     * 1010
     * 10101*/



    class w10
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {

                for (int c = 1; c <= r; c++)
                {

                    Console.Write(c % 2);

                }
                Console.WriteLine();


            }
        }
    }
    /*5
     *45
     *345
     *2345
     *12345*/
    class w66
    {

        static void Main(string[] args)
        {
#pragma warning disable CS0219 // The variable 'c1' is assigned but its value is never used
            int c1 = 5;
#pragma warning restore CS0219 // The variable 'c1' is assigned but its value is never used

            for (int r = 1; r <= 5; r++)
            {


                for (int c = 5; c > 5 - r; c--)
                {
                    Console.Write(c);

                }


                Console.WriteLine();

            }
        }




    }


    /*12345
    * 2345
    * 345
    * 45
    * 5*/



    class w11
    {
        static void Main(string[] args)
        {
            int c1 = 1;
            for (int r = 5; r >= 1; r--)
            {

                for (int c = c1; c <= 5; c++)
                {

                    Console.Write(c);

                }
                c1++;
                Console.WriteLine();


            }
        }
    }


    class w12
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 4; r++)
            {
                for (int space = 4; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(c);

                }
                Console.WriteLine();


            }
        }
    }
    /* 12345
     *  1234 
     *   123
     *    12
     *     1 */

    class w22
    {
        static void Main(string[] args)
        {

            for (int r = 4; r >= 1; r--)
            {
                for (int space = 4; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(c);

                }
                Console.WriteLine();


            }
        }
    }
    /*   *
     *   ***
     *   *****   */

    /*  *
     *  ***
     *  *****  */

    class w13
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 5; r++)
            {

                for (int c = 1; c < r * 2; c++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();

            }

        }
    }






    /*   *
     *  *** 
       *****
      *******   */



    class w14
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

                    Console.Write("*");

                }
                Console.WriteLine();

            }

        }
    }






    class w15
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= line; r++)
            {
                for (int space = line; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(c);

                }

                for (int k = r - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }

                Console.WriteLine();

            }

        }
    }





    /*do while*/

    class do2
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("sum " + sum);
                Console.WriteLine("do u want to perform addition once more yes/no ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

        }
    }


















































}

