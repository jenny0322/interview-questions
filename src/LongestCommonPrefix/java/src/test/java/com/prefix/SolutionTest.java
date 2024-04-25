package com.prefix;

import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.Test;

public class SolutionTest {
    @Test
    public void testLongestCommonPrefix() {
        Solution solution = new Solution();

        assertEquals("fl", solution.longestCommonPrefix(new String[] {"flower", "flow", "flight"}),
                     "Test failed with input: [\"flower\", \"flow\", \"flight\"]");

        assertEquals("", solution.longestCommonPrefix(new String[] {"dog", "racecar", "car"}),
                     "Test failed with input: [\"dog\", \"racecar\", \"car\"]");

        assertEquals("inters", solution.longestCommonPrefix(new String[] {"interspecies", "interstellar", "interstate"}),
                     "Test failed with input: [\"interspecies\", \"interstellar\", \"interstate\"]");
    }
}
