using Xunit;

namespace LeetCode_Problems.Array
{
    /**
     * 
     * https://leetcode.com/problems/running-sum-of-1d-array
     * 
     */
    public class P1480RunningSum1DArray : LCProblem
    {
        public override void RunProgram()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var sums = RunningSum(nums);
        }

        public int[] RunningSum(int[] nums)
        {
            int[] sums = new int[nums.Length];
            sums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = nums[i] + sums[i - 1];
            }

            return sums;
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
        public void Test(int[] nums, int[] expected)
        {
            Assert.Equal(expected, RunningSum(nums));
        }
    }
}
