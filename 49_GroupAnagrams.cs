using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _49_GroupAnagrams
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
        //static void Main(string[] args)
        //    {
        //    _49_GroupAnagrams obj = new _49_GroupAnagrams();
        //    string[] s = new string[] { "eat","aet","tan","nat","bat"};
        //    obj.GroupAnagrams(s); 

        //    }
        }
    }
