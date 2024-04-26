using System;
using System.Collections.Generic;

namespace PrefixLib 
{
    public class Solution 
    {
        public string LongestCommonPrefix(string[] strs) 
        {
            //return VerticalScanning(strs);
            return "zzz";
        }
    
        public string HorozontalScanning(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) return "";
                }
            }
            return prefix;
        }
    
        public string VerticalScanning(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length ; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j ++) 
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);             
                }
            }
            return strs[0];
        }
    }
}

