using System;
using System.Collections.Generic;
using Algorithms.Utils.Extensions;
using Algorithms.Utils.Logger;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        private readonly ISortLogger logger;

        private readonly SortOrder order;
        private readonly bool isStable;
        private readonly bool isForwardSort;

        public InsertionSort(SortOrder order, ISortLogger logger = null, bool isStable = true, bool isForwardSort = true)
        {
            this.isForwardSort = isForwardSort;
            this.order = order;
            this.logger = logger;
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

                    if (HasInversion(currentElement, nextElement))
                        SwapForward(input, innerIndex, currentElement, nextElement);
                    else
                        break;
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
            logger.LogInitialList(input);

            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                logger.LogOuterLoopBegin(input); //
                for (var innerIndex = outerIndex; innerIndex > 0; innerIndex--)
                {
                    logger.LogInnerLoopBegin(input); //
                    var currentElemenet = input[innerIndex];
                    var previousElement = input[innerIndex - 1];

                    if (HasInversion(previousElement, currentElemenet))
                    {
                        SwapBackward(input, innerIndex, currentElemenet, previousElement);
                        logger.LogInnerLoopEnd(input); //
                    }
                    else
                    {
                        logger.LogInnerLoopEnd(input); //
                        break;
                    }
                }

                logger.LogOuterLoopEnd(input); //
            }

            logger.LogResultList(input); //

            return input;
        }

        private void SwapBackward<T>(IList<T> input, int innerIndex, T currentElement, T previousElement)
        {
            input[innerIndex - 1] = currentElement;
            input[innerIndex] = previousElement;

            logger.LogSwap(currentElement, previousElement); //
        }

        private bool HasInversion<T>(IComparable<T> firstPosElement, T secondPosElement)
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
