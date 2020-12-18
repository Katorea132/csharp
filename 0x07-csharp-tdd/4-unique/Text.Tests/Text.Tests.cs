using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("pekorapeko")]
        [TestCase("pekora")]
        [TestCase("pizza")]
        public void HasUniqueChar_ReturnsIndex(string s)
        {
            Assert.True(Text.Str.UniqueChar(s) != -1);
        }

        [TestCase("pekopeko")]
        [TestCase("")]
        [TestCase(null)]
        public void HasNoUniqueChar_ReturnsNegative(string s)
        {
            Assert.True(Text.Str.UniqueChar(s) == -1);
        }
    }
}
