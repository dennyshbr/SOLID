using SOLID.S.Correct;

namespace SOLID.O.Correct
{
    public class Percentage : ICalculatation
    {
        public decimal Calculate(decimal percentage, decimal num)
        {
            return (num * percentage) / 100;
        }
    }
}
