using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return nums;
        }

        [Fact]
        public void Test()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var expected = new[] { 1, 2, 3, 4 };
            Assert.Equal(expected, RunningSum(nums));
        }
    }
}
