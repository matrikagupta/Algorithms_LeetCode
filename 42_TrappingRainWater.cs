using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _42_TrappingRainWater
        {

        public int trap(int[] A)
            {
            int a = 0;
            int b = A.Length - 1;
            int max = 0;
            int leftmax = 0;
            int rightmax = 0;
            while (a <= b)
                {
                leftmax = Math.Max(leftmax, A[a]);
                rightmax = Math.Max(rightmax, A[b]);
                if (leftmax < rightmax)
                    {
                    max += (leftmax - A[a]);       // leftmax is smaller than rightmax, so the (leftmax-A[a]) water can be stored
                    a++;
                    }
                else
                    {
                    max += (rightmax - A[b]);
                    b--;
                    }
                }
            return max;
            }

        //public static void Main()
        //    {
        //    _42_TrappingRainWater obj = new _42_TrappingRainWater();
        //    int[] a = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        //    obj.trap(a);

        //    }
        }
        }
