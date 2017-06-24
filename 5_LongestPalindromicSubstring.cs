using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _5_LongestPalindromicSubstring
        {

        string LongestPalindrome(string s)
            {
            int C = 0, R = 0;
            // int[] T = new int[s.Length-1*+1];
            char[] T = new char[s.Length - 1 * +1];

            string str = null;
            foreach (var item in s)
                {
                str += item + "#";

                }
            str = "@#" + str + "$";
            Console.WriteLine(str);
            T = str.ToCharArray();

            int[] p = new int[T.Length];

            for (int i = 0; i < T.Length; i++)
                {
                int mirr = 2 * C - i;
                if (i < R)
                    p[i] = Math.Min(R - i, p[mirr]);
                while (str[i + (1 + p[i])] ==str[i - (1 + p[i])])
                    { p[i]++; }
                if (i + p[i] > R)
                    {
                    C = i;
                    R = i + p[i];

                    }
                }
            int centerIndex = 0, maxLen = 0;
            for (int i = 0; i < p.Length; i++)
                {

                maxLen = Math.Max(p[i], i);
                centerIndex = i;
                }

            return s.Substring((centerIndex - maxLen) / 2, (centerIndex + maxLen) / 2);
            }


        //int start = 0; int end = 0;
        //string LongestPalindrome(string s)
        //    {
        //    int len = s.Length;
        //    if (len < 2) return s;
        //    for (int i = 0; i < len - 1; i++)
        //        {
        //        extendPalindrome(s, i, i); // assume odd length
        //        extendPalindrome(s, i, i + 1); // assume even length
        //        }
        //    return s.Substring(start, end);
        //    }

        ///*extendPalindrome should be O(N),imagine the worst case i = mid,and the input is "aaaaaaa",left pointer
        //keep moving until -1, right pointer keep move until s.length(),
        //one by one,is linear.the complexity is O(N/2)~O(N).*/
        //void extendPalindrome(string s, int left, int right)
        //    {
        //    while (left >= 0 && right < s.Length && s[left] == s[right])
        //        {
        //        --left;
        //        ++right;
        //        }

        //    if (end < right - left - 1)
        //        {
        //        start = left + 1;
        //        end = right - left - 1;
        //        }
        //    }

        //public static void Main()
        //    {
        //    _5_LongestPalindromicSubstring s = new _5_LongestPalindromicSubstring();
        //    string st = s.LongestPalindrome("abababa");
        //    }
        }
    }
