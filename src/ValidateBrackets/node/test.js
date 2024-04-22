const Solution = require('./solution');

describe('Solution', () => {
    test('validates the correct bracket sequence', () => {
        const solution = new Solution();
        expect(solution.isValid("()")).toBe(true);
        expect(solution.isValid("()[]{}")).toBe(true);
        expect(solution.isValid("(]")).toBe(false);
        expect(solution.isValid("([)]")).toBe(false);
        expect(solution.isValid("{[]}")).toBe(true);
        expect(solution.isValid("")).toBe(true);  // Empty string should also return true
    });
});

