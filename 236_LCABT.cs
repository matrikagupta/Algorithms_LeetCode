using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {

    //class TreeNode
    //    {
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //    public TreeNode(int x) { val = x; }
    //    }
    class LCA
        {

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
            if (root == null)
                return null;
            //if root is equal to any of the value return root
            if (root.val == p.val || root.val == q.val)
                return root;
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            //if left and rigth both are not null return root
            if (left != null || right != null)
                return root;
            //if left is null return rigth node else left node value
            if (left == null)
                return right;
            else
                return left;
            }
        }
}

