using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("gawr")]
        [TestCase("gura")]
        [TestCase("gawrGura")]
        [TestCase("inugamiKoroneOkayu")]
        [TestCase("123somebodyOnceToldMeTheWorldWasGonnaRollMe123")]
        public void MoreThanZero_ReturnsSo(string s)
        {
            Assert.True(Text.Str.CamelCase(s) > 0);
        }

        [TestCase("123123123123123123")]
        [TestCase("!@#!@#!@#!@#")]
        [TestCase("")]
        [TestCase(null)]
        public void Zero_ReturnsZero(string s)
        {
            Assert.True(Text.Str.CamelCase(s) == 0);
        }
    }
}
