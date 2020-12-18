using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OrderedList_ReturnsMax()
        {
            List<int> lili = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };

            Assert.AreEqual(7, MyMath.Operations.Max(lili));
        }

        [Test]
        public void NegativeOrderedList_ReturnsMax()
        {
            List<int> lili = new List<int> { -5, -4, -3, -2, -1 };

            Assert.AreEqual(-1, MyMath.Operations.Max(lili));
        }

        [Test]
        public void SameNumbersList_ReturnsSameNumber()
        {
            List<int> lili = new List<int>() { 10, 10, 10, 10, 10};

            Assert.AreEqual(10, MyMath.Operations.Max(lili));
        }

        [Test]
        public void NullList_ReturnsZero()
        {
            List<int> lili = null;

            Assert.AreEqual(0, MyMath.Operations.Max(lili));
        }

        [Test]
        public void EmptyList_ReturnsZero()
        {
            List<int> lili = new List<int>();

            Assert.AreEqual(0, MyMath.Operations.Max(lili));
        }
    }
}
