using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    public interface IEquation
    {
        public double Perform(double num1, double num2);
    }


    //Incomment below to finish
    // public class Subtraction : IEquation
    // {
    //     public double Perform(double num1, double num2)
    //     {
    //         return num1 - num2;
    //     }
    // }

    // public class Multiplication : IEquation
    // {
    //     public double Perform(double num1, double num2)
    //     {
    //         return num1 * num2;
    //     }
    // }

    // public class Division : IEquation
    // {
    //     public double Perform(double num1, double num2)
    //     {
    //         if (num2 == 0)
    //         {
    //             throw new DivideByZeroException();
    //         }
    //         return num1 / num2;
    //     }
    // }
}
