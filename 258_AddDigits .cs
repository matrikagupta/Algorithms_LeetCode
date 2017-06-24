using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _258_AddDigits
        {

        public int AddDigits(int num)
            {
            if (num == 0)
                return 0;
            else
                if (num % 9 == 0)
                return 9;
            else
                return num % 9;
            }


        //public static void Main()
        //    {
        //    _258_AddDigits obj = new _258_AddDigits();
        //    obj.AddDigits(154);

         
        //    }
        }
    }
