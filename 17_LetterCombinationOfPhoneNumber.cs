using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _17_LetterCombinationOfPhoneNumber
        {
        public IList<string> LetterCombinations(string digits)
            {
            IList<string> res = new List<string>();

            if (digits.Length == 0)
                return res;
            string[] charmap = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            res.Add("");
            //this loop will run for number of digits for eg for the given string "23", loop will run 2 times
            for (int i = 0; i < digits.Length; i++)
                {
                //creating temp list for storing combination for characters
                IList<string> tempres = new List<string>();
                //get the characters for given digit for eg. 2 total chars "abc"
                string chars = charmap[digits[i] - '0'];
                //this loop run for the number of chars for the given digit for eg. digit-2 char "abc" 
                // loop will run 3 times in this case
                for (int c = 0; c < chars.Length; c++)
                    //this loop will run for the number of chars in the res
                    for (int j = 0; j < res.Count; j++)
                        tempres.Add(res[j] + chars[c]); //adding res chars and new chars a+d b+d c+d, a+e b+e c+e, a+f b+f c+f  
                res = tempres;
                }
            return res;
            }


        public static void Main()
           {
           _17_LetterCombinationOfPhoneNumber obj = new _17_LetterCombinationOfPhoneNumber();
             obj.LetterCombinations("23");
           }
        }
    }
