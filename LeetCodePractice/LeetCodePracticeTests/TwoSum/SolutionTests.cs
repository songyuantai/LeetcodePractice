namespace LeetCodePractice.TwoSum.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] nums = [2, 7, 11, 15];
            var target = 9;
            var result = new Solution().TwoSum(nums, target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}