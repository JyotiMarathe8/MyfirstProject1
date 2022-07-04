using System;

namespace MyfirstProject1.Array1.practice
{
    class h1
    {
        public static void puppy()
        {
            int age = 0;
            age = age + 7;
            Console.WriteLine("puppy age is-" + age);
        }
        static void Main(string[] args)
        {
            h1 t = new h1();
            h1.puppy();

        }
    }



    class garbage
    {
        static void Main(string[] args)
        {
            String str = new String("hello");
            String str1 = str;
            str = new string("Hi");
            str1 = new String("hello again");



        }

    }
    class scope
    {
#pragma warning disable CS0414 // The field 'scope.x' is assigned but its value is never used
        int x = 10;
#pragma warning restore CS0414 // The field 'scope.x' is assigned but its value is never used
        static int y = 20;
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(scope.y);
            Console.WriteLine();
        }

    }


    class parent
    {
        void display(int i)
        {

        }
        void display()
        {

        }

    }
    class child : parent
    {
        void display(int i)
        {

        }

    }

    class T1
    {
        public void m2()
        {
            Console.WriteLine("hello world");
        }
        public virtual void m1()
        {
            Console.WriteLine("parent method");
        }

    }
    class T2 : T1
    {
        public T2()
        {
            Console.WriteLine("have a great day");

        }

        public override void m1()
        {

            Console.WriteLine("child method");
        }
    }
    class T3
    {
        static void Main(string[] args)
        {

            T1 t = new T2();

            t.m2();
            t.m1();


        }
    }


    //class largestsubarray
    //{
    //   static int findsubarray(int[] A,int N)
    //    {
    //        int sum = 0;
    //        int maxsize = 0;
    //        int end = 0;
    //        int start = 0;
    //        for (int i = 0; i < N - 1; i++)
    //        {
    //            sum = (A[i] == 0) ? -1 : 1;
    //            sum = sum + 1;
    //            for(int j=i+1;j<N-1;j++)
    //            {
    //                if (A[j] == 0)
    //                    sum = sum + (-1);
    //                else
    //                    sum = sum + 1;

    //            }



    //        return maxsize;

    //    }


    class h2
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            h2 gg = new h2();
            gg.dd(str1, str2);

        }
        public void dd(string str1, string str2)
        {




            string result = null;

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);



            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {

                    if (ch1[i] == ch2[i])
                    {
                        result = "anagram";
                    }
                    else
                    {
                        result = "no";

                    }

                }

            }

            Console.WriteLine(result);




        }


    }







    class p1
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = 200;
            while (++i < --j)
            {
                Console.WriteLine(i);
            }
        }
    }



    class p2
    {
        static void Main(string[] args)
        {
            int n = 89;
            int count = 0, sum = 0, last = 0;
            int copy = n;
            while (n > 0)
            {
                last = n % 10;
                ++count;
                n = n / 10;
            }
            n = copy;
            while (n > 0)
            {
                last = n % 10;
                sum = sum + (int)Math.Pow(last, count);
                --count;
                n = n / 10;
            }
            if (sum == copy)
            {
                Console.WriteLine("disarrinum");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }


    class program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter employment type");
            String input = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            string fullname1 = Console.ReadLine();
            string lastname1 = Console.ReadLine();
            int Annualsalary1 = int.Parse(Console.ReadLine());
            int perhrs1 = int.Parse(Console.ReadLine());
            int day1 = int.Parse(Console.ReadLine());
            if (input == "fullemployee")
            {
                fulltimeemployee fe = new fulltimeemployee();
                fe.ID = id;
                fe.fullname = fullname1;
                fe.lastname = lastname1;
                fe.Annualsalary = Annualsalary1;
                Console.WriteLine(fe.getdetails());
                Console.WriteLine(fe.getmonthlysalary());
            }
            else
            {
                contractemployee ce = new contractemployee();
                ce.ID = id;
                ce.fullname = fullname1;
                ce.lastname = lastname1;
                ce.perhour = perhrs1;
                ce.totalworkhrs = day1;
                Console.WriteLine(ce.getdetails());
                Console.WriteLine(ce.getmonthlysalary());
            }
        }
    }
    public abstract class baseemployee
    {
        public int ID { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public string getdetails()
        {

            return this.fullname + " " + lastname;
        }
        public abstract int getmonthlysalary();


    }
    class fulltimeemployee : baseemployee
    {
        public int Annualsalary { get; set; }
        public override int getmonthlysalary()
        {
            return this.Annualsalary / 12;

        }
    }




    class contractemployee : baseemployee
    {
        public int perhour { get; set; }
        public int totalworkhrs { get; set; }
        public override int getmonthlysalary()
        {
            return this.perhour * this.totalworkhrs;

        }
    }

    //class prgm9
    //{

    //    int coo(int s)
    //    {
    //        if (s == 1)
    //        {
    //            s = 0;
    //        }
    //        if (s == 2)
    //        {
    //            s = 1;
    //        }
    //        return s;
    //        int coo2(int p)
    //        {
    //            int c = 0;
    //            if (n == 1)
    //            {
    //                Console.WriteLine("0");

    //            }
    //            if (n == 2)
    //            {
    //                Console.WriteLine("1");

    //            }
    //            else if (n > 2)
    //            {
    //                c = 1 * p.coo(n - 1) + 2 * p.coo(n - 2) + 3 * 1;
    //                Console.WriteLine(c);
    //                Console.WriteLine(p.coo(n - 1));
    //                return c;
    //            }



    //        }
    //    }
    //    --

    //    static void Main(string[] args)
    //    {
    //        prgm9 p = new prgm9();
    //        int n = int.Parse(Console.ReadLine());


    //    }


    //}


    class prime4
    {
        static void Main(string[] args)
        {
            int c1 = 0, c2 = 0;
            int prime1 = 0, prime2 = 0, prime3 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                c1 = 0;
                for (int j = 1; j <= n; j++)
                {

                    if (i % j == 0)
                    {
                        c1++;
                    }

                }
                if (c1 == 2)
                {
                    c2++;
                    prime1 = i;
                }
                if (c2 == 2)
                {
                    prime3 = prime1;
                }
                if (c2 == 1)
                {
                    prime2 = prime1;
                }
            }
            Console.WriteLine("co prime numbers are :" + prime2 + " &" + prime3);

        }

    }

    class subarray
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int j;
            int max = 0;
            int zero, ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                    {
                        zero++;
                    }
                    else
                    {
                        ones++;

                    }
                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : (j - i + 1);
                    }
                }
            }
            Console.WriteLine(max);


        }
    }
}
class cuckoooo
{
    public int codo(int n)
    {
        if (n == 1)
            return 0;
        else if (n == 2)
            return 1;
        else
            return 1 * codo(n - 1) + 2 * codo(n - 2) + 3 * 1;

    }
    static void Main(string[] args)
    {
        // abc a = new abc();
        // int y= a.codo(3);
        //Console.WriteLine("ans= "+y);
    }

}


