using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sum
{
    class SubsetSum
    {
        private List<double> values;
        private List<List<double>> possibilities = new List<List<double>>();
        public SubsetSum(List<double> values)
        {
            this.values = values;
        }

        public void getPossibilities(double desiredResult)
        {

        }

        private void subset_sum(List<double> numbers, double target, List<double> partial)
        {
            double sum = partial.Sum();

            if (Math.Abs(sum - target) <= 0.00001)
            {
                this.possibilities.Add(partial);
            }

            if (sum > target)
            {
                return;
            }

            int i = 0;
            int total = numbers.Count;

            while (i < total)
            {
                double n = numbers[i];
                numbers.RemoveAt(0);
                partial.Add(n);
                this.subset_sum(numbers, target, partial);
            }
        }
    }
}
