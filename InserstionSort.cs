using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class InserstionSort
        {


        public void Insertion_Sort(int[] intArray)

            {

            Console.WriteLine("==========Integer Array Input===============");

            for (int i = 0; i < intArray.Length; i++)

                {

                Console.WriteLine(intArray[i]);

                }



            int temp, j;

            for (int i = 1; i < intArray.Length; i++)

                {

                temp = intArray[i];

                j = i - 1;



                while (j >= 0 && intArray[j] > temp)

                    {

                    intArray[j + 1] = intArray[j];

                    j--;

                    }



                intArray[j + 1] = temp;

                }



            Console.WriteLine("==========Integer Array OutPut===============");

            for (int i = 0; i < intArray.Length; i++)

                {

                Console.WriteLine(intArray[i]);

                }

            }

        //public static void Main()
        //    {
        //    InserstionSort s = new InserstionSort();
        //    int[] a = { 2, 5, 6, 1, 0 };
        //    s.Insertion_Sort(a);
        //    }
        }
    }
