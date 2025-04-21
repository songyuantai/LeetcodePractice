namespace LeetCodePractice.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //通用解法
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target) return [i, j];
            //    }
            //}

            //数组值不重复前提下的解法
            var dic = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {

                var value = target - nums[index];
                if (dic.ContainsKey(nums[index]))
                    return [dic[nums[index]], index];

                dic[value] = index;
            }


            return [-1, -1];
        }

    }
}
