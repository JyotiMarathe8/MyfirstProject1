using System;

namespace MyfirstProject1.Array1
{
    class student

    {
        static void Main(string[] args)
        {
            string[] employees = { "jyoti", "pratiksha", "abcd", "neha", "pooja", "smita", "choti", "deepika", "roopa", "xxx", "sarvesh", "niraj", "Shubham", "sandeep", "rani", "meena" };
            for (int i = 0; i < employees.Length; i++)
            {
                if (i < 5)
                    Console.WriteLine("data1-" + employees[i]);

                if (i >= 5 && i < 10)
                    Console.WriteLine("data2-" + employees[i]);

                if (i >= 10 && i < 15)
                    Console.WriteLine("data3-" + employees[i]);
            }
        }
    }
    /// <summary>
    /// to print duplicate count
    /// </summary>
    class prog
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] num = { 100, 101, 98, 101, 102, 102, 99, 101 };
            //  Array.Sort(num);

            for (int i = 0; i < num.Length; i++)
            {

                if (i > 0 && num[i] == num[i - 1])
                {
                    count++;
                    if (count > 1)
                    {
                        Console.WriteLine(" " + count);
                    }
                }

                else
                {
                    count = 1;
                    Console.WriteLine(num[i]);
                    Console.WriteLine(" " + count);
                }

            }


        }
    }

    class prgm2
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] arr = { "Rahul", "Mohit", "Naman", "adity", "Roshani", "Abhay" };
            string data;
            for (int i = 0; i < arr.Length; i++)
            {
                data = arr[i];
                Console.WriteLine(data);
                Console.WriteLine(data.Length);
                count = count + data.Length;

            }
            Console.WriteLine("count of all characters in an array-" + count);
        }
    }

    //not to print non duplicate
    class prgm3
    {
        static void Main(string[] args)
        {

            int[] num = { 100, 100, 103, 105, 105, 106, 107, 108 };

            int[] arr1 = num;
            int length = num.Length;
            int i = 0;

            for ( i = 0; i < num.Length; i++)
            {

                if ( i > 0 && num[i]! == num[i - 1])
                {

                    num[i] = 0;
                    num[i - 1] = 0;
                }


            }

            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] == 0)
                {

                }
                else
                {
                    Console.WriteLine(num[j]);
                }


            }




        }
    }



    //sum of even numbers

    class prgm4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the elemnets to array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];

            }
            Console.WriteLine("sum of elements in Array : " + sum);
        }
    }
    class prgm5
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the elemnets to array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + arr[i];
                }

            }
            Console.WriteLine("sum of elements in Array : " + sum);

        }
    }

    class prgm6
    {
        static void Main(string[] args)
        {
            char[] arr = new char[5];
            Console.WriteLine("Enter the char in array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = char.Parse(Console.ReadLine());

            }
            char min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];

                }
            }
            Console.WriteLine("smallest char in array : " + min);
        }
    }

    //alternate form array
    class prgm7
    {
        static void Main(string[] args)
        {

            char[] arr = new char[5];
            char[] arr1 = new char[5];
            Console.WriteLine("Enter the char in array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = char.Parse(Console.ReadLine());

            }
            Console.Write("Original    Array  :");
            Console.WriteLine(arr);
            Console.Write("Alternate in array :");

            for (int i = 0; i < arr1.Length; i = i + 2)
            {
                arr1[i] = arr[i];
                Console.Write(arr1[i]);

            }
            Console.WriteLine("    ");


        }
    }

    class prgm8
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0219 // The variable 'sum' is assigned but its value is never used
            int sum = 0;
#pragma warning restore CS0219 // The variable 'sum' is assigned but its value is never used
            int[] arr = new int[5];
            int fact = 0;
            Console.WriteLine("Enter the char in array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        fact = fact + 1;
                    }
                }
                if (fact == 2)
                {
                    Console.WriteLine("Prime" + arr[i]);
                }
                else
                {
                    Console.WriteLine("Not Prime" + arr[i]);
                }

                fact = 0;

            }


        }
    }

}
