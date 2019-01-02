using System.Linq;
using Algorithms.Sorting;
using Algorithms.Sorting.Common;
using Algorithms.Test.Data;
using Algorithms.Utils.Models;
using NUnit.Framework;

namespace Algorithms.Test.Algorithms.Sorting
{
    [TestFixture]
    public class InsertionSortTests
    {
        private SortData data;

        [SetUp]
        public void SetUpTest()
        {
            data = new SortData();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_SameValuesOrderedDesc_InstableOrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputSameValuesOrderedDesc_ExpectedOutputInstableOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, false, isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_SameValuesOrderedAsc_InstableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputInstableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, false, isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_SameValuesOrderedAsc_StableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputStableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_DistinctValuesUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_OneElement_OneElement(bool isForwardSort)
        {
            var input = new [] { new SortValue<int>(1)  };

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(input));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderdDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_DistinctValuesOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_DistinctValuesUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_InputEmpty_ReturnEmpty(bool isForwardSort)
        {
            var input = new SortValue<int>[0];
            var expectedOutput = new SortValue<int>[0];

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_DistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UnoptimizedSortAsc_DistinctValuesOrderedAsc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedAsc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort, isOptimized: false).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_SameValuesOrderedDesc_InstableOrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputSameValuesOrderedDesc_ExpectedOutputInstableOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_SameValuesOrderedAsc_InstableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputInstableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_SameValuesOrderedAsc_StableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputStableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_DistinctValuesUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_OneElement_OneElement(bool isForwardSort)
        {
            var input = new[] { new SortValue<int>(1) };

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(input));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderdDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_DistinctValuesOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_DistinctValuesUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_InputEmpty_ReturnEmpty(bool isForwardSort)
        {
            var input = new SortValue<int>[0];
            var expectedOutput = new SortValue<int>[0];

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_DistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void OptimizedSortAsc_DistinctValuesOrderedAsc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedAsc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }
    }
}