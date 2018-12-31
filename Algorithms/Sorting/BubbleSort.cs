using System;
using System.Collections.Generic;
using Algorithms.Sorting.Common;

namespace Algorithms.Sorting
{
    public class BubbleSort : ComparisonSort
    {
        public BubbleSort(SortOrder order, bool isForwardSort = true)
        {
            IsForwardSort = isForwardSort;
            Order = order;
            
            // You can't make it unstable with swapped variable, because the non-strict inequality causes swapped variable to become true   
            IsStableSort = true;
        }

        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            return IsForwardSort
                ? SortForward(input)
                : SortBackward(input);
        }

        private IList<T> SortBackward<T>(IList<T> input) where T : IComparable<T>
        {
            bool swapped;
            do
            {
                swapped = false;
                for (var i = input.Count - 2; i >= 0; i--)
                {
                    if (!HasInversion(input[i], input[i + 1]))
                        continue;

                    SwapForward(input, i);
                    swapped = true;
                }
            } while (swapped);
            return input;
        }

        private IList<T> SortForward<T>(IList<T> input) where T : IComparable<T>
        {
            bool swapped;
            do
            {
                swapped = false;
                for (var i = 1; i < input.Count; i++)
                {
                    if (!HasInversion(input[i - 1], input[i]))
                        continue;

                    SwapBackward(input, i);
                    swapped = true;
                }
            } while (swapped);

            return input;
        }
    }
}
