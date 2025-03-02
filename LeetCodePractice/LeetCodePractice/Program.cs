using LeetCodePractice.Spin;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            int[][] arr = [[1,2, 3], [4, 5, 6], [7, 8, 9]];
            solution.SpiralOrder(arr);
            Console.WriteLine("Hello, World!");
        }
    }
}
