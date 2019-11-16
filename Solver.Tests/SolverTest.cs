﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class SolverTest
    {
        void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);
            //Assert
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);

        }
        [TestMethod]
        public void OrdinaryEquation()
        {
            // TestEquation(1, -3, 2, new double[] { 2, 1 });
            TestEquation(1, -3, 2, 2, 1);


        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            // TestEquation(1, 1, 1, new double[0] );
            TestEquation(1, 1, 1);

        }
        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquation(1, 2, 1, -1);
        }
        [TestMethod]
        public void FunctionalTest()
        {
            for (int i = 0; i < 100; i++)
            {
                var rnd = new Random(i);
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var result = QuadraticEquationsSolver.Solve(a, b, c);
                foreach (var x in result)
                {
                    Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
                }
            }

        }
        [TestMethod]
        public void ZeroA()
        {
            TestEquation(0, -1, 1, 1);
        }
        [TestMethod]
        public void ZeroAandB()
        {
            TestEquation(0, 0, 1);
        }
    }
}
