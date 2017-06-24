using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _54_SpiralMatrix
        {

        public IList<int> SpiralOrder(int[,] matrix)
            {

            List<int> res = new List<int>();

            if (matrix.Length == 0)
                {
                return res;
                }

            int rowBegin = 0;
            int rowEnd = matrix.GetLength(0) - 1;
            int colBegin = 0;
            int colEnd = matrix.GetLength(1) - 1;

            while (rowBegin <= rowEnd && colBegin <= colEnd)
                {
                // Traverse Right
                for (int j = colBegin; j <= colEnd; j++)
                    {
                    res.Add(matrix[rowBegin, j]);
                    }
                rowBegin++;

                // Traverse Down
                for (int j = rowBegin; j <= rowEnd; j++)
                    {
                    res.Add(matrix[j, colEnd]);
                    }
                colEnd--;

                if (rowBegin <= rowEnd)
                    {
                    // Traverse Left
                    for (int j = colEnd; j >= colBegin; j--)
                        {
                        res.Add(matrix[rowEnd, j]);
                        }
                    }
                rowEnd--;

                if (colBegin <= colEnd)
                    {
                    // Traver Up
                    for (int j = rowEnd; j >= rowBegin; j--)
                        {
                        res.Add(matrix[j, colBegin]);
                        }
                    }
                colBegin++;
                }

            return res;
            }


        //public static void Main()
        //    {
        //    _54_SpiralMatrix s = new _54_SpiralMatrix();
        //    int[,] grid = new int[,] { { 1, 2,3,5 },
        //                                 { 4,5,6,7},
        //                                { 7,8,9,8},
        //                                  { 11,18,19,18}};
        //    // 31
        //    //42
        //    s.SpiralOrder(grid);
        //    }
        }
    }
    
