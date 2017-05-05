using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _380_InsertDeleteGetRandom
        {


        Dictionary<int, int> dict;
        Dictionary<int, int> dict2;
     
        /** Initialize your data structure here. */
        public _380_InsertDeleteGetRandom()
            {

            dict = new Dictionary<int, int>();
            dict2 = new Dictionary<int, int>();

            }

       
        public bool Insert(int val)
            {

            if (!dict.ContainsKey(val))
                {
                dict.Add(val,dict.Count);
                dict2.Add(dict2.Count,val);
                return true;
                }
            else
                return false;

            }

        public bool Remove(int val)
            {

            if (dict.ContainsKey(val))
                {
                int index = dict[val];

                dict.Remove(val);
                if (!(dict2.Count - 1 <= index))
                    {
                    dict2[index] = dict2[dict2.Count - 1];
                    dict[dict2[dict2.Count - 1]] = index;
                    }
                dict2.Remove(dict2.Count - 1);
                return true;
                }
            else
                return false;

            }

        /** Get a random element from the set. */
        public int GetRandom()
            {
           
            if (dict.Count == 0)
                {
                return -1;
                }

            if (dict.Count == 1)
                {
                return dict2[0];
                }
            Random r = new Random();
            int random = (r.Next(dict.Count));
            return dict[random];

            }

        //public static void Main()
        //    {
        //    _380_InsertDeleteGetRandom obj = new _380_InsertDeleteGetRandom();
        //    obj.Insert(1);
        //    obj.Insert(10);
        //    obj.Insert(20);
        //    obj.Insert(30);
        //    obj.GetRandom();
        //    obj.GetRandom();
        //    obj.Insert(9);
        //    obj.Insert(10);
        //    obj.Remove(8);
        //    obj.Insert(2);
        //    obj.GetRandom();
        //    obj.Remove(1);
        //    obj.Insert(2);
        //    obj.GetRandom();
        //    }
        }
    }
