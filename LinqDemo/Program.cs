using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> f = x => x * x ;
            Action<int> write = x=> Console.WriteLine(x);
            Console.WriteLine(f(42));
            write(f(23));
            Employee employee = new Employee();
            var developers = new Employee[]
            {
                new Employee{Id=1,Name="Tarun"},
                new Employee{Id=2,Name="Abhishek"},
                new Employee{Id=3,Name="Hemang"},
                new Employee{Id=4,Name="Irfan"},
                new Employee{Id=5,Name="Abhijeet"},
                new Employee{Id=6,Name="Richa"},
                new Employee{Id=7,Name="Sameer"},
                new Employee{Id=8,Name="Nihaar"},
                new Employee{Id=9,Name="Rishika"},
                new Employee{Id=10,Name="Ridhima"},

            };
            
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id=11,Name="Prachi"}
            };
            var  employees = developers.GetEnumerator();
            while (employees.MoveNext())
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine($"********Count the No. of Developers:{developers.Count()}******");
            Console.WriteLine("*********Name Start With A: USing Delegates********");
            //USING DELEGATE
            foreach (var arg in developers.Where(delegate (Employee arg)
            {
          
                return arg.Name.StartsWith("A");
            }))
            {
               
                Console.WriteLine($"{employee.Name}");

            }
            #region
            //Using Lambada Expression
            Console.WriteLine("*********Name Start With R & Order them: USing Lambada Expresion********");

            foreach (var emp in developers.Where(emp => emp.Name.StartsWith("R")).OrderBy(emp=>emp.Name).Take(2))
            {
                /*     var sortedName = from s in developers
                                orderby s.Name
                                select s;
                                */
               
                Console.WriteLine(emp.Name);
             //   Console.WriteLine(names);
            }
            #endregion
        }

        #region
        // Using Method
        /*  private static bool NameStartWithA(Employee arg)
          {
              return arg.Name.StartsWith("A");
          }*/
        #endregion

    }
}
