using System;
using System.Collections.Generic;
using Algorithms.Sorting.Common;
using Algorithms.Utils.Extensions;

namespace Algorithms.Sorting
{
    public class SelectionSort : ComparisonSort
    {
        public SelectionSort(SortOrder order, bool isForwardSort = true)
        {
            Order = order;
            IsForwardSort = true;
            IsStableSort = true;
        }

        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            return SortForward(input);
        }

        private IList<T> SortForward<T>(IList<T> input) where T : IComparable<T>
        {
            return input;
        }
    }
}