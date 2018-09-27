using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightConverterLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double ouncesValue = 1;
            WeightConverterLibClass converter = new WeightConverterLibClass();
            double result = converter.fromOuncesToGrams(ouncesValue);
            Assert.AreEqual(28.35, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            double gramsValue = 1;
            WeightConverterLibClass converter = new WeightConverterLibClass();
            double result = converter.fromGramToOunces(gramsValue);
            Assert.AreEqual(0.035274, result);

        }
    }
}
