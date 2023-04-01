using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Multiplication : IEquation
    {
        public double Perform(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
