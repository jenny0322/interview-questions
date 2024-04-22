import pytest
from solution import Solution

def test_is_valid():
    sol = Solution()

    # Test cases
    assert sol.is_valid("()") == True, "Test case () should return True"
    assert sol.is_valid("()[]{}") == True, "Test case ()[]{} should return True"
    assert sol.is_valid("(]") == False, "Test case (] should return False"
    assert sol.is_valid("([)]") == False, "Test case ([)] should return False"
    assert sol.is_valid("{[]}") == True, "Test case {[]} should return True"
    assert sol.is_valid("") == True, "Empty string should return True"

