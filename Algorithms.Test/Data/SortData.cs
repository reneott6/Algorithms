using System.Collections.Generic;
using Algorithms.Utils.Models;

namespace Algorithms.Test.Data
{
    public class SortData
    {
        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputSameValuesOrderedDesc_ExpectedOutputInstableOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(5),
                new SortValue<int>(4, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(4, 1),
                new SortValue<int>(5)
            });

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithSameValuesOrderedAsc_ExpectedOutputInstableOrderedDesc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(4, 1),
                new SortValue<int>(5)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(5),
                new SortValue<int>(4, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            });

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithSameValuesOrderedAsc_ExpectedOutputStableOrderedDesc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(4),
                new SortValue<int>(5)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesUnordered_ExpectedOutputOrderedDesc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(3),
                new SortValue<int>(1),
                new SortValue<int>(2)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_ExpectedOutputOrderedDesc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderdDesc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(1)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesOrderedAsc_ExpectedOutputOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(1),
                new SortValue<int>(3),
                new SortValue<int>(2)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(6)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_ExpectedOutputOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(6)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesUnordered_ExpectedOutputOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(3),
                new SortValue<int>(1),
                new SortValue<int>(2)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            }
        );

        public readonly (IList<SortValue<int>> input, IList<SortValue<int>> expectedOutput) InputWithDistinctValuesOrderedDesc_ExpectedOutputOrderedAsc =
        (
            new List<SortValue<int>>
            {
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            },
            new List<SortValue<int>>
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            }
        );
    }
}