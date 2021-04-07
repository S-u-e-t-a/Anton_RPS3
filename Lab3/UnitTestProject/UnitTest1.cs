using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab3;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CalculatePointOnTheGraph1()
        {
            
            double coefficientC = 50.0;
            double coefficientA = 50.0;
            double x = 30.0;
            double expectedY = 22.47;
            
            double resultY = CassiniOval.CalculatePointOnTheGraph(coefficientC, coefficientA, x);
            resultY = Math.Round(resultY, 2);
            
            Assert.AreEqual(expectedY, resultY);
        }
        [TestMethod]
        public void CalculatePointOnTheGraph2()
        {
            
            double coefficientC = 70.0;
            double coefficientA = 70.0;
            double x = 60.0;
            double expectedY = 35.0;
            
            double resultY = CassiniOval.CalculatePointOnTheGraph(coefficientC, coefficientA, x);
            resultY = Math.Round(resultY, 2);
            
            Assert.AreEqual(expectedY, resultY);
        }
        [TestMethod]
        public void CalculatePointOnTheGraph3()
        {
            
            double coefficientC = 90.0;
            double coefficientA = 90.0;
            double x = 90.0;
            double expectedY = 43.73;
            
            double resultY = CassiniOval.CalculatePointOnTheGraph(coefficientC, coefficientA, x);
            resultY = Math.Round(resultY, 2);
            
            Assert.AreEqual(expectedY, resultY);
        }
        [TestMethod]
        public void CalculatePointOnTheGraph4()
        {
            
            double coefficientC = 60.0;
            double coefficientA = 60.0;
            double x = 30.0;
            double expectedY = 24.31;
            
            double resultY = CassiniOval.CalculatePointOnTheGraph(coefficientC, coefficientA, x);
            resultY = Math.Round(resultY, 2);
            
            Assert.AreEqual(expectedY, resultY);
        }
        [TestMethod]
        public void CalculatePointOnTheGraph5()
        {
            
            double coefficientC = 80.0;
            double coefficientA = 80.0;
            double x = 20.0;
            double expectedY = 18.85;
            
            double resultY = CassiniOval.CalculatePointOnTheGraph(coefficientC, coefficientA, x);
            resultY = Math.Round(resultY, 2);
            
            Assert.AreEqual(expectedY, resultY);
        }
    }
}
