using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace SearchPatterns.Test
{
    [TestClass]
    public class PermutationFixture
    {
        [TestMethod]
        public void CalcShouldReturnYes()
        {
            Assert.AreEqual(Permutations.Lib.CalcPattern("use", "question"), "YES");
        }

        [TestMethod]
        public void CalcShouldThroughAllText()
        {
            Assert.AreEqual(Permutations.Lib.CalcPattern("use", "usgues"), "YES");
        }

        [TestMethod]
        public void CalcShouldReturnNoForUncompletePattern()
        {
            Assert.AreEqual(Permutations.Lib.CalcPattern("use", "sugestion"), "NO");
        }

        [TestMethod]
        public void CalcPatternShouldIgnoreLongPattern()
        {
            Assert.AreEqual(Permutations.Lib.CalcPattern("shortbutverylong", "short"), "NO");
        }
    }
}
