using System.Collections.Generic;

namespace HackerRank
{
    public class PlusMinus
    {
        private decimal negatives = 0;
        private decimal positives = 0;
        private decimal zeros = 0;
        private int total = 0;

        public string Run(List<int> arrayOfIntegers) {
            this.total = arrayOfIntegers.Count;

            foreach (int number in arrayOfIntegers)
                if(number < 0)
                    negatives++;
                else if(number == 0)
                    zeros++;
                else
                    positives++;

            return this.FormatOutput();
        }

        public string FormatOutput() {
            return $"{(positives/total).ToString("##0.000000")}\n{(negatives/total).ToString("##0.000000")}\n{(zeros/total).ToString("##0.000000")}";
        }
    }
}