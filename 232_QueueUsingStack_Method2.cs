using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _232_QueueUsingStack_Method2
        {
        Stack<int> st1;
        Stack<int> st2;
        int peek = 0;
        public _232_QueueUsingStack_Method2()
            {
            st1 = new Stack<int>();
            st2 = new Stack<int>();
            }
        /** Push element x to the back of queue. */
        public void Push(int x)
            {
            if (st1.Count == 0)
                peek = x;
            st1.Push(x);
            }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
            {
            if (st2.Count != 0)
                return st2.Pop();
            while (st1.Count != 0)
                {
                st2.Push(st1.Pop());
                }
            return st2.Pop();
            }

        /** Get the front element. */

        public void pushintostack()
            {
            while (st1.Count != 0)
                {
                st2.Push(st1.Pop());
                }
            }
        public int Peek()
            {
            if (st2.Count != 0)
                return st2.Peek();
            else
                return peek;
            }

        /** Returns whether the queue is empty. */
        public bool Empty()
            {
            if (st2.Count == 0 && st1.Count == 0)
                return true;
            else
                return false;
            }
        }
    }
