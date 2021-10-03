using System;
using NUnit.Framework;
using HackerRank;
using System.Collections.Generic;

namespace HackerRank.Tests 
{
    [TestFixture]
    public class PlusMinusTest
    {
        [Test]
        public void PlusMinus_ShouldPass() {
            
            List<int> arrayOfIntegers = new List<int>() { -1, -2, 0, 2, 1 };
            string result = PlusMinus.PlusMinusV1(arrayOfIntegers);

            string[] results = result.Split("\n");
            
            decimal positives = Convert.ToDecimal(results[0]);
            decimal negatives = Convert.ToDecimal(results[1]);
            decimal zeros = Convert.ToDecimal(results[2]);

            Assert.AreEqual(positives, 0.4);
            Assert.AreEqual(negatives, 0.4);
            Assert.AreEqual(zeros, 0.2);
        }
    }
}