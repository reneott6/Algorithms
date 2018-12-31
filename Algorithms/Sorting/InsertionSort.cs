using System;
using System.Collections.Generic;
using Algorithms.Sorting.Common;

namespace Algorithms.Sorting
{
    public class InsertionSort : ComparisonSort
    {
        public InsertionSort(SortOrder order, bool isStable = true, bool isForwardSort = true)
        {
            Order = order;
            IsForwardSort = isForwardSort;
            IsStableSort = isStable;
        }

        public IList<T> Sort<T>(IList<T> input) where T: IComparable<T>
        {
            return IsForwardSort
                ? SortForward(input)
                : SortBackward(input);
        }

        // --unsorted--[i]--sorted--
        private IList<T> SortBackward<T>(IList<T> input) where T : IComparable<T>
        {
            for (var outerIndex = input.Count - 1; outerIndex >= 0 ; outerIndex--)
            {
                var innerIndex = outerIndex;
                while (innerIndex < input.Count - 1 && HasInversion(input[innerIndex], input[innerIndex + 1]))
                {
                    SwapForward(input, innerIndex);
                    innerIndex++;
                }
            }

            return input;
        }

        // -sorted-[i]--unsorted--
        // --sorted--[i]-unsorted-
        private IList<T> SortForward<T>(IList<T> input) where T: IComparable<T>
        {
            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                var innerIndex = outerIndex;
                while (innerIndex > 0 && HasInversion(input[innerIndex - 1], input[innerIndex]))
                {
                    SwapBackward(input, innerIndex);
                    innerIndex--;
                }
            }

            return input;
        }
    }
}
