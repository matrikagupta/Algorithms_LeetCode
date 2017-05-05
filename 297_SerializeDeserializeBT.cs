using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    public class TreeNode
        {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        }

    public class _297_SerializeDeserializeBT
        {

        // Encodes a tree to a single string.

        public string serialize(TreeNode root)
            {
            StringBuilder str = new StringBuilder();
            dfs_serialize(root, str);
            return str.ToString();
            }


        public void dfs_serialize(TreeNode root, StringBuilder str)
            {
            if (root == null)
                {
                str.Append("null,");
                return;
                }
            str.Append(root.val + ",");
            dfs_serialize(root.left, str);
            dfs_serialize(root.right, str);
            }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
            {
            if (data == null)
                return null;
            string[] a = data.Split(',');
            TreeNode newnode = dfs_deserialize(a);
            return newnode;
            }
        int index = 0;
        public TreeNode dfs_deserialize(string[] a)
            {
            if (index > a.Length)
                { return null; }
            if (a[index] == "null")
                {
                index++;
                return null;
                }
           TreeNode newnode = new TreeNode(Convert.ToInt32(a[index]));
            index++;
            newnode.left = dfs_deserialize(a);
            newnode.right = dfs_deserialize(a);
            return newnode;
            }

        //static void Main(string[] args)
        //    {
        //    _297_SerializeDeserializeBT obj = new _297_SerializeDeserializeBT();
        //    TreeNode nodetree = new TreeNode(1);
        //    nodetree.left = new TreeNode(2);
        //    nodetree.right = new TreeNode(3);
        //    nodetree.left.left = new TreeNode(4);
        //    TreeNode node = obj.deserialize(obj.serialize(nodetree));

        //    }



        }
    }
