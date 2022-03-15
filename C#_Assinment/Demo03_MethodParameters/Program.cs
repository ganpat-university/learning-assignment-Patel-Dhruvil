using System;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i;

                //Pass By Value
                Console.WriteLine("Pass By Value");
                i = 15;
                Console.WriteLine("i = {0}", i);
                DemoOfPassByValue(i);
                Console.WriteLine("i now = {0}", i);
                Console.WriteLine();

                //Pass By Reference
                Console.WriteLine("Pass By Reference");
                i = 15;
                Console.WriteLine("i = {0}", i);
                DemoOfPassByReference(ref i);
                Console.WriteLine("i now = {0}", i);
                Console.WriteLine();

                //pass by output
                Console.WriteLine("Pass By Out/Output");
                i = 15;
                Console.WriteLine("i = {0}", i);
                DemoOfPassByOut(out i);
                Console.WriteLine("i now = {0}", i);
                Console.WriteLine();

            }

            static void DemoOfPassByValue(int a)
            {
                Console.WriteLine("Received a = {0}", a);
                a = 50;
                Console.WriteLine("after change, a = {0}", a);
            }

            static void DemoOfPassByReference(ref int a)
            {
                Console.WriteLine("Received a = {0}", a);
                a = 50;
                Console.WriteLine("after change, a = {0}", a);
            }

            static void DemoOfPassByOut(out int a)
            {
                a = 50;
                Console.WriteLine("after change, a = {0}", a);
            }
        }
    }
}
