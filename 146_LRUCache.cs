using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {

    public class CacheNode
        {
        public int val;
        public int key;
        public CacheNode prev;
        public CacheNode next;
        public CacheNode(int Value, int Key)
            {
            val = Value;
            key = Key;
            }


        }
    class _146_LRUCache
        {
        public CacheNode head;
        public CacheNode tail;
        int capacity = 0;
        Dictionary<int, CacheNode> Cache;
        CacheNode node;
        public _146_LRUCache(int cap)
            {
            capacity = cap; // Capacity size of the caache
            Cache = new Dictionary<int, CacheNode>(); // key value pair for storing the key and 
                                                      // reference of the node created in the linkedlist

            }

        public int Get(int key)
            {
            //node is present 
            if (Cache.ContainsKey(key))
                {
                //get the node based on key from dictionary
                Cache.TryGetValue(key, out node);
                //add the node to end in the linkedlist, since it recently accesed
                movetofront(node);
                //return the value of node
                return node.val;
                }
            else
                return -1; //not present in the dictionary return -1

            }
        public void Put(int key, int val)
            {

            //node is not the dictionary
            if (!(Cache.ContainsKey(key)))
                {
                //check if dictionary size is equal to size of cache
                if (Cache.Count == capacity)
                    {
                    //remove the node from the linkedlist tail
                    Cache.Remove(tail.key);
                    deleteNode();
                    }
                //add node to the linkedlist 
                Cache.Add(key, addNode(val, key));
                }
            else
                { //if node in the dictionary, get the node
                Cache.TryGetValue(key, out node);

                if (node.val != val)
                    {
                    node.val = val;
                    }
                movetofront(node);
                }

            }



        CacheNode addNode(int value, int key)
            {
            CacheNode node;

            if (head == null && tail == null)
                {
                node = new CacheNode(value, key);
                head = node;
                tail = node;

                }
            else
                {
                node = new CacheNode(value, key);
                node.next = head; //new node's next pointing to head
                head.prev = node;// head's prev which was null now pointing to new node
                head = node;// now there is linking between new node and head, new node will becomes the head
                }
            return node;


            }
        void movetofront(CacheNode node)
            {
            if (node == head)
                {
                return;
                }

            if (node == tail)
                {
                tail = tail.prev;// tail is moving once step behind
                }

            if (node.next != null)
                {
                node.next.prev = node.prev;
                }

            node.prev.next = node.next;
            node.prev = null;
            node.next = head;
            head.prev = node;
            head = node;
            }
        void deleteNode()
            {
            if (tail == null)
                {
                return;

                }
            if (tail == head)
                {
                tail = null;
                head = null;

                }
            else
                {
                tail = tail.prev;
                tail.next = null;
                }

            }


        //public static void Main()
        //    {
        //    _146_LRUCache cache = new _146_LRUCache(3);
        //    cache.Put(1, 1);
        //    cache.Put(2, 2);
        //    cache.Get(1);       // returns 1
        //    cache.Put(3, 3);    // evicts key 2
        //    cache.Get(2);       // returns -1 (not found)
        //    cache.Put(4, 4);    // evicts key 1
        //    cache.Get(1);       // returns -1 (not found)
        //    cache.Get(3);       // returns 3
        //    cache.Get(4);

        //    }
        }
    }
