using System;
using System.Collections.Generic;
using Algorithms.Utils.Extensions;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        private readonly SortOrder order;
        private readonly bool isStable;
        private readonly bool isForwardSort;

        public InsertionSort(SortOrder order, bool isStable = true, bool isForwardSort = true)
        {
            this.isForwardSort = isForwardSort;
            this.order = order;
            this.isStable = isStable;
        }

        public IList<T> Sort<T>(IList<T> input) where T: IComparable<T>
        {
            return isForwardSort
                ? SortForward(input)
                : SortBackward(input);
        }

        private IList<T> SortBackward<T>(IList<T> input) where T : IComparable<T>
        {
            // outerIndex -> All positions which are greater than outer index are sorted 
            // outerIndex = input.Count - 1 -> The last position
            // outerIndex >= 0 -> Outer index 
            // outerIndex-- -> Outer index must decrease, because we're moving from end to start
            for (var outerIndex = input.Count - 1; outerIndex >= 0; outerIndex--)
            {
                // innerIndex -> All positions which are greater than outer inner index are sorted
                // innerIndex < input.Count - 1 -> Move forward and potentially swap until there are no more elements
                // innerIndex++ -> Because we are moving forward
                for (var innerIndex = outerIndex; innerIndex < input.Count - 1; innerIndex++)
                {
                    var currentElement = input[innerIndex];
                    var nextElement = input[innerIndex + 1];

                    if (ShouldSwap(currentElement, nextElement))
                        SwapForward(input, innerIndex, currentElement, nextElement);
                }
            }

            return input;
        }

        private static void SwapForward<T>(IList<T> input, int innerIndex, T currentElement, T nextElement)
        {
            input[innerIndex + 1] = currentElement;
            input[innerIndex] = nextElement;
        }

        private IList<T> SortForward<T>(IList<T> input) where T: IComparable<T>
        {
            for (var outerIndex = 0; outerIndex < input.Count; outerIndex++)
            {
                for (var innerIndex = outerIndex; innerIndex > 0; innerIndex--)
                {
                    var currentElemenet = input[innerIndex];
                    var previousElement = input[innerIndex - 1];

                    if (ShouldSwap(previousElement, currentElemenet))
                        SwapBackward(input, innerIndex, currentElemenet, previousElement);
                }
            }

            return input;
        }

        private static void SwapBackward<T>(IList<T> input, int innerIndex, T currentElement, T previousElement)
        {
            input[innerIndex - 1] = currentElement;
            input[innerIndex] = previousElement;
        }

        private bool ShouldSwap<T>(IComparable<T> innerElement, T outerElement)
        {
            return order == SortOrder.Ascending
                ? isStable
                    ? innerElement.GreaterThan(outerElement)
                    : innerElement.GreaterOrEqualThan(outerElement)
                : isStable
                    ? innerElement.LesserThan(outerElement)
                    : innerElement.LesserOrEqualThan(outerElement);
        }
    }
}
