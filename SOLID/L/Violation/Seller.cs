namespace SOLID.L.Violation
{
    public class Seller : Employee
    {
        private decimal _commission;

        public Seller(decimal salary, decimal commission)
        {
            _commission = commission;
            Salary = salary;
        }

        public decimal GetSalarySeller()
        {
            return Salary + _commission;
        }
    }
}
