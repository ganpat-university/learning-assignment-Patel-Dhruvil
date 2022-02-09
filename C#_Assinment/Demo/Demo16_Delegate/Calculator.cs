using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_Delegate
{
    delegate int ComputeHandler(int a, int b);

    class Calculator
    {
        public int Compute(int a, int b, ComputeHandler objD)
        {
            int result = -1;
            if (objD != null)
            {
                result = objD(a, b);
            }

            Console.WriteLine(" 5. Audit Logging");

            return result;
        }

        public int Add(int a, int b)
        { 
            return a + b;
        }

    }
}
