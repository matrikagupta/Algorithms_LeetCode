namespace PracticeInterview
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RollingAverageMaximum
        {
        int sum1 = 0;
        int sum2 = 0;
        //method for calculating the averge
        public int Sum(int[] num, int sum, int index, int windowsize)
            {
            if (index <= windowsize - 1)
                return sum += num[index];
            else
                return sum = sum - num[index - windowsize] + num[index];

            }
        //Method for calculating the max
        public string Max(int[] nums, LinkedList<int> ll, int index, int windowsize)
            {
            //linked list storing the index of the array value
            //if first value in the linked list is outside of window then remove it from the linked list
            if (ll.Any() && ll.First.Value <= index - windowsize)
                {
                ll.RemoveFirst();
                }
            //if value of an array is greater than the value in the linked list last added. Keep removing all the elements from the linked list untill no more greater value is left
            while (ll.Any() && nums[ll.Last.Value] <= nums[index])
                {
                ll.RemoveLast();
                }
            //adding index of an array to the linked list
            ll.AddLast(index);
            //returning first element in the linked list if window size is equal to index
            if (index - windowsize + 1 >= 0)
                return Convert.ToString(nums[ll.First.Value]);

            return "None";
            }

        public List<string> CalculateMaxAverage(int[] nums, int w1, int w2)
            {

            string avg1, avg2, max1, max2;
            LinkedList<int> llWindow1 = new LinkedList<int>();
            LinkedList<int> llWindow2 = new LinkedList<int>();
            List<string> result = new List<string>();
            if (nums != null || nums.Length == 0 || w1 > 0 || w2 > 0)
                {
                for (int i = 0; i < nums.Length; i++)
                    {
                    max1 = Max(nums, llWindow1, i, w1);
                    max2 = Max(nums, llWindow2, i, w2);
                    sum1 = Sum(nums, sum1, i, w1);
                    sum2 = Sum(nums, sum2, i, w2);
                    if (i - w1 + 1 >= 0)
                        avg1 = Convert.ToString(sum1 / w1);
                    else
                        avg1 = "None";
                    if (i - w2 + 1 >= 0)
                        avg2 = Convert.ToString(sum2 / w2);
                    else
                        avg2 = "None";

                    result.Add(avg1);
                    result.Add(max1);
                    result.Add(avg2);
                    result.Add(max2);
                    //uncomment below line to print and see results as window is sliding
                    //Console.WriteLine(avg1 + ',' + max1 + ',' + avg2 + ',' + max2);
                    }
                }

            return result;
            }


        public static void Main()
            {
            RollingAverageMaximum ob = new RollingAverageMaximum();
            bool testcase;
            //Test Case1------
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            string[] expected = { "None","None","None","None","None","None","None","None","2","3","None","None","3","4","None","None","4","5","None","None","5","6","None","None","6","7","None","None","7","8","None","None","8","9","None","None","9","10","None","None","10","11","None","None","11","12","None","None","12","13","None","None","13","14","None","None","14","15","None","None","15","16","None","None","16","17","None","None","17","18","None","None","18","19","None","None","19","20","10","20","20","21","11","21","21","22","12","22","22","23","13","23","23","24","14","24","24","25","15","25","25","26","16","26","26","27","17","27","27","28","18","28","28","29","19","29","29","30","20","30"};
              testcase = ob.TestPositive(input,expected);

            //Test Case2------

             input =new int[] {1, 2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
             expected = new string[]{"None","None","None","None","None","None","None","None","2","3","None","None","3","4","None","None","4","5","None","None","5","6","None","None","6","7","None","None","7","8","None","None","8","9","None","None","9","10","None","None","10","11","None","None","11","12","None","None","12","13","None","None","13","14","None","None","14","15","None","None","15","16","None","None","16","17","None","None","17","18","None","None","18","19","None","None","19","20","10","20"};
             testcase = ob.TestPositive(input, expected);
            Console.WriteLine("Test Case Pass:" + testcase);

            //Test Case3------

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 5, 6, 4, 3, 2, 1, 0 };
            expected = new string[] { "None","None","None","None","None","None","None","None","2","3","None","None","3","4","None","None","4","5","None","None","5","6","None","None","6","7","None","None","7","8","None","None","8","9","None","None","9","10","None","None","9","10","None","None","9","10","None","None","8","9","None","None","6","8","None","None","6","7","None","None","5","6","None","None","4","6","None","None","3","4","None","None","2","3","None","None","1","2","5","10" };
            testcase = ob.TestPositive(input, expected);
            Console.WriteLine("Test Case Pass:" + testcase);
            //Test Case4------

            input = new int[] { 2, 5, 6, 7, 3, 9, 0, -1, 4, -2, 5, -11, 22, 43, -3, -5, 3, 66, 15, -12, 54, 24, 12, 32, 67, 4, 7, 10, 76, 5 };
            expected = new string[] {"None","None","None","None","None","None","None","None","4","6","None","None","6","7","None","None","5","7","None","None","6","9","None","None","4","9","None","None","2","9","None","None","1","4","None","None","0","4","None","None","2","5","None","None","-2","5","None","None","5","22","None","None","18","43","None","None","20","43","None","None","11","43","None","None","-1","3","None","None","21","66","None","None","28","66","None","None","23","66","7","66","19","54","10","66","22","54","11","66","30","54","11","66","22","32","12","66","37","67","16","67","34","67","15","67","26","67","16","67","7","10","16","67","31","76","20","76","30","76","20","76" };
            testcase = ob.TestPositive(input, expected);
            Console.WriteLine("Test Case Pass:" + testcase);
            //Test Case5------

            input = new int[] { 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            expected = new string[] { "None","None","None","None","None","None","None","None","29","30","None","None","28","29","None","None","27","28","None","None","26","27","None","None","25","26","None","None","24","25","None","None","23","24","None","None","22","23","None","None","21","22","None","None","20","21","None","None","19","20","None","None","18","19","None","None","17","18","None","None","16","17","None","None","15","16","None","None","14","15","None","None","13","14","None","None","12","13","20","30","11","12","19","29","10","11","18","28","9","10","17","27","8","9","16","26","7","8","15","25","6","7","14","24","5","6","13","23","4","5","12","22","3","4","11","21","2","3","10","20","1","2","9","19"};
            testcase = ob.TestPositive(input, expected);
            Console.WriteLine("Test Case Pass:" + testcase);
            //Test Case6------

            input = new int[] { 1, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            expected = new string[] { "None","None","None","None","None","None","None","None","19","29","None","None","28","29","None","None","27","28","None","None","26","27","None","None","25","26","None","None","24","25","None","None","23","24","None","None","22","23","None","None","21","22","None","None","20","21","None","None","19","20","None","None","18","19","None","None","17","18","None","None","16","17","None","None","15","16","None","None","14","15","None","None","13","14","None","None","12","13","19","29","11","12","19","9","10","11","18","28","9","10","17","27","8","9","16","26","7","8","15","25","6","7","14","24","5","6","13","23","4","5","12","22","3","4","11","21","2","3","10","20","1","2","9","19"};
            testcase = ob.TestPositive(input, expected);
            Console.WriteLine("Test Case Pass:" + testcase);
            Console.ReadLine();

            }
        //method for executing the test cases
        public bool TestPositive(int[] input,string[] expected)
            {

            RollingAverageMaximum ob = new RollingAverageMaximum();
            var result = ob.CalculateMaxAverage(input, 3, 20);
            int i = 0;
            foreach (var item in result)
                {
                if (item != expected[i])
                    {
                    return false;
                    }

                i++;
                }
            return true;
            }
        }
    }