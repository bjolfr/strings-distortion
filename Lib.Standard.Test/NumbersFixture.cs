using Lib.Standard.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.Standard.Test
{
    [TestClass]
    public class NumbersFixture
    {
        [TestMethod]
        public void DoubleArrayOfSameElementShouldReturnsRight()
        {
            int[] input = { 2, 2, 0, 0, 4, 8, 0 };
            int[] output = { 4, 4, 8, 0, 0, 0, 0 };
            var sut = Numbers.DoubleArrayOfSameElements(input);
            Assert.IsTrue(new ArrayComparer<int>().Equals(output, sut));

            input = new int[] { 1, 1, 2, 2, 0, 3, 5, 0, 0, 1 };
            output = new int[] { 2, 4, 3, 5, 1, 0, 0, 0, 0, 0 };
            sut = Numbers.DoubleArrayOfSameElements(input);
            Assert.IsTrue(new ArrayComparer<int>().Equals(output, sut), "Number at last element");

            input = new int[] { 1, 1, 2, 2, 0, 3, 3, 0, 1, 1 };
            output = new int[] { 2, 4, 6, 2, 0, 0, 0, 0, 0, 0 };
            sut = Numbers.DoubleArrayOfSameElements(input);
            Assert.IsTrue(new ArrayComparer<int>().Equals(output, sut), "Double at last element");
        }
    }
}
