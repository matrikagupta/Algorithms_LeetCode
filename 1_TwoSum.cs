using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _1_TwoSum
        {
        public int[] twoSum(int[] nums, int target)
            {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                {
                var aim = target - nums[i]; //check aim value in dictionary
                if (dict.ContainsKey(aim))
                    {
                    return new int[] { dict[aim], i }; //return value from dictionary and current index of array number
                    }
                else
                    {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i); //add number as key and its index as value
                    }
                }
            return null;
            }



        }



    class Program
    {

       static void Main(string[] args)
       {
           int[] a = { 3,5,3,2,7,3, 15 };
           int target = 5; 
           _1_TwoSum obj = new _1_TwoSum();
           int[] u = obj.twoSum(a, target);
           Console.WriteLine(string.Join(",", u));
           Console.ReadLine();


       }

    }
    }
