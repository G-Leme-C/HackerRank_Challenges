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
            List<int> arr = new List<int>() {256741038, 623958417, 467905213, 714532089, 938071625};

            var result = MiniMaxSum.MiniMaxSumRun(arr);

            var resultArray = result.Split(" ");

            Assert.AreEqual(resultArray[0], "2063136757");
            Assert.AreEqual(resultArray[1], "2744467344");
        }
    }
}