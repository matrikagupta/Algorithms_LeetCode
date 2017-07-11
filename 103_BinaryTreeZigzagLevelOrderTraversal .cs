using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _103_BinaryTreeZigzagLevelOrderTraversal
        {

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
            {
            var list = new List<IList<int>>();
            if (root == null) return list;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var level = 0;
            while (q.Count > 0)
                {
                var count = q.Count;
                var l = new List<int>();
                for (var i = 0; i < count; i++)
                    {
                    var node = q.Dequeue();
                    if (level % 2 == 0)
                        {
                        l.Add(node.val);
                        }
                    else
                        {
                        l.Insert(0, node.val);
                        }
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                    }
                level++;
                list.Add(l);
                }

            return list;
            }

        static void Main()
            {
            _103_BinaryTreeZigzagLevelOrderTraversal obj = new _103_BinaryTreeZigzagLevelOrderTraversal();
			//creating a tree
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(10);
            root.left.left = new TreeNode(11);
            root.left.right = new TreeNode(12);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(19);
            root.left.left.left = new TreeNode(12);
            root.left.left.right = new TreeNode(20);
            root.left.right.left = new TreeNode(4);
            root.left.right.right = new TreeNode(6);
            root.right.left.left = new TreeNode(8);
            root.right.left.right = new TreeNode(16);
            root.right.right.left = new TreeNode(13);
            root.right.right.right = new TreeNode(17);
            obj.ZigzagLevelOrder(root);

            }
        }
    }
