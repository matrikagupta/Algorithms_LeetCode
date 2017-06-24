using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _238_ProductOfArrayExceptSelf
        {
        public int[] ProductExceptSelf(int[] nums)
            {
            int[] arr = new int[nums.Length];

            // forward
            int prod = 1;
            for (int i = 0; i < nums.Length; i++)
                {
                prod *= nums[i];
                arr[i] = prod;
                }

            // backwards
            prod = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
                {
                if (i > 0)
                    arr[i] = prod * arr[i - 1];
                else
                    arr[i] = prod * 1;
                prod *= nums[i];
                }

            return arr;
            }
        //public static void Main()
        //    {

        //    _238_ProductOfArrayExceptSelf obj = new _238_ProductOfArrayExceptSelf();
        //    int[] a = new int[] { 5, 4, 3, 2 };
        //    obj.ProductExceptSelf(a);
        //    }
        }
    }
