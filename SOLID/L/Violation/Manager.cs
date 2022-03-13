namespace SOLID.L.Violation
{
    public class Manager : Employee
    {
        private decimal _bonus;

        public Manager(decimal salary, decimal bonus)
        {
            _bonus = bonus;
            Salary = salary;
        }

        public decimal GetSalaryManager()
        {
            return Salary + _bonus;
        }
    }
}
