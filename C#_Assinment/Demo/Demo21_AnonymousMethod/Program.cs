using System;

namespace Demo21_AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result;

            result = calc.Add();
            result = calc.Add(10);
            result = calc.Add(10, 20, 30, 40, 50);

            result = calc.Compute(100, 200, Program.Multiply);

            ComputeHandler objD = new ComputeHandler(Program.Multiply);
            result = calc.Compute(100, 200, objD);

            ComputeHandler objD2 = delegate (int a, int b)
            {
                return a * b;
            };
            result = calc.Compute(100, 200, objD2);

            ComputeHandler objD3
                = (int a, int b) =>
                {
                    return a * b;
                };
            result = calc.Compute(100, 200, objD3);

            ComputeHandler objD4
                = (a, b) =>
                {
                    return a * b;
                };
            result = calc.Compute(100, 200, objD4);

            ComputeHandler objD5 =
                (a, b) => a * b;
            result = calc.Compute(100, 200, objD5);
        }
        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}
