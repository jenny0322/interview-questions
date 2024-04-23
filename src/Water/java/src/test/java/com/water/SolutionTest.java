package com.water;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class SolutionTest {
    @Test
    public void testMaxArea() {
        Solution solution = new Solution();

        assertEquals(49, solution.maxArea(new int[]{1,8,6,2,5,4,8,3,7}));
        assertEquals(1, solution.maxArea(new int[]{1,1}));
        assertEquals(16, solution.maxArea(new int[]{4,3,2,1,4}));
        assertEquals(2, solution.maxArea(new int[]{1,2,1}));
        assertEquals(17, solution.maxArea(new int[]{2,3,4,5,18,17,6}));
    }
}

