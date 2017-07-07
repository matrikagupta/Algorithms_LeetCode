using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {

    class _2_AddTwoNumbers
        {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
            ListNode result = new ListNode(0);
            ListNode head = result;
            int carry = 0;
            if (l1 != null && l2 != null)
                {
                while (l1 != null || l2 != null)
                    {
                    Console.WriteLine(carry);
                    ListNode Node = new ListNode(0);
                    int value = l1.val + l2.val + carry;
                    Node.val = (value % 10);
                    carry = (value / 10);
                    result.next = Node;
                    result = Node;
                    l1 = l1.next;
                    l2 = l2.next;
                    }

                }
            return head.next;
            }

     
        }
    public class Program
        {
        public static void Main()
           {
           ListNode l1, l2;
           ListNode node = new ListNode(2);
           l1 = node;
           node = new ListNode(4);
           l1.next = node;
           node = new ListNode(3);
           l1.next.next = node;
           node = new ListNode(5);
           l2 = node;
           node = new ListNode(6);
           l2.next = node;
           node = new ListNode(4);
           l2.next.next = node;

           _2_AddTwoNumbers obj = new _2_AddTwoNumbers();
           obj.AddTwoNumbers(l1, l2);

           }
        }
    }
