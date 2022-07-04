using System;

namespace MyfirstProject1.instance
{
    class HDFCBank
    {
#pragma warning disable CS0414 // The field 'HDFCBank.accid' is assigned but its value is never used
        int accid;
#pragma warning restore CS0414 // The field 'HDFCBank.accid' is assigned but its value is never used
#pragma warning disable CS0169 // The field 'HDFCBank.accno' is never used
        string accno;
#pragma warning restore CS0169 // The field 'HDFCBank.accno' is never used
#pragma warning disable CS0169 // The field 'HDFCBank.bal' is never used
        int bal;
#pragma warning restore CS0169 // The field 'HDFCBank.bal' is never used
#pragma warning disable CS0649 // Field 'HDFCBank.roi' is never assigned to, and will always have its default value 0
        static float roi;
#pragma warning restore CS0649 // Field 'HDFCBank.roi' is never assigned to, and will always have its default value 0

        //Requied object to call instance method
        public void m1()
        {
#pragma warning disable CS0219 // The variable 'a' is assigned but its value is never used
            int a = 90;
#pragma warning restore CS0219 // The variable 'a' is assigned but its value is never used
        }

        //static doesn't require object. it only created once, we can change the the value of static variable.
        //classname.m2();
        static void m2()
        {

        }

        static void Main(string[] args)
        {
            HDFCBank h1 = new HDFCBank();
            h1.m1();
            h1.accid = 900;
            HDFCBank.m2();

            Console.WriteLine("Hello");
            Console.WriteLine(HDFCBank.roi);

        }
    }

    class Movie
    {
        string MovieName;
        int rating;

        //set value to SetMovie
        public void setMovieName(string mname)
        {
            MovieName = mname;
        }

        public string getMovieName()
        {
            return MovieName;
        }

        public void setRating(int r)
        {
            rating = r;
        }
        public int getRating()
        {
            return rating;
        }
    }
    class Mtest
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.setMovieName("Aparichit");
            Console.WriteLine(m.getMovieName());
            m.setRating(255);
            Console.WriteLine(m.getRating());

        }
    }

    class Restaurant
    {
        string RestauName;
        string area;
        long mobilename;
        int rating;

        public void setRstaurantName(string rnm)
        {
            RestauName = rnm;
        }

        public string getRetaurantName()
        {
            return RestauName;
        }

        public void setRating(int r)
        {
            this.rating = r;
        }

        public int getRating()
        {
            return rating;
        }

        public string RestaurantName
        {
            set { RestauName = value; }
            get { return RestauName; }
        }
        public string AreaName
        {
            set { area = value; }
            get { return area; }
        }
        public long MobileName
        {
            set { mobilename = value; }
            get { return mobilename; }
        }
        public int Ratingg
        {
            set { rating = value; }
            get { return rating; }
        }

    }
    class Calling
    {
        static void Main(string[] args)
        {
            Restaurant R1 = new Restaurant();
            R1.RestaurantName = "Delicious";
            Console.WriteLine(R1.RestaurantName);
            R1.RestaurantName = (Console.ReadLine());

            R1.AreaName = "Pune";
            Console.WriteLine(R1.AreaName);
            R1.AreaName = (Console.ReadLine());

            R1.MobileName = 9900999087;
            Console.WriteLine(R1.MobileName);
            R1.MobileName = long.Parse(Console.ReadLine());

            R1.Ratingg = 90000;
            Console.WriteLine(R1.Ratingg);
            R1.Ratingg = int.Parse(Console.ReadLine());

        }
    }

    /*using properties*/
    class time
    {
        int Hour, Min, Sec;
        public int hour
        {
            set { Hour = value; }
            get { return Hour; }



        }
        public int min
        {
            set { Min = value; }
            get { return Min; }

        }
        public int sec
        {
            set { Sec = value; }
            get { return Sec; }

        }
    }
    class Timetest
    {
        static void Main(string[] args)
        {
            time t1 = new time();

            t1.hour = 5;
            t1.min = 26;
            t1.sec = 30;
            Console.WriteLine(t1.hour + "hr :" + t1.min + "min :" + t1.sec + "sec");

            time t2 = new time();

            t2.hour = 6;
            t2.min = 27;
            t2.sec = 3;
            Console.WriteLine(t2.hour + "hr :" + t2.min + "min :" + t2.sec + "sec");


            time t3 = new time();

            t3.hour = int.Parse(Console.ReadLine());
            t3.min = int.Parse(Console.ReadLine());
            t3.sec = int.Parse(Console.ReadLine());
            Console.WriteLine(t3.hour + "hr :" + t3.min + "min :" + t3.sec + "sec");
        }

    }




    public class rectangle
    {
        int length, area;

        public static int breadth;

        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }


        public int Area()
        {
            area = length * breadth;

            return area;
        }

        public static void Perimeter()
        {
            Console.WriteLine(breadth);

        }
    }

    class rectangletest
    {

        static void Main(string[] args)
        {
            rectangle.Perimeter();


            // Console.WriteLine(rectangle.length); cannot access due to instance variable, before the instance
            rectangle r1 = new rectangle();

            r1.Length = 15;
            r1.Breadth = 20;
            rectangle.Perimeter();
            int A2 = r1.Area();
            Console.WriteLine(r1.Length);


        }


    }



    class overload
    {

        static int Max(int a, int b)

        {
            int max2;
            if (a > b)
            {
                max2 = a;
                Console.WriteLine(" Maximum :" + max2);
            }
            else
            {
                max2 = b;
                Console.WriteLine("Maximum : " + max2);
            }
            return max2;
        }
        static int Max(int a, int b, int c)
        {
            int max1;
            if (a > b && a > c)
            {
                max1 = a;
                Console.WriteLine(max1);
            }
            else if (b > c)
            {
                max1 = b;
                Console.WriteLine(max1);
            }
            else
            {
                max1 = c;
                Console.WriteLine(max1);
            }
            return max1;
        }

        static void Main(string[] args)
        {
            int maxi = Max(5, 2);
            Max(5, 2, 3);

        }

    }


    /*consturctor*/

    class pen
    {
        int pprice;
        String pname;
        string pbrand;
        string pcolor;

        public pen()

        {

        }
        public pen(String pnm)
        {
            pname = pnm;

        }
        public pen(String pnm, string pbnd)
        {
            pname = pnm;
            pbrand = pbnd;

        }
        public pen(string pnm, string pbnd, string pcolr)
        {
            pname = pnm;
            pbrand = pbnd;
            pcolor = pcolr;

        }
        public pen(string pnm, string pbnd, string pcolr, int price)
        {
            pname = pnm;
            pbrand = pbnd;
            pcolor = pcolr;
            pprice = price;

        }
        static void Main(string[] args)
        {
            pen p1 = new pen();
            pen p2 = new pen("Mountain");
            pen p3 = new pen("Mountain", "renolds");
            pen p4 = new pen("Mountain", "renolds", "black");
            pen p5 = new pen("Mountain", "renolds", "black", 20);
        }


    }



    class gParent
    {
        public void m1()
        {
            Console.WriteLine("m1");
        }
    }
    class pparent : gParent
    {
        public void m2()
        {
            Console.WriteLine("m2");

        }
    }
    class cchild : pparent
    {
        public void m3()
        {
            Console.WriteLine("m3");
        }
    }
    class tr
    {
        static void Main(string[] args)
        {
            cchild cc = new cchild();
            cc.m1();
            cc.m2();
            cc.m3();

        }
    }





}
