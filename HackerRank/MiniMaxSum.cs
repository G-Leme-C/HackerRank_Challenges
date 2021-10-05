using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class MiniMaxSum
    {

        public static string MiniMaxSumRun(List<int> arr) {

            arr = new List<int>() {256741038, 623958417, 467905213, 714532089, 938071625 };
            long fullSum = arr.Sum<long>(arr);

            // for (int i = 0; i < arr.Count; i++)
            // {
            //     fullSum = fullSum + arr[i];
            // }
            
            long lowestPossibleSum = fullSum - arr.Max();
            long biggestPossibleSum = fullSum - arr.Min();

            return $"{lowestPossibleSum} {biggestPossibleSum}";
        }

        public static string MiniMaxSumRun_Linq(List<int> arr) {

            arr = new List<int>() {256741038, 623958417, 467905213, 714532089, 938071625 };

            long fullSum = arr.Aggregate((a, b) => a + b);
            long lowestPossibleSum = fullSum - arr.Max();
            long biggestPossibleSum = fullSum - arr.Min();

            return $"{lowestPossibleSum} {biggestPossibleSum}";
        }
        
    }
    
}