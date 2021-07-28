using Microsoft.VisualStudio.TestTools.UnitTesting;
using Broadway._630.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway._630.Web.Tests
{
    [TestClass()]
    public class ArithmeticOperationTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int a = 2;
            int b = 5;
            int expectedoutput = 7;
            ArithmeticOperation aop = new ArithmeticOperation();
            int actualoutput = aop.Add(a, b);

            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            int a = 2;
            int b = 5;
            int expectedoutput = -3;
            ArithmeticOperation aop = new ArithmeticOperation();
            int actualoutput = aop.Subtract(a, b);

            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int a = 2;
            int b = 5;
            int expectedoutput = 10;
            ArithmeticOperation aop = new ArithmeticOperation();
            int actualoutput = aop.Multiply(a, b);

            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod()]
        public void MultiplyByZeroTest()
        {
            int a = 2;
            int b = 0;

            Assert.ThrowsException<NumberZeroException>(() =>
            {
                ArithmeticOperation aop = new ArithmeticOperation();
                aop.Multiply(a, b);
            });
        }

        [TestMethod()]
        public void DivideTest()
        {
            int a = 4;
            int b = 2;
            int expectedoutput = 2;
            ArithmeticOperation aop = new ArithmeticOperation();
            int actualoutput = aop.Divide(a, b);

            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod()]
        public void DividebyZero()
        {
            int a = 4;
            int b = 0;
            int expectedoutput = 0;
            ArithmeticOperation aop = new ArithmeticOperation();
            int actualoutput = aop.Divide(a, b);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
    }
}