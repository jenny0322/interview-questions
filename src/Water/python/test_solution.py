import pytest
from solution import Solution

def test_max_area():
    sol = Solution()

    # Test cases
    assert sol.maxArea([1,8,6,2,5,4,8,3,7]) == 49, "Test case [1,8,6,2,5,4,8,3,7] should return 49"
    assert sol.maxArea([1,1]) == 1, "Test case [1,1] should return 1"
    assert sol.maxArea([4,3,2,1,4]) == 16, "Test case [4,3,2,1,4] should return 16"
    assert sol.maxArea([1,2,1]) == 2, "Test case [1,2,1] should return 2"
    assert sol.maxArea([2,3,4,5,18,17,6]) == 17, "Test case [2,3,4,5,18,17,6] should return 17"
