using Xunit;
using TwoSumLib;
using System.Linq;

namespace TwoSumTests {
    public class SolutionTests {
        [Theory]
        [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
        [InlineData(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
        [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
        public void TwoSum_FindsCorrectIndices(int[] nums, int target, int[] expected) {
            var solution = new Solution();
            var result = solution.TwoSum(nums, target);
            Assert.True(result.OrderBy(x => x).SequenceEqual(expected.OrderBy(x => x)), "Indices do not match expected values");
        }
    }
}
