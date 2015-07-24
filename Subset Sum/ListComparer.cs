using System.Collections.Generic;
using System.Linq;

namespace Subset_Sum
{
    public class ListComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<int> obj)
        {
            int hashCode = 0;

            for (var index = 0; index < obj.Count; index++)
            {
                hashCode ^= new { Index = index, Item = obj[index] }.GetHashCode();
            }

            return hashCode;
        }
    }
}
