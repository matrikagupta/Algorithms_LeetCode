using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _21_MergeTwoSortedList
        {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
            if (l1 == null && l2 == null)
                return null;
            if (l2 == null && l1 != null)
                return l1;
            if (l1 == null && l2 != null)
                return l2;


            if (l1.val <= l2.val)
                {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
                }
            else
                {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
                }

            }
        }
        //static void Main(string[] args)
        //    {
        //    _21_MergeTwoSortedList obj = new _21_MergeTwoSortedList();
        //    ListNode node1 = new ListNode(1);
        //    node1.next = new ListNode(2);
        //    node1.next = new ListNode(4);
        //    ListNode node2 = new ListNode(3);
        //    node2.next = new ListNode(5);

        //    obj.MergeTwoLists(node1,node2);



        //    }
        
    }
