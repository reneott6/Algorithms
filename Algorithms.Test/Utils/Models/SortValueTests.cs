using Algorithms.Utils.Models;
using NUnit.Framework;

namespace Algorithms.Test.Utils.Models
{
    [TestFixture]
    public class SortValueTests
    {
        [Test]
        public void EqualTo_DifferentObjects_Equals()
        {
            var first = new SortValue<int>(100, 1);
            var second = new SortValue<int>(100, 1);

            Assert.That(first.Equals(second));
        }

        [Test]
        public void GreaterOrEqual_DifferentObjects_Equals()
        {
            var first = new SortValue<int>(100, 1);
            var second = new SortValue<int>(100, 2);

            Assert.That(first >= second);
        }

        [Test]
        public void Greater_DifferentObjects_Equals()
        {
            var first = new SortValue<int>(100, 1);
            var second = new SortValue<int>(100, 2);

            Assert.That(first > second, Is.False);
        }

        [Test]
        public void GreaterOrEqual_SameObjects_Equals()
        {
            var first = new SortValue<int>(100, 2);

            // ReSharper disable once EqualExpressionComparison
            #pragma warning disable CS1718 // Comparison made to same variable
            Assert.That(first >= first);
            #pragma warning restore CS1718 // Comparison made to same variable
        }

        [Test]
        public void GetHashCode_ValueNull_ReturnsZero()
        {
            var value = new SortValue<string>(null);

            Assert.That(value.GetHashCode(), Is.EqualTo(0));
        }
    }
}
