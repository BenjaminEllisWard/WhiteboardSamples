using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class LongestSubstringBetter
    {
        // Given a string, find the length of the longest substring without repeating a character.
        // Ex: "abcabcbb" => "abc", "bbbbb" => "b", "pwwkew" => "wke"

        public static int GetLongestSub(string s)
        {
            if (s == null) return 0;

            int l = s.Length;

            HashSet<char> set = new HashSet<char>();

            int ans = 0, i = 0, j = 0;

            while (i < l && j < l)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }
            }
            return ans;
        }
    }
}
