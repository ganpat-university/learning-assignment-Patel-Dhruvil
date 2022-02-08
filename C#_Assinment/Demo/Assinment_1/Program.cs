using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person MyPerson = new person();
            Console.Write("Enter your name: ");
            MyPerson.Name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            MyPerson.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("hi {0} your age is {1}", MyPerson.Name, MyPerson.Age);
        }
    }
}
