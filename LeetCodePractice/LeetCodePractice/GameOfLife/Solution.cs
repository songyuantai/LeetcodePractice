using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.GameOfLife
{
    public class Solution
    {
        public void GameOfLife(int[][] board)
        {
            int[][] status = new int[board.Length][];
            for (int i = 0; i < board.Length; i++) {
                status[i] = new int[board[0].Length];
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Update(j, i, board, status);
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = status[i][j];
                }
            }
        }

        private void Update(int x, int y, int[][] board, int[][] status)
        {
            //左上
            var topLeftX = x - 1;
            var topLeftY = y - 1;

            //上
            var topX = x;
            var topY = y - 1;

            //右上
            var topRitghtX = x + 1;
            var topRightY = y - 1;

            //左
            var letfX = x - 1;
            var leftY = y;

            //右
            var rightX = x + 1;
            var rightY = y;

            //左下
            var bottomLeftX = x - 1;
            var bottomLeftY = y + 1;

            //下
            var bottomX = x;
            var bottomY = y + 1;

            //右下
            var bottomRightX = x + 1;
            var bootomRightY = y + 1;

            int alive = 0;

            SetLifeValue(topLeftX, topLeftY, board, ref alive);
            SetLifeValue(topX, topY, board, ref alive);
            SetLifeValue(topRitghtX, topRightY, board, ref alive);

            SetLifeValue(letfX, leftY, board, ref alive);
            SetLifeValue(rightX, rightY, board, ref alive);

            SetLifeValue(bottomLeftX, bottomLeftY, board, ref alive);
            SetLifeValue(bottomX, bottomY, board, ref alive);
            SetLifeValue(bottomRightX, bootomRightY, board, ref alive);

            if(board[y][x] == 1)
            {
                if (alive < 2)
                {
                    status[y][x] = 0;
                }
                else if (alive == 2 || alive == 3)
                {
                    status[y][x] = 1;
                }
                else
                {
                    status[y][x] = 0;
                }
            } else
            {
                if(alive == 3)
                {
                    status[y][x] = 1;
                }
            }


        }

        private void SetLifeValue(int x, int y, int[][] board, ref int count)
        {
            //碰到边界
            if (x < 0 || x > board[0].Length - 1)
            {
                return;
            }

            if (y < 0 || y > board.Length - 1)
            {
                return;
            }

            count += board[y][x];
        }


    }
}
