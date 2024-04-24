const Solution = require('./solution');

describe('Solution', () => {
    test('finds maximum water area', () => {
        const solution = new Solution();
        expect(solution.maxArea([1,8,6,2,5,4,8,3,7])).toBe(49);
        expect(solution.maxArea([1,1])).toBe(1);
        expect(solution.maxArea([4,3,2,1,4])).toBe(16);
        expect(solution.maxArea([1,2,1])).toBe(2);
        expect(solution.maxArea([2,3,10,5,7,8,9])).toBe(36);
    });
});
