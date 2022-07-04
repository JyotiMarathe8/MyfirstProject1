using System;

namespace MyfirstProject1.OOPS
{
    class student
    {
        string name;
        int percentage;
        int year;
        string branch;
        public void accept()
        {
            Console.WriteLine("Enter name , percentrage, year, branch");
            name = Console.ReadLine();
            percentage = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            branch = Console.ReadLine();


        }

        public void display()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("percentage : " + percentage);
            Console.WriteLine("Branch :" + branch);
            Console.WriteLine("year :" + year);
        }
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.accept();
            s1.display();

        }



    }






    class student1
    {
        string library;
        string books;
        string subject;
        string author;
        public void accept()
        {
            Console.WriteLine("Enter library , books, subject, author");
            library = Console.ReadLine();
            books = (Console.ReadLine());
            subject = (Console.ReadLine());
            author = Console.ReadLine();


        }

        public void display()
        {
            Console.WriteLine("name :" + library);
            Console.WriteLine("percentage : " + books);
            Console.WriteLine("Branch :" + subject);
            Console.WriteLine("year :" + author);
        }
        static void Main(string[] args)
        {
            student1 s1 = new student1();
            s1.accept();
            s1.display();

        }





    }

    class calculator
    {
        int n1, n2;
        public void read()
        {
            Console.WriteLine(" enter numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

        }
        public int Add()
        {

            int a = n1 + n2;
            return a;



        }

        public int sub()
        {

            int s = n1 - n2;
            return s;

        }

        public int mul()
        {

            int m = n1 * n2;
            return m;

        }

        public float di()
        {

            float d = n1 / n2;
            return d;

        }


        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            c1.read();

            int a1 = c1.Add();
            int m1 = c1.mul();
            float d1 = c1.di();
            int s1 = c1.sub();



            Console.WriteLine(a1);
            Console.WriteLine(m1);
            Console.WriteLine(d1);
            Console.WriteLine(s1);
        }
    }




    /* read, print factorial number and callf from main*/



    class demo3
    {
        int n1;
        public void read()
        {
            n1 = int.Parse(Console.ReadLine());

        }
        public int fact()
        {
            int count = 1;
            for (int i = 1; i <= n1; i++)
            {

                count = count * i;



            }

            // Console.WriteLine(" Factorial : "+count);

            return count;

        }
        public bool prime()
        {
            int c = 0;

            for (int i = 1; i <= n1; i++)
            {


                if (n1 % i == 0)
                {
                    ++c;
                    Console.WriteLine(c);

                }

            }


            if (c == 2)

                return true;
            else

                return false;

        }
        static void Main(string[] args)
        {
            demo3 d1 = new demo3();
            d1.read();
            int s1 = d1.fact();
            bool p1 = d1.prime();

            Console.WriteLine("Factorial :" + s1);
            Console.WriteLine("Prime :" + p1);


        }

    }





















}








