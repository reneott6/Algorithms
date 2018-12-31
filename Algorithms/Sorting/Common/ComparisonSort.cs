using System;
using System.Collections.Generic;
using Algorithms.Utils.Extensions;

namespace Algorithms.Sorting.Common
{
    public abstract class ComparisonSort
    {
        protected SortOrder Order { private get; set; }
        protected bool IsForwardSort { get; set; }
        protected bool IsStableSort { private get; set; }

        protected static void SwapForward<T>(IList<T> input, int currentIndex)
        {
            var temp = input[currentIndex];
            input[currentIndex] = input[currentIndex + 1];
            input[currentIndex + 1] = temp;
        }

        protected static void SwapBackward<T>(IList<T> input, int currentIndex)
        {
            var temp = input[currentIndex];
            input[currentIndex] = input[currentIndex - 1];
            input[currentIndex - 1] = temp;
        }

        protected bool HasInversion<T>(IComparable<T> firstPosElement, T secondPosElement)
        {
            return Order == SortOrder.Ascending
                ? IsStableSort
                    ? firstPosElement.GreaterThan(secondPosElement)
                    : firstPosElement.GreaterOrEqualThan(secondPosElement)
                : IsStableSort
                    ? firstPosElement.LesserThan(secondPosElement)
                    : firstPosElement.LesserOrEqualThan(secondPosElement);
        }
    }
}
