using SOLID.L.Correct;
using SOLID.S.Violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSalaryEmployees();

            Console.ReadKey();
        }

        static void PrintSalaryEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Manager(3000, 2000) { Name = "Joao" },
                new Seller(1500, 1000) { Name = "Victor" },
                new Seller(1500, 1500) { Name = "Clara" }
            };

            PayRoll payRoll = new PayRoll();
            payRoll.PrintPayments(employees);
        }
    }
}
