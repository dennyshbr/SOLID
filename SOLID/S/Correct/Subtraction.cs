namespace SOLID.S.Correct
{
    public class Subtraction : ICalculatation
    {
        public decimal Calculate(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
