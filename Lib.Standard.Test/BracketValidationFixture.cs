using System;
using Lib.Standard.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.Standard.Test
{
    [TestClass]
    public class BracketValidationFixture
    {
        [TestMethod]
        public void BracketValudationShouldReturnsTrue()
        {
            string[] list = { "()(([]))", "()(([])){}" };
            foreach (var input in list) {
                Assert.IsTrue(new CharStream(input).IsValid());
                Assert.IsTrue(new CharStream(input).IsValid1()); }
        }

        [TestMethod]
        public void BracketValudationShouldReturnsFalse()
        {
            var list = new string[] { "(]", "()[}", "()}"};
            foreach (var input in list) {
                Assert.AreEqual(false, new CharStream(input).IsValid());
                Assert.AreEqual(false, new CharStream(input).IsValid1()); }
        }
    }
}
