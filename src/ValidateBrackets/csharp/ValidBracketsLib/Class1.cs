using System;
using System.Collections.Generic;

namespace ValidBracketsLib {
    public class Solution {
        public bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> matchingBracket = new Dictionary<char, char> {
                { '}', '{' },
                { ')', '(' },
                { ']', '[' }
            };

            foreach (char c in s) {
                if (matchingBracket.ContainsValue(c)) {
                    stack.Push(c);
                } else if (stack.Count == 0 || stack.Peek() != matchingBracket[c]) {
                    return false;
                } else {
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}

