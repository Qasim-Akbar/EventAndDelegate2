using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate2
{
    public delegate void MathEventHandler(double result);
    internal class MathOperations
    {

        public event MathEventHandler? AdditionPerformed;
        public event MathEventHandler? SubtractionPerformed;
        public event MathEventHandler? MultiplicationPerformed;
        public event MathEventHandler? DivisionPerformed;

        public void Add(double firstNumber, double secondNumber)
        {
            double result =  firstNumber + secondNumber;
            AdditionPerformed?.Invoke(result);
        }

        public void Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            SubtractionPerformed?.Invoke(result);
        }

        public void Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            MultiplicationPerformed?.Invoke(result);
        }

        public void Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double result = firstNumber / secondNumber;
                DivisionPerformed?.Invoke(result);
            }
            else
            {
                Console.WriteLine("Error: can't divide by zero!");
            }
            
        }
    }
}
