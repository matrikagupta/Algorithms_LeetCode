using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _449_SerializeDeserializeBST
        {


        public string serialize(Node root)
            {
            StringBuilder s = new StringBuilder();
            serialize_inorder(s, root);
            Console.WriteLine(s.ToString().Substring(0, s.Length - 1));
            return s.ToString().Substring(0, s.Length - 1);

            }

        private void serialize_inorder(StringBuilder s, Node root)
            {
            if (root == null)
                {
                s.Append("null,");
                return;
                }
            else
                {
                s.Append(root.item + ",");
                serialize_inorder(s, root.leftChild);
                serialize_inorder(s, root.rightChild);
                }

            }
        // Decodes your encoded data to tree.
        public Node deserialize(string data)
            {
            Node res = null;
            if ((data != null))
                {
                string[] a = data.Split(',');
                int[] t = { 0 };
                res = helper(a, t);
                //res = deserialize_BST(a, 0, a.Length - 2);
                }
            return res;
            }
        public Node helper(String[] arr, int[] t)
            {
            if (arr[t[0]].Equals("null"))
                {
                t[0]++;
                return null;
                }

            Node root = new Node();
            root.item = Int32.Parse(arr[t[0]]);

            t[0]++;
            root.leftChild = helper(arr, t);
            root.rightChild = helper(arr, t);

            return root;
            }

        //public static void Main()
        //    {
        //    _449_SerializeDeserializeBST obj = new _449_SerializeDeserializeBST();
        //    Node node = new Node();
        //    node.item = 2;
        //    node.leftChild = new Node();
        //    node.leftChild.item = 1;
        //    node.rightChild = new Node();
        //    node.rightChild.item = 3;

        //    //  obj.serialize(node);
        //    obj.deserialize(obj.serialize(node));

        //    }
        }
    }
