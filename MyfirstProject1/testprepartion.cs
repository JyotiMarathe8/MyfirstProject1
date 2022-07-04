using System;

namespace MyfirstProject1
{
    class testprepartion
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
            testprepartion a = new testprepartion();
            int y = a.codo(8);
            Console.WriteLine("ans= " + y);
        }

    }







    class anagram
    {
        static void Main(string[] args)
        {
            int i;
            int j = new int();
            i = 10;
            j = 2;
            string str;
            str = i.ToString();
            str = j.ToString();
        }
    }
}

