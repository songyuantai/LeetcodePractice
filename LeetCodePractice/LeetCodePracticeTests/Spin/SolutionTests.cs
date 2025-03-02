using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.Spin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Spin.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SpiralOrderTest()
        {
            Solution solution = new();
            int[][] data = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            var spinArray = solution.SpiralOrder(data);
            int[] expected = [1, 2, 3, 6, 9, 8, 7, 4, 5];
            for(int i = 0; i < spinArray.Count; i++)
            {
                Assert.AreEqual(expected[i], spinArray[i]);
            }
        }
    }
}