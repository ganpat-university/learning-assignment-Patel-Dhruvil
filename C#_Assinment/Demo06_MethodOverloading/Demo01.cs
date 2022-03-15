using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_MethodOverloading
{
    class Demo01
    {
        public void DoSomething(int i)
        {
            Console.WriteLine("get integer : {0}", i);
        }


        public void DoSomething(string s)
        {
            Console.WriteLine("get a string: {0}", s);
        }


        public void DoSomething(bool b)
        {
            Console.WriteLine("get Boolean: {0}", b);
        }

    }
}
