using System;

namespace MyfirstProject1.inheritance_Constructors
{
    //Inheritance-------------------------------------------------------------------------
    //---------------------------------
    class Parent
    {
        private int id = 101;
        string nm = "jyo";
        public int Id
        { get => id; set => id = value; }
        public string Nm

        { get => nm; set => nm = value; }
        public void m1()
        {
            Console.WriteLine(" In parent class");
        }
        public void m2()
        {
            Console.WriteLine("In Child class");
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            Parent c = new Parent();
            c.m1();
            c.m2();
            Console.WriteLine(c.Id);
            Console.WriteLine(c.Nm);
        }
    }






    class Parents
    {
        public virtual void DisplayParents()
        {
            Console.WriteLine("Jayshri - Jaykant ");
        }
    }
    class Child : Parents
    {
        public override void DisplayParents()
        {
            Console.WriteLine(" I am Child of Jayshri and Jaykant & quot");
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Parents p = new Parents();

            p.DisplayParents();
            Child c = new Child();
            c.DisplayParents();
            Parents p1 = new Child();
            p1.DisplayParents();

        }
    }

    // overload-compile time polymorphism
    class Teacher
    {
        string tname;
        int salary;
        int experience;
        public Teacher()
        {
            Console.WriteLine("In teacher Constructor ");
        }
        public Teacher(string tname, int salary, int experience)
        {
            this.tname = tname;
            this.salary = salary;
            this.experience = experience;
        }
        public string Tname
        {
            get => tname; set => tname = value;
        }
        public int Salary
        {
            get => salary; set => salary = value;
        }
        public int Experience
        {
            get => experience; set => experience = value;
        }
    }
    class VisitingTeacher : Teacher
    {
        public int hrs, rate;
        public VisitingTeacher(string nm, int sal, int exp, int hrs, int r) : base(nm,
        sal, exp)
        {
            Console.WriteLine("In Visiting ");
            this.hrs = hrs;
            this.rate = r;
        }
        //so basically we not used getter setter beacuse variables are public.

    }
    class TTT
    {
        static void Main(string[] args)
        {
            VisitingTeacher v = new VisitingTeacher(" deepa", 20000, 07, 9, 10);
            Console.WriteLine(v.Tname);
            Console.WriteLine(v.Salary);
            Console.WriteLine(v.Experience);
            Console.WriteLine(v.rate);
        }
    }
    //CONTAINMENT---------------------------------------------------------------------
    //--------------------------------------//
    class Pen1
    {
        string brand;

        int cost;
        string colour;
        public Pen1(string brand, int cost, string color)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Colour = color;
        }
        public string Brand
        {
            get => brand; set => brand = value;
        }
        public int Cost
        {
            get => cost; set => cost = value;
        }
        public string Colour
        {
            get => colour; set => colour = value;
        }
    }
    class CompassBox
    {
        string compassBrand;
        int price;
        Pen1 pen;
        static void Main(string[] args)
        {
            CompassBox Box = new CompassBox();
            Box.compassBrand = "Natraj ";
            Console.WriteLine(Box.compassBrand);
            Box.price = 300;
            Console.WriteLine(Box.price);
            Box.pen = new Pen1(" Cello", 50, " Black ");
            Console.WriteLine(Box.pen.Brand);
            Console.WriteLine(Box.pen.Cost);
            Console.WriteLine(Box.pen.Colour);
        }

    }



    class item
    {
        string Iname;
        int Iprice;
        public item(String Iname, int Iprice)
        {
            this.Iname1 = Iname;
            this.Iprice1 = Iprice;

        }

        public string Iname1 { get => Iname; set => Iname = value; }
        public int Iprice1 { get => Iprice; set => Iprice = value; }
    }
    class order
    {
        public String Address;
        public int Onum;
        public order(string Address, int Onum)
        {
            this.Address = Address;
            this.Onum = Onum;

        }
    }
    class Customer
    {
        String Cname;
        order o1;
        item i1;


        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Cname = "Jyoti";
            c.o1 = new order("Wadgaon Sheri ", 52);
            c.i1 = new item("Book", 500);
            Console.WriteLine(" Constructor 1-" + c.Cname + " " + c.o1.Address + " " + c.o1.Onum + " " + c.i1.Iname1 + "  " + c.i1.Iprice1 + " ");

        }

    }


    // overidding run time polymorphism
    class parent
    {
        public int x = 9;
        public virtual void study()
        {
            Console.WriteLine("study by books");
        }
    }
    class child : parent
    {
#pragma warning disable CS0414 // The field 'child.x' is assigned but its value is never used
#pragma warning disable CS0108 // 'child.x' hides inherited member 'parent.x'. Use the new keyword if hiding was intended.
        int x = 10;
#pragma warning restore CS0108 // 'child.x' hides inherited member 'parent.x'. Use the new keyword if hiding was intended.
#pragma warning restore CS0414 // The field 'child.x' is assigned but its value is never used
        public override void study()
        {
            Console.WriteLine("Study by online books");
        }
    }
    class tt
    {
        static void Main(string[] args)
        {
            parent p1 = new parent();
            p1.study();
            child c1 = new child();
            c1.study();
            Console.WriteLine(" using child class :" + c1.x);
            child p2 = new child();
            p2.study();
            Console.WriteLine("using parent reference type" + p2.x);



        }
    }



    class aa
    {
        string name;
        int a;

        public aa(string name, int a)
        {
            this.name = name;
            this.a = a;
        }
        //tostring method is overriden which is thr in object classs.
        public override string ToString()
        {
            return (name + "Name " + a + " a");
#pragma warning disable CS0162 // Unreachable code detected
            return $" name:{name},a:{a}";
#pragma warning restore CS0162 // Unreachable code detected
        }
        static void Main(string[] args)
        {
            aa a1 = new aa("jyoti", 10);
            Console.WriteLine(a1);

        }

    }

    class t9
    {
        //use of break and contiue
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }





    class rr
    {
        static void Main(string[] args)
        {
            int line = 3;

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


    class ttt
    {
        public virtual void parent()
        {
            Console.WriteLine("parent method");
        }

    }
    class ttt1 : ttt
    {
        public override void parent()
        {
            base.parent();

            Console.WriteLine("child method");
        }
    }

    class ppp : ttt1
    {
        static void Main(string[] args)
        {
            ttt j = new ttt1();

            j.parent();


        }
    }




}