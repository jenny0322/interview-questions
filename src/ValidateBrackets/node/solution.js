class Solution {
    isValid(s) {
        const stack = [];
        const brackets = {
            ')': '(',
            '}': '{',
            ']': '['
        };

        for (let char of s) {
            if (brackets[char]) {
                if (stack.pop() !== brackets[char]) {
                    return false;
                }
            } else {
                stack.push(char);
            }
        }
        return stack.length === 0;
    }
}

module.exports = Solution;

