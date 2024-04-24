class Solution {
    maxArea(height) {
        let l = 0, r = height.length - 1;
        let maxArea = 0;

        while (l < r) {
            const currentArea = (r - l) * Math.min(height[l], height[r]);
            maxArea = Math.max(maxArea, currentArea);

            if (height[l] < height[r]) {
                l++;
            } else {
                r--;
            }
        }

        return maxArea;
    }
}

module.exports = Solution;
