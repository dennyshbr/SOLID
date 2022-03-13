namespace SOLID.L.Correct
{
    public class Seller : Employee
    {
        private decimal _commission;

        public Seller(decimal salary, decimal commission)
        {
            _commission = commission;
            Salary = salary;
        }
        
        public override decimal GetSalary()
        {
            return Salary + _commission;
        }
    }
}
