using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _449_SerializeDeserializeBST
        {

        // Encodes a tree to a single string.
        StringBuilder s = new StringBuilder();
        public string serialize(TreeNode root)
            {
            if (root == null)
                return null;

            s.Append(root.val + ",");
            serialize(root.left);
            serialize(root.right);
            return s.Remove(s.Length-1,s.Length).ToString();
            }


        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
            {
            TreeNode res = null;
            if ((data != null))
                {
                string[] a = data.Split(',');

                res = deserialize_BST(a, 0, a.Length - 1);
                }
            return res;
            }

        public int finddiv(string[] a, int val, int low, int high)
            {
            int i;
            for (i = low; i <= high; i++)
                {
                if (Convert.ToInt32(a[i])>val)
                    break;
                }
            return i;
            }
        public TreeNode deserialize_BST(string[] a, int low, int high)
            {
            if (low > high)
                return null;
            TreeNode root = new TreeNode(Convert.ToInt32(a[low]));
            int div = finddiv(a, root.val, low+1, high);
            root.left = deserialize_BST(a, low + 1, div - 1);
            root.right = deserialize_BST(a, div, high);

            return root;
            }

        //public static void Main()
        //    {
        //    _449_SerializeDeserializeBST obj = new _449_SerializeDeserializeBST();
        //    obj.deserialize("2,1,3");

        //    }
        }
    }
