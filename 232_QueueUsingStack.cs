using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _232_QueueUsingStack
        {
        Stack<int> st1;
        Stack<int> st2;

        public _232_QueueUsingStack()
            {
            st1 = new Stack<int>();
            st2 = new Stack<int>();
            }
        /** Push element x to the back of queue. */
        public void Push(int x)
            {

            if (st1.Count != 0)
                {
                for (int i = 0; i < st1.Count; i++)
                    {
                    st2.Push(st1.Pop());
                    }
                }

            if (st1.Count == 0)
                {
                st1.Push(x);
                }


            if (st2.Count != 0)
                {
                for (int i = 0; i < st2.Count; i++)
                    {
                    st1.Push(st2.Pop());
                    }
                }
            }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
            {
          return  st1.Pop();
            }

        /** Get the front element. */
        public int Peek()
            {
           return st1.Peek();
            }

        /** Returns whether the queue is empty. */
        public bool Empty()
            {
            if (st1.Count == 0)
                return true;
            else
                return false;
            }
        }

    public class Program
        { public static void Main()
            {
            _232_QueueUsingStack st = new _232_QueueUsingStack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Pop();
            st.Pop();
            st.Pop();
            st.Empty();

            } }
    }
