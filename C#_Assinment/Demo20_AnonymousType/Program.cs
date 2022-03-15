﻿using System;

namespace Demo20_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "First Employee"
            };
            emp.EmployeeName = emp.EmployeeName.ToUpper();
            Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);

            var emp2 = new { ID = 4, Name = "Anonymous Name" };
            Console.WriteLine("{0} {1}", emp2.ID, emp2.Name);


            var arr = new[]
            {
                new { ID = 1, Name = "First employee"},
                new { ID = 2, Name = "Second employee"},
                new { ID = 3, Name = "Third employee" }
            };
            foreach (var item in arr)
            {
                Console.WriteLine("{0} {1}", item.ID, item.Name);
            }
        }
        class Employee
        {
            public int EmployeeID { get; set; }

            public string EmployeeName { get; set; }
        }
    }
}
