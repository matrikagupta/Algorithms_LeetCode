using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _191_Numberof1Bits
        {

        public int HammingWeight(uint n)
            {
            int ones = 0;
            while (n != 0)
                {
                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
                //var res = n & 1;
                //Console.WriteLine(Convert.ToString(res, 2).PadLeft(8, '0'));

                //performing and operation 
                // if n=25 then binary value for this is 00011001
                //now if we perfrom AND operation with 1
                //00011001
                //00000001
                //---------
                //00000001
                //after that shift rigth n value by 1 ,00001100 this value will become
                //keep on doing untill it becomes 0

                ones = ones +Convert.ToInt32 (n & 1);
                n = n >> 1;
                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
                }
            return ones;
            }
        //public static void Main()
        //    {
        //    _191_Numberof1Bits s = new _191_Numberof1Bits();

        //    s.HammingWeight(11);
        //    }
        }
    }

    
