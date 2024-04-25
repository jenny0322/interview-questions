class Solution:
    def two_sum(self, nums, target):
        num_map = {}
        for i, num in enumerate(nums):
            complement = target - num
            if complement in num_map:
                return [num_map[complement], i]
            num_map[num] = i
        raise ValueError("No two sum solution found")

