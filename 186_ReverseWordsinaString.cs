using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeInterview
    {
    class _186_ReverseWordsinaString
        {

        public void reverseWords(string s)
            {
            string[] words = s.Split(' ');
            Stack<string> st = new Stack<string>();
            foreach(var w in words)
                {
                st.Push(w);
                }

            foreach (var item in st.ToList())
                {
                Console.Write(st.Pop()+" ");
                }
        
            char[] str = s.ToCharArray();
            //-----without using extra space--
            int i = 0;
            int j = s.Length-1;
            char temp;
            while(i<=j)
                { temp = str[i];
                str[i] = str[j];
                str[j] = temp;
                i++; j--;
                }
            i = 0;
            for (int k = 0; k < str.Length; k++)
                {
                if (str[k] != ' ')
                    j=k;

                if (str[k] == ' ' || k == str.Length - 1)

                    {
                    while (i <= j)
                        {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                        i++; j--;

                        }
                    i = k+1;
                    }

                }

            }


        //static void Main(string[] args)
        //    {
        //    _186_ReverseWordsinaString ob = new _186_ReverseWordsinaString();
        //    ob.reverseWords("The Sky is blue");
        //    Console.ReadLine();


        //    }
        }
    }
