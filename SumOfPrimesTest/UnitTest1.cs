using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfPrimesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SumOfPrimes.Program testclass = new SumOfPrimes.Program();
            ulong givenNumber = 20;
            ulong expectResult = 77;
            ulong result = testclass.sumOfPrimes(givenNumber);
            Assert.AreEqual(result, expectResult);
        }
    }
}
