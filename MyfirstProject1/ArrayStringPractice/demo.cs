using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyfirstProject2.ArrayStringPractice
{
    interface Icustomer1
    {
        void print1();
    }
    interface Icustomer2
    {
        void print2();
    }
    class customer : Icustomer1
    {
        public void print1()
        {
            Console.WriteLine("print1");

        }


    }
    class customer2 : customer, Icustomer1, Icustomer2
    {

#pragma warning disable CS0108 // 'customer2.print1()' hides inherited member 'customer.print1()'. Use the new keyword if hiding was intended.
        public void print1()
#pragma warning restore CS0108 // 'customer2.print1()' hides inherited member 'customer.print1()'. Use the new keyword if hiding was intended.
        {
            //base.print1();

            Console.WriteLine(" child print1");
        }

        public void print2()
        {
            Console.WriteLine("print2");
        }
    }
    class demo

    {
        static void Main(string[] args)
        {
            //calling child methods from parent refernce type

            customer d = new customer2();
            ((customer2)d).print2();

            d.print1();

        }

    }



    class emplyee
    {
        static void Main(string[] args)
        {


            long[] sal = { 200000, 300000, 250000, 500000 };
            int[] id = { 2, 4, 2, 0 };
            string[] name = { "tom", "John", "Shaun", "Robert" };
            long TotalSalary = 0;
            long secondlargest = 0;
            int j = 0;
#pragma warning disable CS0168 // The variable 'name1' is declared but never used
            string name1;
#pragma warning restore CS0168 // The variable 'name1' is declared but never used
            Array.Sort(sal);
            Array.Sort(name);
            for (int i = 0; i < sal.Length; i++)
            {
                TotalSalary = TotalSalary + sal[i];
                j = sal.Length - 2;
                secondlargest = sal[j];


            }
            Console.WriteLine(TotalSalary);
            Console.WriteLine(secondlargest);
            for (int i = 0; i < name.Length; i++)
            {


                Console.WriteLine(name[i]);

            }


        }
    }


    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CTC { get; set; }
        public string ManagerId { get; set; }


    }
    class call
    {


        static void Main(string[] args)
        {

            ArrayList list = new ArrayList()
            {
                new Employee{Id=1,Name="Tom",CTC=9000,  ManagerId="2"},
                new Employee{Id=2,Name="John",CTC=5000,  ManagerId="4"},
                new Employee{Id=3,Name="Shun",CTC=8000,  ManagerId="2"},
                new Employee{Id=4,Name="Robert",CTC=13000, ManagerId=null},

            };
            // total salary expense for emps
            int sum = 0;
            foreach (Employee item in list)
            {
                sum += item.CTC;
            }
            Console.WriteLine("Total expense of emps salary" + sum);
            // display manager name based on emp name

            foreach (Employee item in list)
            {
                Console.WriteLine(item.Name + " :" + item.ManagerId);
            }

            //sort emp based on salary asc
            var res = from Employee e in list
                      orderby e.CTC
                      select e;

            foreach (Employee item in res)
            {
                Console.WriteLine($" {item.CTC}");
            }
            // sort name desecding order
            var result = from Employee e in list
                         orderby e.Name descending
                         select e;

            foreach (Employee item in result)
            {
                Console.WriteLine($"{item.Name} ");
            }
            // 2nd heighest salary
            var r = from Employee e in list
                    orderby e.CTC descending
                    select e;

            var filter = r.Take(2);
            foreach (Employee item in filter)
            {
                Console.WriteLine(item.Name);
            }
        }
    }





    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class employee
    {
        static void Main(string[] args)
        {


            List<Company> list = new List<Company>()
            {
                new Company{Id=1,Name="jo"},
                new Company{Id = 2,Name="jo1"},

            };

            foreach (Company c in list)
            {
                Console.WriteLine(c.Name + " :" + c.Id);

            }
            Console.WriteLine("//////////////////////////");
            ///desending order
            var res = from Company d in list
                      orderby d.Id descending
                      select d;
            foreach (Company c in res)
            {
                Console.WriteLine(c.Name + " :" + c.Id);

            }

        }
    }

    class pali
    {
        static void Main(string[] args)
        {
            int n = 121;
            int copy = n;
            int last = 0;
            int sum = 0;
            while (n > 0)
            {
                last = n % 10;
                sum = last + sum * 10;

                n = n / 10;

            }
            Console.WriteLine(sum);
            if (sum == copy)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

        }

    }


    //find minimum and max in array
    class minmax
    {
        static void Main(string[] args)
        {
            int[] arr = { 1158, 258, 184, 634 };
            Array.Sort(arr);
            int max = 0;
#pragma warning disable CS0219 // The variable 'min' is assigned but its value is never used
            int min = 0;
#pragma warning restore CS0219 // The variable 'min' is assigned but its value is never used
            int j = arr.Length - 1;

            max = arr[j];

            Console.WriteLine(max);
            Console.WriteLine(arr[0]);

        }
    }

    //reverse of array
    class rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 8, 3, 2, 1 };
            int[] arr1 = { 0, 0, 0, 0, 0, 0 };
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = arr[i];

                for (int j = k; j < arr.Length; j++)
                {
                    arr1[j] = temp;
                    // Console.WriteLine(temp);
                    if (j == k)
                        break;
                }
                k++;
            }
            foreach (int c in arr1)
            {
                Console.Write(c);
            }



        }
    }
    ///find the kth largest and smallest in array
    ///
    class largsmal
    {
        static void Main(string[] args)
        {
            int largest = 0;
            int smallest = 0;
            int[] arrr = { 5, 7, 6, 9, 1, 2, 3 };
            Console.WriteLine("enter the kth value");
            int n = int.Parse(Console.ReadLine());
            Array.Sort(arrr);

            largest = arrr.Length - n;
            Console.WriteLine(arrr[largest]);
            smallest = n - 1;
            Console.WriteLine(arrr[smallest]);

        }
    }
    ///freq of given number in array
    ///
    class freq
    {
        static void Main(string[] args)
        {
            int count = 0;
            char[] c = { 'g', 'y', 'g', 'f', 'y', 'u', 'y' };
            Console.WriteLine("find freq of");
            char ch = char.Parse(Console.ReadLine());
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ch)
                    count++;
            }
            Console.WriteLine(count);

        }
    }


    //cycalic of array
    class cyc
    {
        static void Main(string[] args)
        {
            char[] c = { 'i', 'a', 'm', 'j', 'y', 'o', 't', 'i' };
#pragma warning disable CS0219 // The variable 'K' is assigned but its value is never used
            int K = 0;
#pragma warning restore CS0219 // The variable 'K' is assigned but its value is never used
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = i; j < c.Length; j++)
                {
                    Console.Write(c[j]);
                }
                Console.WriteLine("");
            }
        }
    }
    ///alertaive -ve and +ve integrs
    ///
    class alternative
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 8, -8, 5, -4, -3, 6, -1 };
            int[] arr1 = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Array.Sort(arr);
            int c = 0;
            int c1 = 1;
            int temp = 0;
            int temp1 = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr1[0] = arr[0];
                    c = c + 2;
                    temp = arr[i];
#pragma warning disable CS0162 // Unreachable code detected
                    for (int j = c; j < arr.Length; j++)
#pragma warning restore CS0162 // Unreachable code detected
                    {
                        arr1[j] = arr[i];

                        break;
                    }
                }

                else
                {

                    temp1 = arr[i];
#pragma warning disable CS0162 // Unreachable code detected
                    for (int j = c1; j < arr.Length; j++)
#pragma warning restore CS0162 // Unreachable code detected
                    {
                        arr1[j] = arr[i];

                        break;
                    }
                    c1 = c1 + 2;
                }

            }
            foreach (int e in arr1)
            {
                Console.WriteLine(e);
            }

        }
    }
    //subarray of sum is 0

    class subarr
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, -3, 1, 8, -1, 1 };
            int sum = 0;
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {

                    sum = sum + arr[j];
                    if (sum == 0)
                    {
                        for (int k = j; k >= i; k--)
                        {
                            Console.Write(arr[k]);
                        }
                        c++;
                    }

                }
                sum = 0;
            }
            Console.WriteLine(c);
        }
    }


    //subarray count of 0,1


    class countsub
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 0, 1, 0 };
            int zero = 0;
            int ones = 0;
            int count = 0;
            int max = 0;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i; j < n.Length; j++)
                {
                    if (n[j] == 0)
                    {
                        zero++;
                    }
                    else
                    {
                        ones++;
                    }
                    if (zero == ones)
                    {
                        count++;

                    }
                    max = max > count ? max : max = count;
                }



                count = 0;
            }
            Console.WriteLine(max);
        }
    }

    //reverse given string

    class revstring
    {
        static void Main(string[] args)
        {
            string s = "java";
            char[] ch = s.ToCharArray();
            char[] ch1 = { 'd', 'd', 'd', 'd' };
            int length = ch.Length;
            int c = 0;
            for (int i = length - 1; i >= 0; i--)
            {

#pragma warning disable CS0162 // Unreachable code detected
                for (int j = c; j <= length - 1; j++)
#pragma warning restore CS0162 // Unreachable code detected
                {
                    ch1[j] = ch[i];

                    break;
                }
                c++;
            }

            string s1 = new string(ch1);
            Console.WriteLine(s1);


        }
    }


    //escape single char t
    class esc
    {
        static void Main(string[] args)
        {

            string s = "jyo'\t\'i";
            Console.WriteLine(s);


            string s3 = "jyoti".Replace('o', 'i');
            Console.WriteLine(s3);

            string s5 = "   jyoti".Trim();///remove whitespaces
            Console.WriteLine(s5);

            string s6 = "java".Remove(3);
            Console.WriteLine(s6);//remove character from string




        }
    }



}
