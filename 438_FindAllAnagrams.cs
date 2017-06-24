using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _438_FindAllAnagrams
        {
        public IList<int> FindAnagrams(string s, string p)
            {
            int[] chars = new int[26];
            List<int> result = new List<int>();
            if (s == null || p == null || s.Length < p.Length)
                return result;
            //intializing all p values with 1 and rest with 0
            foreach (char c in p.ToCharArray())
                chars[c - 'a']++;

            int start = 0, end = 0, count = p.Length;
            // Go over the string
            while (end < s.Length)
                {
                // If the char at start appeared in p, we increase count
                if (chars[s[end] - 'a'] >= 1)
                    count--;
                // if char is from p value will become 0 and if char is not from p it will become -1
                chars[s[end] - 'a']--;
                end++; //increase end
                if (count == 0)
                    result.Add(start); //window size exhausted coz the p string is found so add to the results
                //this condition to gain the window size again which was exhausted
                if (end - start == p.Length)
                    {
                    if (chars[s[start] - 'a'] >= 0)
                        count++;
                    chars[s[start] - 'a']++;//p value will again set to 1
                    start++; //by increasing the start leaving one cell from window
                    }
                }
            return result;
            }

       
        }
    }
