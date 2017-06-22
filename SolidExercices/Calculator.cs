using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            //
            operation = operation.Replace(" ", string.Empty);
            String currentOperator;
            Double result = 0;

            string[] numbers = null;

            string[] operators = {"+", "-", "*", "/"};

            foreach (var op in operators)
            {
                if (operation.Contains(op))
                {

                }
            }

            //vérifie l'operateur et effectue le calcul
            if (operation.Contains('+'))
            {
                try
                {
                    numbers = operation.Split('+');
                    result = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("L'addition ne fonctionne pas.");
                    throw;
                }

            } else if (operation.Contains("-"))
            {
                numbers = operation.Split('-');
                result = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
            }
            else if (operation.Contains("*"))
            {
                numbers = operation.Split('*');
                result = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
            }
            else if (operation.Contains("/"))
            {
                numbers = operation.Split('/');
                result = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
            }
            else
            {
                Console.Write("L'opérateur de calcul est manquant ou incorrect!\n");
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