using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {

            List<double> numberArray = new List<double>();
            Double result = 0;

            string[] numbers = operation.Split('+');

            foreach (string num in numbers)
            {
                result += Convert.ToDouble(num);
            }

            return result;
        }
    }
}