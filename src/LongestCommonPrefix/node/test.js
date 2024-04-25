const Solution = require('./solution');

describe('Solution', () => {
    const solution = new Solution();

    test('finds the longest common prefix', () => {
        expect(solution.longestCommonPrefix(["flower", "flow", "flight"])).toBe("fl");
        expect(solution.longestCommonPrefix(["dog", "racecar", "car"])).toBe("");
        expect(solution.longestCommonPrefix(["interspecies", "interstellar", "interstate"])).toBe("inters");
        expect(solution.longestCommonPrefix([""])).toBe("");
        expect(solution.longestCommonPrefix(["a"])).toBe("a");
    });
});
