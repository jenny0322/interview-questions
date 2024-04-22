package com.validatebrackets;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;
import org.junit.Test;

public class SolutionTest {
    @Test
    public void testIsValid() {
        Solution solution = new Solution();
        
        // Test case 1
        assertTrue("Expected true for empty string", solution.isValid(""));
        // Test case 2
        assertTrue("Expected true for ()", solution.isValid("()"));
        // Test case 3
        assertTrue("Expected true for ()[]{}", solution.isValid("()[]{}"));
        // Test case 4
        assertFalse("Expected false for (]", solution.isValid("(]"));
        // Test case 5
        assertFalse("Expected false for ([)]", solution.isValid("([)]"));
        // Test case 6
        assertTrue("Expected true for {[]}", solution.isValid("{[]}"));
    }
}

