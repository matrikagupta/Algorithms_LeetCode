using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _239_SlidingWindowMaximum
        {
      

        //brute force method with O(n*k) time complexity
        public int[] MaxSlidingWindow(int[] nums, int k)
            {
            int[] max = new int[nums.Length - k+1];
            int maxval;
            if (nums.Length <= 1)
                return nums;
            for (int i = 0; i < nums.Length; i++)
                {
                maxval = nums[i];
                if (i + k == nums.Length + 1)
                    break;
                else
                    {
                    for (int j = i; j < k+i-1 ; j++)
                        {
                        maxval = Math.Max(nums[j+1], maxval);
                        }
                    max[i] = maxval;

                    }

                }
            return max;
            }

        // time complexity O(n)
        public int[] MaxSlidingWindow_2(int[] nums, int k)
            {
            if (nums == null || nums.Length== 0 || k <= 0)
                return nums;
            List<int> result = new List<int>();
            LinkedList<int> ll = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
                {
                //check if linkedlist has any elements, linkedlist first value having index should be in the range of k
                // if k =3 and first value index in linkedlist is 1 and values of i =4, meaning 4-3=1 
                //which is not less than first value of linkedlist
                // so remove it coz it is out size 3 window
                if (ll.Any() && ll.First.Value <= i - k)
                    {
                    ll.RemoveFirst();
                    }
                /*if array new element is greater than exisiting element in the linkedlist
                    remove all the elements untill new element is smaller than the element already in
                    the linkedlist*/
                while (ll.Any() && nums[ll.Last.Value] <= nums[i])
                    {
                    ll.RemoveLast();
                    }
                //add the new element into the linkedlist
                ll.AddLast(i);
                //add element into the result if window size is reached for getting the max value 
                if (i - k + 1 >= 0)
                    result.Add(nums[ll.First.Value]);
                }
            return result.ToArray();
            }

        //public static void Main()
        //    {
        //    _239_SlidingWindowMaximum obj = new _239_SlidingWindowMaximum();
        //    int[] nums = { 1,3,1,-3,5,3,4,2};
        //    obj.MaxSlidingWindow_2(nums,3);
        //    }
        }
    }
