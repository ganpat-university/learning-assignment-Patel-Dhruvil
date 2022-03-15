using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
            Console.WriteLine("Hello from Dhruvil");

            Console.Write("Enter Your name please: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your age please: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hi {0}. You are {1} years young!", name, age);
        }
    }
}
