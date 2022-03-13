using System;

namespace SOLID.S.Violation
{
    public class Calculator
    {
        public decimal Calculate(decimal num1, decimal num2, string calculationType)
        {
            if (calculationType == "SUM")
            {
                return num1 + num2;
            }
            else if (calculationType == "SUBTRACTION")
            {
                return num1 - num2;
            }
            else if (calculationType == "DIVISION")
            {
                return num1 / num2;
            }
            else if (calculationType == "MULTIPLICATION")
            {
                return num1 * num2;
            }
            else
            {
                throw new NotImplementedException("Calculation type is not implemented.");
            }
        }
    }
}
