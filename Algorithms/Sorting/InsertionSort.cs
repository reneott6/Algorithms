﻿using System;
using System.Collections.Generic;
using Algorithms.Utils.Extensions;
using Algorithms.Utils.Logger;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        private readonly ILogger logger;

        private readonly SortOrder order;
        private readonly bool isStable;
        private readonly bool isForwardSort;

        public InsertionSort(SortOrder order, ILogger logger = null, bool isStable = true, bool isForwardSort = true)
        {
            this.isForwardSort = isForwardSort;
            this.order = order;
            this.logger = logger;
            this.isStable = isStable;
        }

        // BCS -> O(n) 
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
            logger.LogList("INITIAL", input);
            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                logger.LogList("  OUTER BEGIN", input);
                for (var innerIndex = outerIndex; innerIndex > 0; innerIndex--)
                {
                    logger.Log("    INNER LOOP");
                    var currentElemenet = input[innerIndex];
                    var previousElement = input[innerIndex - 1];

                    if (ShouldSwap(previousElement, currentElemenet))
                        SwapBackward(input, innerIndex, currentElemenet, previousElement);
                    else
                    {
                        logger.Log("    No Swap");
                        break;
                    }
                }
                logger.LogList("  OUTER END", input);
            }

            logger.LogList("RESULT", input);

            return input;
        }

        private void SwapBackward<T>(IList<T> input, int innerIndex, T currentElement, T previousElement)
        {
            logger.Log($"    Swap backward: Index: {innerIndex}, CurElem: {currentElement}, PrevElem: {previousElement}");
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
