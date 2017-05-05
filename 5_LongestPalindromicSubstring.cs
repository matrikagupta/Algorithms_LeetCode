using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _5_LongestPalindromicSubstring
        {
        int start = 0; int end = 0;
        string LongestPalindrome(string s)
            {
            int len = s.Length;
            if (len < 2) return s;
            for (int i = 0; i < len - 1; i++)
                {
                extendPalindrome(s, i, i); // assume odd length
                extendPalindrome(s, i, i + 1); // assume even length
                }
            return s.Substring(start, end);
            }


        void extendPalindrome(string s, int left, int right)
            {
            while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                --left;
                ++right;
                }

            if (end < right - left - 1)
                {
                start = left + 1;
                end = right - left - 1;
                }
            }

        //public static void Main()
        //    {
        //    _5_LongestPalindromicSubstring s = new _5_LongestPalindromicSubstring();
        //  string st=  s.LongestPalindrome("maadaamtest");
        //    }
        }
    }
