using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Spin
{
    public class Solution
    {


        public IList<int> SpiralOrder(int[][] matrix)
        {
            //0,0 0,1 0,2 1,2 2,2 2,1, 2,0 1,0 1,1
            HashSet<string> postions = [];
            List<int> result = [];
            int x = 0;
            int y = 0;
            MoveRight(ref x, ref y, postions, result, matrix);
            return result;

        }

        private void Eat(int x, int y, HashSet<string> postions, List<int> result, int[][] matrix)
        {
            var positionKey = $"{x},{y}";
            if(!postions.Contains(positionKey))
            {
                result.Add(matrix[y][x]);
                postions.Add(positionKey);
            }
        }

        private void MoveRight(ref int x, ref int y, HashSet<string> postions, List<int> result, int[][] matrix)
        {
            Eat(x, y, postions, result, matrix);
            if (matrix[0].Length * matrix.Length == postions.Count)
            {
                return;
            }

            var positionKey = $"{x+1},{y}";
            if (postions.Contains(positionKey) || x + 1 == matrix[0].Length)
            {
                MoveDown(ref x, ref y, postions, result, matrix);
            }
            else
            {
                x++;
                MoveRight(ref x,ref y, postions, result, matrix);
            }
        }

        private void MoveDown(ref int x, ref int y, HashSet<string> postions, List<int> result, int[][] matrix)
        {
            Eat(x, y, postions, result, matrix);
            if (matrix[0].Length * matrix.Length == postions.Count)
            {
                return;
            }

            var positionKey = $"{x},{y + 1}";
            if (postions.Contains(positionKey) || y + 1 == matrix.Length)
            {
                MoveLeft(ref x, ref y, postions, result, matrix);
            }
            else
            {
                y++;
                MoveDown(ref x, ref y, postions, result, matrix);
            }
        }

        private void MoveLeft(ref int x, ref int y, HashSet<string> postions, List<int> result, int[][] matrix)
        {
            Eat(x, y, postions, result, matrix);
            if (matrix[0].Length * matrix.Length == postions.Count)
            {
                return;
            }

            var positionKey = $"{x - 1},{y}";
            if (postions.Contains(positionKey) || x == 0)
            {
                MoveTop(ref x, ref y, postions, result, matrix);
            }
            else
            {
                x--;
                MoveLeft(ref x, ref y, postions, result, matrix);
            }
        }

        private void MoveTop(ref int x, ref int y, HashSet<string> postions, List<int> result, int[][] matrix)
        {
            Eat(x, y, postions, result, matrix);
            if (matrix[0].Length * matrix.Length == postions.Count)
            {
                return;
            }

            var positionKey = $"{x},{y - 1}";
            if (postions.Contains(positionKey) || y == 0)
            {
                MoveRight(ref x, ref y, postions, result, matrix);
            }
            else
            {
                y--;
                MoveTop(ref x, ref y, postions, result, matrix);
            }
        }

    }
}
