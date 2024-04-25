using System;
using Xunit;
using TwoSumLib;

namespace TwoSumTests {
    public class SolutionTests {
        [Theory]
        [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {1, 0})] // Adjusted expected output for 0-based index
        [InlineData(new int[] {3, 2, 4}, 6, new int[] {2, 1})]
        [InlineData(new int[] {3, 3}, 6, new int[] {1, 0})]
        public void TwoSum_FindsCorrectIndices(int[] nums, int target, int[] expected) {
            var solution = new Solution();
            var result = solution.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
    }
}

