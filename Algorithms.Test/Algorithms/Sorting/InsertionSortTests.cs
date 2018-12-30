using System.Linq;
using Algorithms.Sorting;
using Algorithms.Utils.Logger;
using Algorithms.Utils.Models;
using NUnit.Framework;

namespace Algorithms.Test.Algorithms.Sorting
{
    [TestFixture]
    public class InsertionSortTests
    {
        private ILogger logger;

        [SetUp]
        public void SetUpTest()
        {
            logger = new ConsoleLogger();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_IgnoreStability_SwapsEqualElement(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(5),
                new SortValue<int>(4, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(4, 1),
                new SortValue<int>(5)
            };

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_IgnoreStability_SwapsEqualElement(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(4, 1),
                new SortValue<int>(5)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(5),
                new SortValue<int>(4, 1),
                new SortValue<int>(4, 2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, false, isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_BackwardOrderedInput_OrdersDescendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(4),
                new SortValue<int>(5)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3, 1),
                new SortValue<int>(3, 2),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_UnorderedInput_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(3),
                new SortValue<int>(1),
                new SortValue<int>(2)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_OneElement_OneElement(bool isForwardSort)
        {
            var input = new [] { new SortValue<int>(1)  };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(input));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_FirstHalfOrderedSecondHaldBackwardOrdered_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortDescending_FirstHalfBackwardOrderedSecondHalfInorder_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(1)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(3),
                new SortValue<int>(2),
                new SortValue<int>(1)
            };

            var orderedOutput = new InsertionSort(SortOrder.Descending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_BackwardOrderedInput_OrdersAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
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
                new SortValue<int>(5)
            };

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_UnorderedInput_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(4),
                new SortValue<int>(5),
                new SortValue<int>(3),
                new SortValue<int>(1),
                new SortValue<int>(2)
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            };

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_Empty_ReturnEmpty(bool isForwardSort)
        {
            var input = new SortValue<int>[0];
            var expectedOutput = new SortValue<int>[0];

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_FirstHalfOrderedSecondHaldBackwardOrdered_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4)
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

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortAscending_FirstHalfBackwardOrderedSecondHalfInorder_OrderAscendingly(bool isForwardSort)
        {
            var input = new[]
            {
                new SortValue<int>(6),
                new SortValue<int>(5),
                new SortValue<int>(4),
                new SortValue<int>(1),
                new SortValue<int>(3),
                new SortValue<int>(2)
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

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger, isForwardSort: isForwardSort).Sort(input);

            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }

        [Test]
        public void SortAscending_AlreadySorted_OrderAscendingly()
        {
            var input = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5),
            };

            var expectedOutput = new[]
            {
                new SortValue<int>(1),
                new SortValue<int>(2),
                new SortValue<int>(3),
                new SortValue<int>(4),
                new SortValue<int>(5)
            };

            var orderedOutput = new InsertionSort(SortOrder.Ascending, logger).Sort(input);
            Assert.That(orderedOutput.SequenceEqual(expectedOutput));
        }
    }
}