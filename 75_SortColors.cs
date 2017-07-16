using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _75_SortColors
        {
        public void SortColors(int[] a)
            {
            int lo = 0;
            int[] t = (int[])a.Clone();
            int hi = a.Length - 1;
            int mid = 0, temp = 0;
            while (mid <= hi)
                {
                switch (a[mid])
                    {
                    case 0:
                            {
                            temp = a[lo];
                            a[lo] = a[mid];
                            a[mid] = temp;
                            lo++;
                            mid++;
                            break;
                            }
                    case 1:
                        mid++;
                        break;
                    case 2:
                            {
                            temp = a[mid];
                            a[mid] = a[hi];
                            a[hi] = temp;
                            hi--;
                            break;
                            }
                    }
                }
            }

        //public static void Main()
        //    {
        //    _75_SortColors obj = new _75_SortColors();
        //    int[] nums = { 0,1,0,2,0,2,1 };
        //    obj.SortColors(nums);
        //    //}
        }
    }
