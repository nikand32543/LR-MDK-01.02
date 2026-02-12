using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace TestCalculator
{
    [TestClass]
    public class TCalculator
    {
        Calculatorr calculator = new Calculatorr();
        [TestMethod]
        public void TestSumm()
        {
            int x = 4;
            int y = 5;

            int expected = 9;
            double action = calculator.Summ(x, y);
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int x = 15;
            int y = 5;

            int expected = 10;
            double action = calculator.Subtraction(x, y);
            Assert.AreEqual(expected, action);
        }

        
        [TestMethod]
        public void TestMultiplication()
        {
            int x = 7;
            int y = 3;

            int expected = 21;
            double action = calculator.Multiplication(x, y);
            Assert.AreEqual(expected, action);
        }

        
        [TestMethod]
        public void TestDivide()
        {
            int x = 12;
            int y = 3;

            int expected = 4;
            double action = calculator.Divide(x, y);
            Assert.AreEqual(expected, action);
        }
    }
}
