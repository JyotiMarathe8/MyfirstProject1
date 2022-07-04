using System;

namespace MyfirstProject1.ladder
{
    class age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the your age");
            int Your = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the friend age");
            int Friend = int.Parse(Console.ReadLine());
            /*  if (Friend < Your)
              {
                  Console.WriteLine("Hi");
              }
              else if (Friend > Your)
              {
                  Console.WriteLine("Good Morning");
              }
              else
              {
                  Console.WriteLine("How are you");
              }*/

            string result = Friend < Your ? "hi" : (Friend > Your ? "Good Morning" : "How are you");
            Console.WriteLine(result);

        }
    }
}
