using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _387_FindUniqueCharacterInString
        {



        public IList<IList<string>> GroupAnagrams(string[] strs)
            {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (var s in strs)
                {
                var chars = s.ToCharArray();
                Array.Sort(chars);
                var key = new string(chars);
                if (!dict.ContainsKey(key))
                    {
                    dict[key] = new List<string>();
                    }
                dict[key].Add(s);
                }
            return dict.Values.ToList<IList<string>>();


            }
        public int FirstUniqChar(String s)
            {

            IList<string> res = new List<string>();

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
