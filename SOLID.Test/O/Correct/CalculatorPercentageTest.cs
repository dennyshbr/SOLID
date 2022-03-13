using SOLID.O.Correct;
using SOLID.S.Correct;
using Xunit;

namespace SOLID.Test.O.Correct
{
    public class CalculatorPercentageTest
    {
        [Theory]
        [InlineData(15, 150, 22.5)]
        [InlineData(75, 1000, 750)]
        [InlineData(17, 658.75, 111.9875)]
        public void MustReturnPercentageOfValue(decimal percent, decimal number, decimal resultExpected)
        {
            ICalculatation percentage = new Percentage();

            Calculator calculator = new Calculator();

            decimal result = calculator.Calculate(percent, number, percentage);

            Assert.Equal(resultExpected, result);
        }
    }
}
