using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Static Class = inside static class only static property or class can be access, not non-static classes

            //where as in Singleton you can instantiate non-static calss

            EmployeeService employeeService = EmployeeService.EmployeeServiceInstance();
            var emp1 = new Employee { FistName = "Jayakumar", LastName = "Mogenahalli" };
            var emp2 = new Employee { FistName = "Savitha", LastName = "Jayakumar" };
            var emp3 = new Employee { FistName = "Suman", LastName = "Jayakumar" };

            employeeService.AddEmployee(emp1);
            employeeService.AddEmployee(emp2);
            employeeService.AddEmployee(emp3);

            foreach (var e in employeeService.GetEmployeeByLastName("Jayakumar"))
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();

        }
    }
}
