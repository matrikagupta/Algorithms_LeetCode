using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _476_FindComplement
        {
        //Given a positive integer, output its complement number.The complement strategy
        //is to flip the bits of its binary representation.
        public int FindComplement(int num){
            string binary = Convert.ToString(num, 2);
            string b = string.Empty;
            foreach (Char c in binary){
                if (c == '0')
                    {
                    b += "1";
                    }
                else
                    { b += "0"; }
                }
            num = Convert.ToInt32(b, 2);
            return num;
            }
        }
    }
