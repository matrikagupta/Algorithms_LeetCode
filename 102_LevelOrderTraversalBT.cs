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
    class _102_LevelOrderTraversalBT
        {
        int level = 0;
        public IList<IList<int>> LevelOrder(TreeNode root)
            {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
                return list;
            return TraverseTree(root, 0, list);

            }

        public IList<IList<int>> TraverseTree(TreeNode root, int level, IList<IList<int>> list)
            {
            if (list.Count <= level)
                list.Insert(level, new List<int>());
            list[level].Add(root.val);

            if (root.left != null)
                { TraverseTree(root.left, level + 1, list); }
            if (root.right != null)
                { TraverseTree(root.right, level + 1, list); }
            return list;
            }


        }
    }
