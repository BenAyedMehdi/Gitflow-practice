using Calculator.Interfaces;


namespace Calculator.Classes
{
    public class Addition : IEquation
    {
        public double Perform(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}

