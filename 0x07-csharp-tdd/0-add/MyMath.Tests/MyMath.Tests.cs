using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        public void AddNumbers_ReturnsCorrectly(int a, int b)
        {
            Assert.AreEqual(MyMath.Operations.Add(a, b), a + b);
        }
    }
}
