using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _445_AddTwoNumberII
        {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();

            while (l1 != null)
                {
                st1.Push(l1.val);
                l1 = l1.next;
                }

            while (l2 != null)
                {
                st2.Push(l2.val);
                l2 = l2.next;
                }

            int val = 0;
            int carry = 0;

            ListNode head = new ListNode(-1);
            while (st1.Count != 0 || st2.Count != 0)
                {
                if (st1.Count != 0 && st2.Count != 0)
                    val = st1.Pop() + st2.Pop() + carry;
                else if (st1.Count != 0)
                    val = st1.Pop();
                else
                    val = st1.Pop();

                if (val > 9)
                    {
                    carry = 1;
                    }
                    head.next = new ListNode(val% 10);

                    
               
                }
            return head.next;
            }

        //public static void Main()
        //    {
        //    _445_AddTwoNumberII s = new _445_AddTwoNumberII();
        //    ListNode l = new ListNode(7);
        //    l.next = new ListNode(2);
        //    l.next.next = new ListNode(4);
        //    l.next.next.next = new ListNode(3);
        //    ListNode l2 = new ListNode(5);
        //    l2.next = new ListNode(6);
        //    l2.next.next = new ListNode(4);
        //    s.AddTwoNumbers(l, l2);
        //    }
        }
    }
