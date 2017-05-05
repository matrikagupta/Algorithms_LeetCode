using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _48_RotateImage
        {
        public void Rotate(int[,] matrix)
            {
            var n = matrix.GetUpperBound(0);

            int temp = 0;
            for (int i = 0; i <= n / 2; i++)
                {
                for (int j = i; j < n - i; j++)
                    {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[n - j, i];
                    matrix[n - j, i] = matrix[n - i, n - j];
                    matrix[n - i, n - j] = matrix[j, n - i];
                    matrix[j, n - i] = temp;


                    }

                }

            }

        //public static void Main()
        //    {
        //    _48_RotateImage s = new _48_RotateImage();
        //    int[,] grid = new int[,] { { 1, 2,3 },
        //                                 { 4,5,6},
        //                                { 7,8,9} };
        //   // 31
        //    //42
        //    s.Rotate(grid);
        //    }
        }
    }
