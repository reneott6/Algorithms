using System.Linq;
using Algorithms.Sorting;
using Algorithms.Utils.Models;
using NUnit.Framework;

namespace Algorithms.Test.Algorithms.Sorting
{
    [TestFixture]
    public class MergeSortTests
    {
        [TestCase]
        public void SortAscending_IgnoreStability_SwapsEqualElement()
        {
            var input = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(6)
            };

            var orderedOutput = new MergeSort().Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }
    }
}
