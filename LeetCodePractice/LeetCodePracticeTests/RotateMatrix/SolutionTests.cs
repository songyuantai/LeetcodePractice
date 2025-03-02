using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.RotateMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.RotateMatrix.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int[][] expected = [[7, 4, 1], [8, 5, 2], [9, 6, 3]];
            var solution = new LeetCodePractice.RotateMatrix.Solution();
            solution.Rotate(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], matrix[i][j]);
                }
            }
        }
    }
}