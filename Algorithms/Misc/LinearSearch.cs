using System.Collections.Generic;

namespace Algorithms.Misc
{
    public class LinearSearch
    {
        private readonly IList<int> list;
        private readonly int value;

        public LinearSearch(IList<int> list, int value)
        {
            this.value = value;
            this.list = list;
        }

        public int? FindValue()
        {
            // Invariant loop: value doesn't exist in list[k..i-1], where's k integer & k <= i
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                    return i;
            }

            return null;
        }
    }
}
