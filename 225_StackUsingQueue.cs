using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _225_StackUsingQueue
        {
        Queue<int> q;
        public _225_StackUsingQueue()
            {
                q = new Queue<int>();

            }

        /** Push element x onto stack. */
        public void Push(int x)
            {
         
                q.Enqueue(x);
          for(int i =0; i<q.Count-1;i++)
                {
                q.Enqueue(q.Dequeue());
                }
            
            }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
            { 
            return q.Dequeue();
            }

        /** Get the top element. */
        public int Top()
            {
             return  q.Peek();
            }

        /** Returns whether the stack is empty. */
        public bool Empty()
            {
            if (q.Count == 0)
                return true;
            else
                return false;
            }
        }

    public class Program
        { public static void Main()
            {
            _225_StackUsingQueue st = new _225_StackUsingQueue();
            st.Push(1);
            st.Push(2);
            int t = st.Top();



            }

        }
    }
