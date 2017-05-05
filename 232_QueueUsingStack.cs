using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {

  // enQueue(q, x)
  //1) While stack1 is not empty, push everything from satck1 to stack2.
  //2) Push x to stack1(assuming size of stacks is unlimited).
  //3) Push everything back to stack1.
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
               
                    while (st1.Count != 0)
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
                while (st2.Count != 0)
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
