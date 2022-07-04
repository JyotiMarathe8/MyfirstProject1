using System;

namespace MyfirstProject1.ladder
{
    class gradeofstudent
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the marks of students");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            int i4 = int.Parse(Console.ReadLine());
            int i5 = int.Parse(Console.ReadLine());

            int total = i1 + i2 + i3 + i4 + i5;
            int per = (total / 5) * 100;
            if (per > 70)
            {
                Console.WriteLine("Percentage of student is distinction  -   " + per);

            }
            else if (per >= 60 && per <= 70)
            {
                Console.WriteLine("Percentage of student is First class  -  " + per);

            }
            else if (per < 60 && per >= 40)
            {

                Console.WriteLine("Percentage of student is Second class  -  " + per);
            }
            else
            {

                Console.WriteLine("Percentage of student is fail  -  ");
            }


        }
    }
}
