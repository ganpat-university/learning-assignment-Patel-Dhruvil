using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment_Geo_Symbol.demo
{
    public class Run
    {
        public static void RunTime()
        {
            Rectangle objRect = new Rectangle(10,20);
            Console.WriteLine(" here is the area & perimeter of rectangle");
            Console.WriteLine("lenght- {0} breadth- {1}", objRect.length, objRect.breadth);
            Console.WriteLine("Perimeter- {0}", objRect.perimeter);
            Console.WriteLine("Area- {0}", objRect.Area());

            Square square = new Square(10);
            Console.WriteLine(" here is the area & perimeter of Square");
            Console.WriteLine("side {0}", square.side);
            Console.WriteLine("Perimeter- {0}", square.perimeter);
            Console.WriteLine("Area- {0}", square.Area());


        }
    }
     
        abstract class GeometricSymbols
        {
            abstract public decimal perimeter { get; }

            abstract public decimal Area();
        }
        class Triangle : GeometricSymbols
        {
            private int side1, side2, side3;

            public Triangle(int side1, int side2, int side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            public override decimal perimeter 
            {
                get 
                {
                    return this.side1 + this.side2 + this.side3;
                }
            }
            public override decimal Area()
            {
                return 0.000000m;
            }
        }
         abstract class Quadrilateral : GeometricSymbols
        {
            protected int side1, side2, side3, side4;

            public override decimal perimeter
            {
                get
                {
                    return this.side1 + this.side2 + this.side3 + this.side4;
                }
            }
            public abstract override decimal Area();
        }

        class Square : Quadrilateral
        {
            public Square(int side)
            {
                base.side1 = base.side2 = base.side3 = base.side4 = side;
            }
            public int side
            {
                get
                {
                    return base.side1;
                }
            }
            public override decimal Area()
            {
                return base.side1 * base.side2;
            }

        }
        class Rectangle : Quadrilateral
        {
            public Rectangle(int length, int breadth)
            {
                base.side1 = base.side3 = length;
                base.side2 = base.side4 = breadth;
            }
            public int length
            {
                get
                {
                    return base.side1;
                }
            }
            public int breadth
            {
                get
                {
                    return base.side2;
                }
            }
            public override decimal Area()
            {
                return this.length * this.breadth;
            }
        }
    
}
