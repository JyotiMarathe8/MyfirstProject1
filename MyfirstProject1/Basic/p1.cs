using System;

namespace MyfirstProject1.Basic
{
    class printmyname

    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 39; c++)
                {
                    //J
                    if (c <= 6)
                    {

                        if (r == 1 || c == 3 || (r == 6 && c == 1) || (r == 6 && c == 2) || (r == 6 && c == 3))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    //y
                    else if (c == 7)
                    {
                        Console.Write(" ");
                    }
                    else if (c > 7 && c <= 14)
                    {
                        if (r < 3)
                        {

                            if (c + r == 15 || (c == 9 && r == 1) || (c == 10 && r == 2))
                            {
                                Console.Write("*");
                            }

                            else
                            {
                                Console.Write(" ");
                            }

                        }
                        else
                        {
                            if (c == 12)
                            {
                                Console.Write("*");
                            }

                            else
                            {
                                Console.Write(" ");
                            }
                        }


                    }


                    //o
                    else if (c == 15 || c == 16)
                    {
                        Console.Write(" ");
                    }

                    else if (c >= 17 && c <= 22)
                    {
                        if (c == 17 || c == 22 || r == 1 || r == 6)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    //T
                    else if (c == 23 || c == 24)
                    {
                        Console.Write(" ");
                    }
                    else if (c >= 25 && c < 30)
                    {
                        if (r == 1 || c == 27)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    //I

                    else if (c == 31 || c == 32)
                    {
                        Console.Write("   ");
                    }
                    else if (c >= 33 && c <= 39)
                    {
                        if (r == 1 || r == 6 || c == 36)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }


                }

                Console.WriteLine();

            }

        }
    }



}

