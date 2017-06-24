using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _12_IntegerToRoman
        {

        public string ConvertToTitle(int n)
            {

            List<char> list = new List<char>();

            while (n > 0)
                {
                n--;
                list.Add((char)('A' + n % 26));
                n /= 26;
                }

            list.Reverse();
            return new string(list.ToArray());


            }

      
        public int TitleToNumber(string s)
            {
            int sum = 0;
            for (int i = s.Length - 1; i >= 0; i--)
                {
                //convert character into a corresponding number.
                int temp = (int)(s[i] - 'A') + 1;
                sum += temp *(int) Math.Pow(26,s.Length-1-i);
                }
            return sum;

            }

        public string IntToRoman(int num)
            {
          
            
            string []M={ "", "M", "MM", "MMM" };
            string []C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string []X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string []I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
            
          
            }

       
        
    }
    }
