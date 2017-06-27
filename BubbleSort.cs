using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class BubbleSort
        {

       // Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
        public void sortbubble(int[] a)
            { int flag;
            for (int i = 0; i <a.Length-1; i++)
                { flag = 0;
                
                for (int k = 0; k < a.Length - 1 - i; k++)
                    {
                    if (a[k] > a[k + 1])
                        {
                        int temp = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = temp;
                        flag = 1;
                        }
                    }
                if (flag == 0)
                    break;
                }

            }


        //public static void Main()
        //    {
        //    BubbleSort so = new BubbleSort();
        //    int[] a = { 1, 2, 3,4, 5 };
        //    so.sortbubble(a);


        //    }
        }
    }
