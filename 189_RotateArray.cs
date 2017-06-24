using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _189_RotateArray
        {

        public void Rotate(int[] nums, int k)
            {
            //if length of k is greater than length of nums then k%nums.Length will reduce the value of k
            //coz of that start and end value will become equal and no reversing will be performed
            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);

            }

        public void reverse(int[] nums, int start, int end)
            {
            int temp = 0;
            while (start < end)
                {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                end--;
                start++;
                }
            }

        //public static void Main()
        //    {
        //    _189_RotateArray obj = new _189_RotateArray();
        //    int[] a = { 1, 2 };
        //    obj.Rotate(a,3);
        //    }
        }
    }
