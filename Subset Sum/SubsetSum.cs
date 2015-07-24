using System;
using System.Collections.Generic;
using System.Linq;

namespace Subset_Sum
{
    public static class SubsetSum
    {
        public static List<List<int>> findSubsets(int sum, int[] data)
        {
            Array.Sort(data);
            HashSet<List<int>> resultIndicesSet = findSubsetIndices(sum, data);
            List<List<int>> results = new List<List<int>>();

            foreach (List<int> resultIndices in resultIndicesSet)
            {
                List<int> result = new List<int>();
                foreach (int indice in resultIndices)
                {
                    result.Add(data[indice]);
                }
                results.Add(result);
            }
            return results.Distinct(new ListComparer()).ToList();
        }

        // Needs sorted data!
        private static HashSet<List<int>> findSubsetIndices(int sum, int[] data)
        {
            HashSet<List<int>> results = new HashSet<List<int>>();
            int tsum = sum;
            List<int> indicies = new List<int>();
            for (int i = data.Length - 1; i >= 0; --i)
            {
                if (data[i] <= tsum)
                {
                    tsum -= data[i];
                    indicies.Add(i);
                }
                if (tsum == 0)
                {
                    results = new HashSet<List<int>>(results.Union(findSubsetIndices(sum, data, indicies)));
                    i = indicies.ElementAt(0);
                    indicies = new List<int>();
                    tsum = sum;
                }
            }
            return results;
        }

        private static HashSet<List<int>> findSubsetIndices(int sum, int[] data, List<int> forbidden_indicies)
        {
            HashSet<List<int>> results = new HashSet<List<int>>();
            for (int k = 1; k < forbidden_indicies.Count(); k++)
            {
                int index = forbidden_indicies.ElementAt(k);

                int tsum = sum;
                List<int> indicies = new List<int>();
                for (int i = data.Length - 1; i >= 0; --i)
                {
                    if (index == i) continue;
                    if (data[i] <= tsum)
                    {
                        tsum -= data[i];
                        indicies.Add(i);
                    }
                    if (tsum == 0)
                    {
                        results.Add(indicies);
                        i = indicies.ElementAt(0);
                        indicies = new List<int>();
                        tsum = sum;
                    }
                }
            }
            results.Add(forbidden_indicies);

            return results;
        }
    }
}
