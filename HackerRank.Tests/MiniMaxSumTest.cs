using System;
using NUnit.Framework;
using System.Collections.Generic;
using HackerRank;

namespace HackerRank.Tests
{

    [TestFixture]
    public class MiniMaxSumTest
    {
        [Test]
        public void MiniMaxSumTest_ShouldPass() {
            List<int> arr = new List<int>() { 1, 3, 5, 7, 9};

            var result = MiniMaxSum.MiniMaxSumRun(arr);

            var resultArray = result.Split(" ");

            Assert.AreEqual(resultArray[0], "16");
            Assert.AreEqual(resultArray[1], "24");
        }
    }
}