using Xunit;
using PrefixLib;

namespace PrefixTests {
    public class SolutionTests {
        [Theory]
        [InlineData(new string[] {"flower", "flow", "flight"}, "fl")]
        [InlineData(new string[] {"dog", "racecar", "car"}, "")]
        [InlineData(new string[] {"interspecies", "interstellar", "interstate"}, "inters")]
        [InlineData(new string[] {"throne", "throne"}, "throne")]
        [InlineData(new string[] {""}, "")]
        [InlineData(new string[] {"a"}, "a")]
        public void TestLongestCommonPrefix_VerticalScanning(string[] strs, string expected) {
            var solution = new Solution();
            var result = solution.VerticalScanning(strs);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new string[] {"flower", "flow", "flight"}, "fl")]
        [InlineData(new string[] {"dog", "racecar", "car"}, "")]
        [InlineData(new string[] {"interspecies", "interstellar", "interstate"}, "inters")]
        [InlineData(new string[] {"throne", "throne"}, "throne")]
        [InlineData(new string[] {""}, "")]
        [InlineData(new string[] {"a"}, "a")]
        public void TestLongestCommonPrefix_HorizontalScanning(string[] strs, string expected) {
            var solution = new Solution();
            var result = solution.HorozontalScanning(strs);
            Assert.Equal(expected, result);
        }
    }
}
