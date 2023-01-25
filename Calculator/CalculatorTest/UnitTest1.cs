using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            int a = 2;
            int b = 3;
            Calculator.SimpleCalculator myCal = new Calculator.SimpleCalculator();
            int result = myCal.Add(a, b);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestSubstract()
        {
            int a = 10;
            int b = 5;
            Calculator.SimpleCalculator myCal = new Calculator.SimpleCalculator();
            int result = myCal.Substract(a, b);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestMultiply()
        {
            int a = 10;
            int b = 5;
            Calculator.SimpleCalculator myCal = new Calculator.SimpleCalculator();
            int result = myCal.Multiply(a, b);
            Assert.AreEqual(result, 50);
        }

        [Test]
        public void TestDivideValid()
        {
            int a = 10;
            int b = 5;
            Calculator.SimpleCalculator myCal = new Calculator.SimpleCalculator();
            float result = myCal.Divide(a, b);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void TestDivideInvalid()
        {
            int a = 10;
            int b = 0;
            Calculator.SimpleCalculator myCal = new Calculator.SimpleCalculator();
            float result = myCal.Divide(a, b);
            Assert.AreEqual(result, 0);
        }
    }
}