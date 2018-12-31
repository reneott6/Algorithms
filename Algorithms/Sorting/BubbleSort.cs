using System;
using System.Collections.Generic;
using Algorithms.Sorting.Common;

namespace Algorithms.Sorting
{
    public class BubbleSort : ComparisonSort
    {
        public BubbleSort(SortOrder order, bool isStable = true, bool isForwardSort = true)
        {
            IsForwardSort = isForwardSort;
            Order = order;
            IsStableSort = isStable;
        }

        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            return IsForwardSort
                ? SortForward(input)
                : SortBackward(input);
        }

        private IList<T> SortBackward<T>(IList<T> input) where T : IComparable<T>
        {
            return input;
        }

        //---unsorted--- [i] sorted
        //--unsorted-- [i] -sorted-
        //-unsorted- [i] --sorted--
        //unsorted [i] ---sorted---
        private IList<T> SortForward<T>(IList<T> input) where T : IComparable<T>
        {
            for (var outerIndex = input.Count - 1; outerIndex > 0; outerIndex--)
            {
                var temp = input[0];

                for (var innerIndex = 0; innerIndex < outerIndex; innerIndex++)
                {
                    var next = input[innerIndex + 1];
                    if (AreElementsInversed(temp, next))
                    {
                        input[innerIndex + 1] = temp;
                        input[innerIndex] = next;
                    }
                    else
                        temp = input[innerIndex+1];
                }

            }
            return input;
        }
    }
}
