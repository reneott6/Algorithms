using System.Linq;
using Algorithms.Sorting;
using Algorithms.Test.Data;
using Algorithms.Utils.Logger;
using Algorithms.Utils.Models;
using NUnit.Framework;

namespace Algorithms.Test.Algorithms.Sorting
{
    [TestFixture]
    public class InsertionSortTests
    {
        private ISortLogger logger;
        private SortData data;

        [SetUp]
        public void SetUpTest()
        {
            logger = new ConsoleSortLogger();
            data = new SortData();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_SameValuesOrderedDesc_InstableOrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputSameValuesOrderedDesc_ExpectedOutputInstableOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_SameValuesOrderedAsc_InstableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputInstableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_SameValuesOrderedAsc_StableOrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithSameValuesOrderedAsc_ExpectedOutputStableOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_DistinctValuesUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_OneElement_OneElement(bool isForwardSort)
        {
            var input = new [] { new SortValue<int>(1)  };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(input));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfOrderedAsc_ExpectedOutputOrderedDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDesc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedDesc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderdDesc;

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_DistinctValuesOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_DistinctValuesUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_InputEmpty_ReturnEmpty(bool isForwardSort)
        {
            var input = new SortValue<int>[0];
            var expectedOutput = new SortValue<int>[0];

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_DistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedAscSecondHalfOrderedDesc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_DistinctValuesFirstHalfOrderedDescSecondHalfUnordered_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesFirstHalfOrderedDescSecondHalfUnordered_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAsc_DistinctValuesOrderedAsc_OrderedAsc(bool isForwardSort)
        {
            var (input, expectedOutput) = data.InputWithDistinctValuesOrderedAsc_ExpectedOutputOrderedAsc;

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }
    }
}