using System.Collections.Generic;

namespace HackerRank
{
    public class PlusMinus
    {
        public static string PlusMinusV1(List<int> arrayOfIntegers) {
            
            decimal negatives = 0;
            decimal positives = 0;
            decimal zeros = 0;

            var total = arrayOfIntegers.Count;

            foreach (int number in arrayOfIntegers)
                if(number < 0)
                    negatives++;
                else if(number == 0)
                    zeros++;
                else
                    positives++;

            return $"{(positives/total).ToString("##0.000000")}\n{(negatives/total).ToString("##0.000000")}\n{(zeros/total).ToString("##0.000000")}";
        }
    }
}