class Solution:
    def longest_common_prefix(self, strs):
        return "zzz"
        # if not strs:
        #     return ""
        
        # # Start by assuming the first string is the common prefix
        # prefix = strs[0]
        # for s in strs[1:]:
        #     # Adjust the prefix until it matches the beginning of each string
        #     while not s.startswith(prefix):
        #         prefix = prefix[:-1]
        #         if not prefix:
        #             return ""
        # return prefix
