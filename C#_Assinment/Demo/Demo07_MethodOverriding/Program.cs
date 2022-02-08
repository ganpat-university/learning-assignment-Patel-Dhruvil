using System;

namespace Demo07_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo objDemo = new Demo();
            objDemo.DoSomthing();
            Console.WriteLine();

            AnotherDemo objAnotherDemo = new AnotherDemo();
            objAnotherDemo.DoSomthing();
            Console.WriteLine();

            Demo objDemo2 = new AnotherDemo();
            objDemo2.DoSomthing();
        }
    }
}
