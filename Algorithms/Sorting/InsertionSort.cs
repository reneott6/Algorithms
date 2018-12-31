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
            for (var outerIndex = input.Count - 1; outerIndex >= 0 ; outerIndex--)
            {
                var innerIndex = outerIndex;
                while (innerIndex < input.Count - 1 && AreInversed(input[innerIndex], input[innerIndex + 1]))
                {
                    SwapForward(input, innerIndex);
                    innerIndex++;
                }
            }

            return input;
        }

        private static void SwapForward<T>(IList<T> input, int innerIndex)
        {
            var temp = input[innerIndex];
            input[innerIndex] = input[innerIndex + 1];
            input[innerIndex + 1] = temp;
        }

        private IList<T> SortForward<T>(IList<T> input) where T: IComparable<T>
        {
            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                var innerIndex = outerIndex;
                while (innerIndex > 0 && AreInversed(input[innerIndex - 1], input[innerIndex]))
                {
                    SwapBackward(input, innerIndex);
                    innerIndex--;
                }
            }

            return input;
        }

        private static void SwapBackward<T>(IList<T> input, int innerIndex)
        {
            var temp = input[innerIndex];

            input[innerIndex] = input[innerIndex - 1];
            input[innerIndex - 1] = temp;
        }

        private bool AreInversed<T>(IComparable<T> firstPosElement, T secondPosElement)
        {
            return order == SortOrder.Ascending
                ? isStable
                    ? firstPosElement.GreaterThan(secondPosElement)
                    : firstPosElement.GreaterOrEqualThan(secondPosElement)
                : isStable
                    ? firstPosElement.LesserThan(secondPosElement)
                    : firstPosElement.LesserOrEqualThan(secondPosElement);
        }
    }
}
