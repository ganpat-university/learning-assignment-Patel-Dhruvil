using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface_Extending.Demo03
{
    interface IDemo
    {
        void p();
    }

    interface IAnotherDemo : IDemo
    {
        void q();
    }

    class Demo2 : IAnotherDemo
    {
        void IDemo.p()
        {

        }

        void IAnotherDemo.q()
        {

        }
    }

    class Demo1 : IAnotherDemo
    {
        public void p()
        {

        }

        public void q()
        {

        }

    }
}
