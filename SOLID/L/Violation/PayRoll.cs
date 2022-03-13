using System.Collections.Generic;

namespace SOLID.L.Violation
{
    public class PayRoll
    {
        public void PrintPayments(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee is Seller)
                {
                    ((Seller)employee).GetSalarySeller();
                }
                else if (employee is Manager)
                {
                    ((Manager)employee).GetSalaryManager();
                }
            }
        }
    }
}
