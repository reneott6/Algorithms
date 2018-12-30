using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Utils.Extensions;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        public IList<T> Sort<T>(IList<T> input) where T: IComparable<T>
        {
            if (input.Count == 1)
                return input;

            var separatingIndex = (input.Count - 1) / 2;
            var elementsInLeftHalf = separatingIndex + 1;
            var elementsInRightHalf = input.Count - elementsInLeftHalf;

            var leftHalfElements = input.Take(elementsInLeftHalf).ToList();
            var rightHalfElements = input.TakeLast(elementsInRightHalf).ToList();

            var orderedLeftHalf = Sort(leftHalfElements);
            var orderedRightHalf = Sort(rightHalfElements);

            return Merge(orderedLeftHalf, orderedRightHalf);
        }

        private static IList<T> Merge<T>(IList<T> leftHalf, IList<T> rightHalf) where T: IComparable<T>
        {
            var result = new List<T>();

            var leftHalfIndex = 0;
            var rightHalfIndex = 0;

            while (leftHalfIndex < leftHalf.Count && rightHalfIndex < rightHalf.Count)
            {
                var leftHalfElem = leftHalf[leftHalfIndex];
                var rightHalfElem = rightHalf[rightHalfIndex];

                if (leftHalfElem.LesserThan(rightHalfElem))
                {
                    result.Add(leftHalfElem);
                    leftHalfIndex++;
                }
                else
                {
                    result.Add(rightHalfElem);
                    rightHalfIndex++;
                }
            }

            if (leftHalfIndex < leftHalf.Count && rightHalfIndex == rightHalf.Count)
            {
                for (;leftHalfIndex < leftHalf.Count; leftHalfIndex++)
                    result.Add(leftHalf[leftHalfIndex]);
            }

            if (rightHalfIndex < rightHalf.Count && leftHalfIndex == leftHalf.Count)
            {
                for (;rightHalfIndex < rightHalf.Count; rightHalfIndex++)
                    result.Add(rightHalf[rightHalfIndex]);
            }

            return result;
        }
    }
}
