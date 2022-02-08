using System;

namespace demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;

            int j = int.MaxValue;
            a = j + 1;

            long l = j;                 

            l = long.MaxValue;
            j = (int)l;                 

            Console.WriteLine("l (long) = {0}, j (int) = {1}", l, j);
        }
    }
}
