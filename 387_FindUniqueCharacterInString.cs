using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _387_FindUniqueCharacterInString
        {
        public int FirstUniqChar(String s)
            {
            Dictionary<char, int> lst = new Dictionary<char, int>();
            foreach (char c in s)
                {
                if (!lst.ContainsKey(c))
                    lst.Add(c, 1);
                else
                    lst[c] += 1;
                }
            int i = 0;
            foreach (char c in s)
                {
                if (lst[c] == 1)
                    return i;
                else
                    i++;
                }
            return -1;

            }
        }
    }
