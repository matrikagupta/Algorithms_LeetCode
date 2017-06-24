using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _235_LCABST
        {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {

            if (root == null || (root.left == null && root.right == null && root.val != p.val && root.val != q.val))
                return null;
            if ((root.val <= p.val && root.val >= q.val) || (root.val >= p.val && root.val <= q.val))
                {
                return root;
                }
            var left = LowestCommonAncestor(root.left, p, q);
            if (left != null) return left;
            var right = LowestCommonAncestor(root.right, p, q);
            return right;
            }
        }
    }
