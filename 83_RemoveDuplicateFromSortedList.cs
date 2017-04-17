using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _83_RemoveDuplicateFromSortedList
        {
        public ListNode DeleteDuplicates(ListNode head)
            {
            ListNode current = head;
            while (current != null)
                {
                if (current.next != null && current.val == current.next.val)
                    current.next = current.next.next;
                else
                    current = current.next;
                }
            return head;
            }
        }
    }
