package com.water;

import java.util.Stack;

public class Solution {
    public int maxArea(int[] height) {
        int maxArea = 0;
        int l = 0;
        int r = height.length - 1;

        while (l < r) {
            int currentArea = (r - l) * Math.min(height[l], height[r]);
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

