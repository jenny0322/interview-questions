using Xunit;
using WaterLib;

namespace WaterTests {
    public class SolutionTests {
        [Theory]
        [InlineData(new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7}, 49)]
        [InlineData(new int[] {1, 1}, 1)]
        [InlineData(new int[] {4, 3, 2, 1, 4}, 16)]
        [InlineData(new int[] {1, 2, 1}, 2)]
        [InlineData(new int[] {2, 3, 10, 5, 7, 8, 9}, 36)]
        public void MaxArea_ReturnsCorrectValue(int[] height, int expected) {
            var solution = new Solution();
            var result = solution.MaxArea(height);
            Assert.Equal(expected, result);
        }
    }
}
