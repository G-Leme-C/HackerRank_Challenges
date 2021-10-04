using System;
using NUnit.Framework;
using HackerRank;
using System.Collections.Generic;

namespace HackerRank.Tests 
{
    [TestFixture]
    public class PlusMinusTest
    {
        private List<int> arrayOfIntegers;

        private decimal positivesProportion; 
        private decimal negativesProportion;
        private decimal zerosProportion;

        [SetUp]
        public void PlusMinusTestSetup() {
            var randomGen = new Random();

            var positiveCount = randomGen.Next(101);            
            var negativeCount = randomGen.Next(101);
            var zeroCount = randomGen.Next(101);

            var totalCount = positiveCount + negativeCount + zeroCount;

            this.positivesProportion = Convert.ToDecimal(((decimal)positiveCount/totalCount).ToString("##0.000000"));
            this.negativesProportion = Convert.ToDecimal(((decimal)negativeCount/totalCount).ToString("##0.000000"));
            this.zerosProportion = Convert.ToDecimal(((decimal)zeroCount/totalCount).ToString("##0.000000"));

            this.arrayOfIntegers = new List<int>();

            for (int i = 0; i < positiveCount; i++)
                arrayOfIntegers.Add(randomGen.Next(1, 101));

            for (int i = 0; i < negativeCount; i++)
                arrayOfIntegers.Add(randomGen.Next(-101, -1));

            for (int i = 0; i < zeroCount; i++)
                arrayOfIntegers.Add(0);
        }


        [Test]
        public void PlusMinus_Run_ShouldPass() {
            
            PlusMinus plusMinusChallenge = new PlusMinus();
            string result = plusMinusChallenge.Run(arrayOfIntegers);

            string[] results = result.Split("\n");
            
            decimal positives = Convert.ToDecimal(results[0]);
            decimal negatives = Convert.ToDecimal(results[1]);
            decimal zeros = Convert.ToDecimal(results[2]);

            Assert.AreEqual(positives, this.positivesProportion);
            Assert.AreEqual(negatives, this.negativesProportion);
            Assert.AreEqual(zeros, this.zerosProportion);
        }
    }
}