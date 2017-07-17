using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _98_IsValidBST
        {
        public bool IsValidBST(TreeNode root)
            {


            return Recurse(root, long.MinValue, long.MaxValue);
            }

        public bool Recurse(TreeNode root, long min, long max)
            {
            if (root == null) return true;
            if (root.val <= min || root.val >= max) return false;

            return Recurse(root.left, min, root.val) && Recurse(root.right, root.val, max);

            }

        //public static void Main()
        //    {
        //    _98_IsValidBST obj = new _98_IsValidBST();
        //    TreeNode root = new TreeNode(4);
        //    root.left = new TreeNode(2);
        //    root.right = new TreeNode(6);
        //    root.left.left = new TreeNode(-1);
        //    root.left.right = new TreeNode(3);
        //    root.right.left = new TreeNode(5);
        //    root.right.right = new TreeNode(7);
        //   bool res= obj.IsValidBST(root);
        //    }
        }
    }
