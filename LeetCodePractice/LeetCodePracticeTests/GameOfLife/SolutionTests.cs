using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.GameOfLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.GameOfLife.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GameOfLifeTest()
        {
            int[][] board = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]];
            int[][] expected = [[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 1, 0]];
            var solution = new LeetCodePractice.GameOfLife.Solution();
            solution.GameOfLife(board);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], board[i][j]);
                }
            }
        }
    }
}