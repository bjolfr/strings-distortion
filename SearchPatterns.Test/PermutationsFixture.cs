﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace SearchPatterns.Test
{
    [TestClass]
    public class PermutationsFixture
    {
        [TestMethod]
        public void CalcShouldReturnYes()
        {
            Assert.AreEqual(Lib.CalcPattern("use", "question"), "YES");
        }

        [TestMethod]
        public void CalcShouldThroughAllText()
        {
            Assert.AreEqual(Lib.CalcPattern("use", "usgues"), "YES");
        }

        [TestMethod]
        public void CalcShouldReturnNoForUncompletePattern()
        {
            Assert.AreEqual(Lib.CalcPattern("use", "sugestion"), "NO");
        }

        [TestMethod]
        public void CalcPatternShouldIgnoreLongPattern()
        {
            Assert.AreEqual(Lib.CalcPattern("shortbutverylong", "short"), "NO");
        }
    }
}
