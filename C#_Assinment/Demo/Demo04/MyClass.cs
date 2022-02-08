using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
        class MyClass
        {
            public int ID;

            private string _name;

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
                        Console.WriteLine("plz fill the name");
                    }
                    else
                    {
                        _name = value;
                    }
                }
            }

        }
    }

