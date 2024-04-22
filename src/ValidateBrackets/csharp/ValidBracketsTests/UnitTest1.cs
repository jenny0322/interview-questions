using System;
using Xunit;
using ValidBracketsLib;

namespace ValidBracketsTests {
    public class SolutionTests {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        public void TestIsValid(string input, bool expected) {
            var solution = new Solution();
            var result = solution.IsValid(input);
            Assert.Equal(expected, result);
        }
    }
}

