using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _23_MergeKSortedLists
        {
        public ListNode MergeKLists(ListNode[] lists)
            {
            if (lists.Length == 0) return null;
            return Helper(0, lists.Length - 1, lists);
            }

        private ListNode Helper(int left, int right, ListNode[] lists)
            {
            if (left == right) return lists[left];
            int mid = left + (right - left) / 2;
            var leftListNode = Helper(left, mid, lists);
            var rightListNode = Helper(mid + 1, right, lists);
            return MergeTwoLists(leftListNode, rightListNode);
            }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            var dummy = new ListNode(-1);
            var cur1 = l1;
            var cur2 = l2;
            var cur = dummy;
            while (cur1 != null || cur2 != null)
                {
                if (cur1 != null && cur2 != null)
                    {
                    if (cur1.val < cur2.val)
                        {
                        cur.next = cur1;
                        cur1 = cur1.next;
                        }
                    else if (cur1.val >= cur2.val)
                        {
                        cur.next = cur2;
                        cur2 = cur2.next;
                        }
                    }
                else
                    {
                    if (cur1 != null)
                        {
                        cur.next = cur1;
                        cur1 = cur1.next;
                        }
                    else if (cur2 != null)
                        {
                        cur.next = cur2;
                        cur2 = cur2.next;
                        }
                    }
                cur = cur.next;
                }
            var newHead = dummy.next;
            dummy.next = null;
            return newHead;
            }

        //static void Main(string[] args)
        //    {
        //    _23_MergeKSortedLists obj = new _23_MergeKSortedLists();
        //    ListNode node1 = new ListNode(1);
        //    node1.next = new ListNode(2);
        //    node1.next = new ListNode(4);
        //    ListNode node2 = new ListNode(3);
        //    node2.next = new ListNode(5);
        //    ListNode node3 = new ListNode(6);
        //    node3.next = new ListNode(0);
        //    List<ListNode> list = new List<ListNode>();
        //    list.Add(node1);
        //    list.Add(node2);
        //    list.Add(node3);

        //    obj.MergeKLists(list.ToArray<ListNode>());



        //    }
        }
    }
