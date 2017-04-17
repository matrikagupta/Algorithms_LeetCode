using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _485_MaxConsecutiveOnes
        {

        public int FindMaxConsecutiveOnes(int[] nums)
            {
            int currentlen = 0;
            int maxlen = 0;
            for (int i = 0; i < nums.Length; i++)
                {
                if (nums[i] == 1)
                    currentlen++;
                else
                    currentlen = 0;

                if (currentlen > maxlen)
                    maxlen = currentlen;
                }

            return maxlen;
            }
        }
    }
