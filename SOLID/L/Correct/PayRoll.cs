using System;
using System.Collections.Generic;

namespace SOLID.L.Correct
{
    public class PayRoll
    {
        public void PrintPayments(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name} - Salary: {employee.GetSalary()}");
            }
        }
    }
}
