using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void Divide_WithOne()
        {
            int[,] matrix = new int[,] {
                {0, 1, 2},
                {0, 1, 2}
            };

            int [,] res = MyMath.Matrix.Divide(matrix, 1);

            int[,] verifyRes = new int[,] {
                {0, 1, 2},
                {0, 1, 2},
            };

            Assert.AreEqual(res, verifyRes);
        }

        [TestCase]
        public void Divide_WithZero()
        {
            int[,] matrix = new int[,] {
                {0, 1, 2},
                {0, 1, 2}
            };

            int [,] res = MyMath.Matrix.Divide(matrix, 0);

            int[,] verifyRes = null;

            Assert.AreEqual(res, verifyRes);
        }

        [TestCase]
        public void Divide_ZeroFilledMatrix()
        {
            int[,] matrix = new int[,] {
                {0, 0, 0},
                {0, 0, 0}
            };

            int [,] res = MyMath.Matrix.Divide(matrix, 0);

            int[,] verifyRes = null;

            Assert.AreEqual(res, verifyRes);
        }

        [TestCase]
        public void Divide_NullMatrix()
        {
            int[,] matrix = null;

            int [,] res = MyMath.Matrix.Divide(matrix, 0);

            int[,] verifyRes = null;

            Assert.AreEqual(res, verifyRes);
        }
    }
}
