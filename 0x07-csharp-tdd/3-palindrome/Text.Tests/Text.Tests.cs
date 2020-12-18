using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("A man, a plan, a canal: Panama.")]
        [TestCase("121")]
        [TestCase("1 2 1")]
        [TestCase("pazzap")]
        [TestCase("a-b-a-b-a")]
        public void IsPalindrome_IsTrue(string s)
        {
            Assert.IsTrue(Text.Str.IsPalindrome(s));
        }

        [TestCase("Si la luna suave se desliza")]
        [TestCase("Por cualquier corniza")]
        [TestCase("Sin permiso alguno.")]
        [TestCase("Why el mojado precisa")]
        public void IsPalindrome_IsFalse(string s)
        {
            Assert.IsFalse(Text.Str.IsPalindrome(s));
        }
    }
}
