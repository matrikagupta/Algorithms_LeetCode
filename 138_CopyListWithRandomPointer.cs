using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {


    public class RandomListNode
        {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
        };
    class _138_CopyListWithRandomPointer
        {


        public RandomListNode CopyRandomList(RandomListNode head)
            {
            RandomListNode temp = head, next;

            //Adding a copy node in between two nodes of the exiting linkedlist
            while (temp != null){
                next = temp.next;
                RandomListNode node = new RandomListNode(temp.label);
                temp.next = node;
                node.next = next;
                temp = next;
                }

            //Assigning random pointers to the copy nodes
            temp = head;
            while (temp != null)
                {
                if (temp.random != null)
                    temp.next.random = temp.random.next; 
                temp = temp.next.next; //jumping on step ahead
                }

            temp = head;
            RandomListNode head2 = new RandomListNode(0);
            head2.next = temp.next;
            RandomListNode current;
            //spliting both the lists
            while (temp != null)
                {
                current = temp.next;
                if (current != null){
                    next = current.next;
                    temp.next = next;
                    }
                temp = current;
                }
            return head2.next;
            }

        public static void Main()
            {
            RandomListNode head;
            RandomListNode r = new RandomListNode(-1);
            //r.next = new RandomListNode(2);
            //r.next.next = new RandomListNode(3);
            //r.next.next.next = new RandomListNode(4);
            //r.random = r.next.next.next;
            //r.next.random = r;
            //r.next.next = r.next;
            //r.next.next.next.random = r;
            head = r;
            _138_CopyListWithRandomPointer obj = new _138_CopyListWithRandomPointer();
            obj.CopyRandomList(head);



             }
            }
    }
