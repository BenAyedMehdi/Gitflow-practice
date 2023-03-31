using Calculator.Interfaces;

namespace Calculator.Classes
{
    public class Subtraction : IEquation
    {
        public double Perform(double num1, double num2)
        {
            return num1-num2;
        }
    }
}
