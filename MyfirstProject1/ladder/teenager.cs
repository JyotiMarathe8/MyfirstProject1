using System;

namespace MyfirstProject1.ladder
{
    class teenager
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 13 && age <= 18)
            {
                Console.WriteLine(" Teenage");

            }

            else
            {
                Console.WriteLine("Not Teenage");
            }


            /* String age1= (age<18) ? (age>13?"teenage":"not teeage"):"not teenage";
               Console.WriteLine(age1);*/
        }







    }
}
