import pytest
from solution import Solution

def test_longest_common_prefix():
    sol = Solution()
    assert sol.longest_common_prefix(["flower", "flow", "flight"]) == "fl"
    assert sol.longest_common_prefix(["dog", "racecar", "car"]) == ""
    assert sol.longest_common_prefix(["interspecies", "interstellar", "interstate"]) == "inters"
    assert sol.longest_common_prefix([""]) == ""
    assert sol.longest_common_prefix(["a"]) == "a"
