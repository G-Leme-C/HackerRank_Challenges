using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class MiniMaxSum
    {
        public static string MiniMaxSumRun(List<int> arr) {
            long fullSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                fullSum = fullSum + arr[i];
            }
            
            long lowestPossibleSum = fullSum - arr.Max();
            long biggestPossibleSum = fullSum - arr.Min();

            return $"{lowestPossibleSum} {biggestPossibleSum}";
        }        
    }
    
}