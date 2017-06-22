using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        readonly Calculator _calculator = new Calculator();
        readonly CalculatorTrainer _calculatorTrainer = new CalculatorTrainer();

        [Test]
        public void CalculateASum()
        {
            var result = _calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var result = _calculator.Calculate("6-3");
            Check.That(result).IsEqualTo(3);
        }

        [Test]
        public void CalculateAProduct()
        {
            var result = _calculator.Calculate("3*3");
            Check.That(result).IsEqualTo(9);
        }

        [Test]
        public void CalculateADivision()
        {
            var result = _calculator.Calculate("9/3");
            Check.That(result).IsEqualTo(3);
        }

        [Test]
        public void CalculateOperationInArray()
        {
            _calculatorTrainer.Run();
        }

        //[Test]
        //public void makeSomeDevTest()
        //{
        //    var result = _calculator.Test();
        //}
    }
}
