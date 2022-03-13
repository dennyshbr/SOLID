using SOLID.S.Correct;
using Xunit;

namespace SOLID.Test.S.Correct
{
    public class CalculatorTest
    {
        [Fact]
        public void MustReturnSumOfValues()
        {
            ICalculatation sum = new Sum();

            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Calculate(5, 15, sum);

            Assert.Equal(20, result);
        }

        [Fact]
        public void MustReturnSubtractionOfValues()
        {
            ICalculatation subtraction = new Subtraction();

            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Calculate(10, 5, subtraction);

            Assert.Equal(5, result);
        }

        [Fact]
        public void MustReturnDivisionOfValues()
        {
            ICalculatation division = new Division();

            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Calculate(10, 5, division);

            Assert.Equal(2, result);
        }

        [Fact]
        public void MustReturnMultiplicationOfValues()
        {
            ICalculatation multiplication = new Multiplication();

            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Calculate(5, 5, multiplication);

            Assert.Equal(25, result);
        }
    }
}
