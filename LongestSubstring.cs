using System.Collections.Generic;

namespace LongestSubstring
{
    public class Solution_3
    {
        public int LengthOfLongestSubstring_BF(string s) {
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            HashSet<char> set = new HashSet<char>();
            for (int j = i; j < s.Length; j++) {
                if (set.Contains(s[j])) {
                    break;  // Found a duplicate
                }
                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }

        return maxLength;
    }

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int maxlength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (set.Contains(s[i]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[i]);
                maxlength = Math.Max(maxlength, i - left + 1);
            }
            return maxlength;
        }
    }
}