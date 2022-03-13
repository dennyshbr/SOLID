namespace SOLID.L.Correct
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public abstract decimal GetSalary();
    }
}
