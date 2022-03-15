using System;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)

        {
            MyClass o;                  
            o = new MyClass();          
            o.ID = 30;                  
            o.Name = "Something";

            MyClass obj = new MyClass();
            obj.ID = 10;
            obj.Name = "First object";

            MyStructure objStructure;
            objStructure.ID = 20;
            objStructure.Name = "";

            MyDayNames day = MyDayNames.Thursday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);
            day = MyDayNames.Sunday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);

            int i = 5;
            day = (MyDayNames)i;
            Console.WriteLine("{0} {1}", day, i);



        }
    }
}
