using System;
using System.Collections;


namespace TwoSumLib 
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {        
            Hashtable ht = new Hashtable();
            
            for (int i = 0; i < nums.Length; i++) 
            {
                int compliment = target - nums[i];
                if (ht.ContainsKey(compliment))
                {
                    int index = (int)ht[compliment];
                    return new int[]{i, index};
                }
                ht.Add(nums[i], i);
            }
            
            throw new ArgumentException("No two sum solution");
        }
    }
}