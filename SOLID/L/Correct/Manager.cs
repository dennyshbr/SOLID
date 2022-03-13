namespace SOLID.L.Correct
{
    public class Manager : Employee
    {
        private decimal _bonus;

        public Manager(decimal salary, decimal bonus)
        {
            _bonus = bonus;
            Salary = salary;
        }

        public override decimal GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
