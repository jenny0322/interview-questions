using System;

namespace WaterLib
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0, left = 0, right = height.Length - 1;
            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, minHeight * (right - left));

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}
