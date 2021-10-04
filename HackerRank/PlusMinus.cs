using System.Collections.Generic;

namespace HackerRank
{
    public class PlusMinus
    {
        private decimal negatives = 0;
        private decimal positives = 0;
        private decimal zeros = 0;
        private int total = 0;

        public string Run(List<int> arrayOfIntegers) 
        {
            this.total = arrayOfIntegers.Count;

            foreach (int number in arrayOfIntegers) {
                SumIfNegative(number);
                SumIfPositive(number);
                SumIfZero(number);
            }

            return this.FormatOutput();
        }

        private void SumIfNegative(int number) 
        { 
            this.negatives += (number < 0 ? 1: 0);
        }

        private void SumIfPositive(int number) 
        { 
            this.positives += (number > 0 ? 1: 0);
        }

        private void SumIfZero(int number) 
        { 
            this.zeros += (number == 0 ? 1: 0);
        }


        private string FormatOutput() 
        {
            return $"{(positives/total).ToString("##0.000000")}\n{(negatives/total).ToString("##0.000000")}\n{(zeros/total).ToString("##0.000000")}";
        }
    }
}