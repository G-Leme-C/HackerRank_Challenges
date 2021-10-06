using NUnit.Framework;
using HackerRank;

namespace HackerRank.Tests
{
    [TestFixture]
    public class TimeConversionTest
    {
        [Test]
        [TestCase("12:01:00AM", "00:01:00")]
        [TestCase("07:05:45PM", "19:05:45")]
        [TestCase("12:01:00PM", "12:01:00")]
        public void ConvertToMilitaryTime_ShouldConvertSuccessfully(string inputTime, string expectedOutput) {
            
            TimeConversion conversion = new TimeConversion();

            var output = conversion.ConvertToMilitaryTime(inputTime);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}