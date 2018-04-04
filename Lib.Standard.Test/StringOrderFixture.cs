using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchPatterns.Test
{
    [TestClass]
    public class StringOrderFixture
    {
        [TestMethod]
        public void StringShouldReverseWords()
        {
            var input = "I love you";
            var output = "you love I";
            Assert.AreEqual(output, Lib.Standard.Strings.ReverseWords(input));
        }
    }
}
