using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            String currentOperator;
            Double result = 0;

            string[] numbers = null;

            if (operation.Contains('+'))
            {
                numbers = operation.Split('+');
                result = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);

            } else if (operation.Contains("-"))
            {
                numbers = operation.Split('-');
                result = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
            }

            //foreach (string num in numbers)
            //{
            //    result += Convert.ToDouble(num);
            //}

            return result;
        }

        public Double CheatedCalculate(string operation)
        {
            double result = (double)new DataTable().Compute(operation, null);
            return result;
        }
    }
}