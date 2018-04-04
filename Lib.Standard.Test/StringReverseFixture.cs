using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.Standard.Test
{
    [TestClass]
    public class StringReverseFixture
    {
        [TestMethod]
        public void StringShouldBeReversed()
        {
            char[] input = { 'A','R','G','E','N','T','I','N','A' };
            char[] output = { 'A', 'N', 'I', 'T', 'N', 'E', 'G', 'R', 'A' };
            Assert.AreEqual(output.ToString(), Strings.ReverseCharArray(input).ToString());
        }
    }
}
