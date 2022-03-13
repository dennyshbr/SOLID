namespace SOLID.S.Correct
{
    public class Calculator
    {
        public decimal Calculate(decimal num1, decimal num2, ICalculatation typeCalculate)
        {
            return typeCalculate.Calculate(num1, num2);
        }
    }
}
