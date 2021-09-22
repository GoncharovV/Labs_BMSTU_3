using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra.Tests
{
    [TestClass()]
    public class MathVectorTests
    {
        [TestMethod()]
        public void MultiplyTest_General()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, 3 });
            MathVector vec2 = new MathVector(new double[] { 1, 2, 3 });
            MathVector expected = new MathVector(new double[] { 1, 4, 9 });

            MathVector actual = new MathVector(vec1.Multiply(vec2));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest_ZeroVector()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, 3 });
            MathVector vec2 = new MathVector(new double[] { 0, 0, 0 });
            MathVector expected = new MathVector(new double[] { 0, 0, 0 });

            MathVector actual = new MathVector(vec1.Multiply(vec2));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyrTest_NegativeVecto()
        {
            MathVector vec1 = new MathVector(new double[] { -1, 0, -3 });
            MathVector vec2 = new MathVector(new double[] { 1, 2, 3 });
            MathVector expected = new MathVector(new double[] { -1, 0, -9 });

            MathVector actual = new MathVector(vec1.Multiply(vec2));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyNumberTest_General()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, -3 });
            double number = 1;
            MathVector expected = new MathVector(new double[] { 1, 2, -3 });

            MathVector actual = new MathVector(vec1.MultiplyNumber(number));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyNumberTest_ZeroNumber()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, -3 });
            double number = 0;
            MathVector expected = new MathVector(new double[] { 0, 0, 0 });

            MathVector actual = new MathVector(vec1.MultiplyNumber(number));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyNumberTest_ZeroVector()
        {
            MathVector vec1 = new MathVector(new double[] { 0, 0, 0 });
            double number = 54190;
            MathVector expected = new MathVector(new double[] { 0, 0, 0 });

            MathVector actual = new MathVector(vec1.MultiplyNumber(number));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyNumberTest_NegativeNumber()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, -3 });
            double number = -2;
            MathVector expected = new MathVector(new double[] { -2, -4, 6 });

            MathVector actual = new MathVector(vec1.MultiplyNumber(number));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ScalarMultiplyTest_General()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, -3 });
            MathVector vec2 = new MathVector(new double[] { 1, 1, 1 });

            double expected = 1*1 + 2*1 + -3*1;
            double actual = vec1.ScalarMultiply(vec2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ScalarMultiplyTest_ZeroVector()
        {
            MathVector vec1 = new MathVector(new double[] { 1, 2, -3 });
            MathVector vec2 = new MathVector(new double[] { 0, 0, 0 });

            double expected = 0;
            double actual = vec1.ScalarMultiply(vec2);

            Assert.AreEqual(expected, actual);
        }
    }
}