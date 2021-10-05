using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class MiniMaxSum
    {

        public static string MiniMaxSumRun(List<int> arr) {
            var fullSum = arr.Aggregate((a, b) => a + b);
            var lowestPossibleSum = fullSum - arr.Max();
            var biggestPossibleSum = fullSum - arr.Min();

            return $"{lowestPossibleSum} {biggestPossibleSum}";
        }
        
    }
    
}