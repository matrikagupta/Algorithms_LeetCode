using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeInterview
    {
    class CacheNode
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
    class LRUCache
        {
        public CacheNode head;
        public CacheNode tail;
        int capacity = 0;
        Dictionary<int, CacheNode> Cache;
        CacheNode node;
        public LRUCache(int cap)
            {
            capacity = cap;
            Cache = new Dictionary<int, CacheNode>();

            }

        public int Get(int key)
            {
            if (Cache.ContainsKey(key))
                {
                Cache.TryGetValue(key, out node);
                movetoend(node);
                printnodes();
                return node.val;
                }
            else
                return -1;

            }
        public void Put(int key, int val)
            {

            if (!(Cache.ContainsKey(key)))
                {
                if (Cache.Count == capacity)
                    {
                    Cache.Remove(tail.key);
                    deleteNode();
                    }
                Cache.Add(key, addNode(val, key));
                }
            else
                {
                Cache.TryGetValue(key, out node);
                if (node.val != val)
                    {
                    node.val = val;
                    }
                movetoend(node);
                }
            printnodes();
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
                node.next = head;
                head.prev = node;
                head = node;
                }
            return node;


            }
        void movetoend(CacheNode node)
            {
            if (node == head)
                {
                return;
                }

            if (node == tail)
                {
                tail = tail.prev;
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

        void printnodes()
            {
            CacheNode temp = head;
            Console.WriteLine("Writing output");
            while (temp != null)
                {
                Console.Write(temp.key + "," + temp.val + "->");
                temp = temp.next;

                }
            Console.WriteLine();

            }

        }

    public class Program
        {
        public static void Main()
            {
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 1);
            cache.Put(2, 2);
            cache.Get(2);
            cache.Put(1, 1);
            cache.Get(1);
            cache.Get(4);
            cache.Get(3);

            }
        }
    }
