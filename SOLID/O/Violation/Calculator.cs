using System;

namespace SOLID.O.Violation
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

            //Add more else/if

            else if (calculationType == "PERCENTAGE")
            {
                return (num1 * num2) / 100;
            }

            else
            {
                throw new NotImplementedException("Calculation type is not implemented.");
            }
        }
    }
}
