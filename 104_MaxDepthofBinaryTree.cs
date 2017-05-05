using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    public class TreeNode
        {
       public TreeNode left;
        public TreeNode right;
        public int val = 0;
        }
    class _104_MaxDepthofBinaryTree
        {
        public int MaxDepth(TreeNode root)
            {
            if (root == null)
                return 0;
            return (Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1);

            }
        }
    }
