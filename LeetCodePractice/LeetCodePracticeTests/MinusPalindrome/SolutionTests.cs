using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.MinusPalindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.MinusPalindrome.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinCutTest()
        {
            Solution solution = new();

            Assert.AreEqual(1, solution.MinCut("aab"));
            Assert.AreEqual(0, solution.MinCut("efe"));
            Assert.AreEqual(1, solution.MinCut("abbab"));
            Assert.AreEqual(1, solution.MinCut("aaabaa"));
            //Assert.AreEqual(1, solution.MinCut("eegiicgaeadbcfacfhifdbiehbgejcaeggcgbahfcajfhjjdgj"));
            
        }
    }
}