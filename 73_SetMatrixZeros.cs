using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeInterview
    {
    class _73_SetMatrixZeros
        {
        public void SetZeroes(int[,] matrix)
            {
            
                {
                int col0 = 1, rows = matrix.GetLength(0);
                int cols = matrix.GetLength(0);

                for (int i = 0; i < rows; i++)
                    {
                    if (matrix[i, 0] == 0)
                        col0 = 0;
                    for (int j = 1; j < cols; j++)
                        if (matrix[i, j] == 0)
                            matrix[i, 0] = matrix[0, j] = 0;
                    }

                for (int i = rows - 1; i >= 0; i--)
                    {
                    for (int j = cols - 1; j >= 1; j--)
                        if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                            matrix[i, j] = 0;
                    if (col0 == 0) matrix[i, 0] = 0;
                    }

                }
            }

        //public  static void Main()
        //    {

        //    int[,] grid = new int[,]  {    {  1 ,  3 ,  5 ,  2 ,  0 },
        //                                   {  1 ,  1 ,  5 ,  1 ,  1 },
        //                                   {  1 ,  1 ,  0 ,  1 ,  1 },
        //                                   {  1 ,  7 ,  1 ,  9 ,  1 },
        //                                   {  1 ,  1 ,  1 ,  0 ,  1 } };

        //    _73_SetMatrixZeros obj = new _73_SetMatrixZeros();
        //    obj.SetZeroes(grid);

               
        //            }
                }
            }
        
    
