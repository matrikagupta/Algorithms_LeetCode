using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _448_FindAllNumbersDisapperedinArray
        {


        // Given an array of integers where 1 ≤ a[i] ≤ n(n = size of array), some elements appear 
        //twice and others appear once.
        //Find all the elements of [1, n] inclusive that do not appear in this array.
        //Could you do it without extra space and in O(n) runtime? 
        //You may assume the returned list does not count as extra space.
        public IList<int> FindDisappearedNumbers(int[] nums)
            {
            HashSet<int> hasnewlist = new HashSet<int>();

            for (int i = 1; i <= nums.Length; i++)
                {
                hasnewlist.Add(i);
                }
            if (nums == null || nums.Length > 0)
                {

                foreach (int item in nums)
                    {
                    if (hasnewlist.Contains(item))
                        {
                        hasnewlist.Remove(item);
                        }
                    }
                }
            return hasnewlist.ToList();

            }
        }
    }
