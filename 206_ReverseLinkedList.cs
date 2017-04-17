using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    public class ListNode
        {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
    class _206_ReverseLinkedList
        {
        public ListNode ReverseList(ListNode head)
            {
            ListNode curr = null;
            ListNode prev = null;
            while (head != null)
                {
                curr = head;
                head = head.next;
                curr.next = prev;
                prev = curr;
                }
            return curr;
            }
        }
    }
