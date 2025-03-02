using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.RotateMatrix
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for(int j = i; j < matrix[i].Length; j++)
                {
                    //交换值
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = matrix[i].Reverse().ToArray();
            }
        }
    }
}
