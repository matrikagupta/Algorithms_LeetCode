using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _167_TwoSum_InputArraySorted
        {
        public int[] TwoSum(int[] numbers, int target)
            {

            int start = 0, end = numbers.Length - 1;
            while (start < end)
                {
                if (numbers[start] + numbers[end] == target) break;
                if (numbers[start] + numbers[end] < target) start++;
                else end--;
                }
            return new int[] { start + 1, end + 1 };
            }
        }
    }
