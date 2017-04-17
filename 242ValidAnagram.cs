using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _242ValidAnagram
        {
        public bool IsAnagram(string s, string t)
            {
            int[] alphabet = new int[26];
            foreach (var item in s.ToCharArray())
                {
                alphabet[item - 'a']++;
                }
            foreach (var item in t.ToCharArray())
                {
                if (alphabet[item - 'a'] == 0)
                    return false;
                alphabet[item - 'a']--;
                }
            return true;
            }
        }
    }
