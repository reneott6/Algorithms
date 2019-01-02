using System;
using System.Collections.Generic;
using Algorithms.Sorting.Common;

namespace Algorithms.Sorting
{
    public class InsertionSort : ComparisonSort
    {
        private readonly bool isOptimized;

        public InsertionSort(SortOrder order, bool isStable = true, bool isForwardSort = true, bool isOptimized = true)
        {
            Order = order;
            IsForwardSort = isForwardSort;
            IsStableSort = isStable;
            this.isOptimized = isOptimized;
        }

        public IList<T> Sort<T>(IList<T> input) where T: IComparable<T>
        {
            return IsForwardSort
                ? isOptimized
                    ? SortForwardOptimized(input)
                    : SortForwardUnoptimized(input)
                : !isOptimized
                    ? SortBackwardOptimized(input)
                    : SortBackwardUnoptimized(input);
        }

        private IList<T> SortBackwardOptimized<T>(IList<T> input) where T : IComparable<T>
        {
            for (var outerIndex = input.Count - 2; outerIndex >= 0; outerIndex--)
            {
                var key = input[outerIndex];
                var innerIndex = outerIndex + 1;
                while (innerIndex <= input.Count-1 && HasInversion(key,input[innerIndex]))
                {
                    input[innerIndex - 1] = input[innerIndex];
                    innerIndex++;
                }

                input[innerIndex - 1] = key;
            }

            return input;
        }

        private IList<T> SortBackwardUnoptimized<T>(IList<T> input) where T : IComparable<T>
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

        private IList<T> SortForwardOptimized<T>(IList<T> input) where T: IComparable<T>
        {
            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                var key = input[outerIndex];
                var innerIndex = outerIndex - 1;
                while (innerIndex >= 0 && HasInversion(input[innerIndex], key))
                {
                    input[innerIndex + 1] = input[innerIndex];
                    innerIndex--;
                }

                input[innerIndex + 1] = key;
            }

            return input;
        }

        private IList<T> SortForwardUnoptimized<T>(IList<T> input) where T: IComparable<T>
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