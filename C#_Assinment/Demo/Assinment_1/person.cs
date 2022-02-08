using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("plz enter the name");
                }
                else
                {
                    _name = value;
                }
            }
        }
        

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("plz enter the age beetween 18 to 65");
                }
            }
        }

    }
}
