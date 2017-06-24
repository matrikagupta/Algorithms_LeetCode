using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _270_Closest_Binary_Search_Tree_Value
        {


        int closestBSTValue(TreeNode root, int target)
            {
            TreeNode kid;
            if (target < root.val)
                kid = root.left;
            else
                kid=root.right;
            if (kid == null)
                return root.val;
            int closest = closestBSTValue(kid, target);
            if (Math.Abs(root.val - target) < Math.Abs(closest - target))
                return root.val;
            else
                return closest;


            }
        //public static void Main()
        //    {
        //    _270_Closest_Binary_Search_Tree_Value obj = new _270_Closest_Binary_Search_Tree_Value();
        //    TreeNode root = new TreeNode(9);
        //    root.left = new TreeNode(4);
        //    root.right = new TreeNode(17);
        //    root.left.left = new TreeNode(3);
        //    root.left.right = new TreeNode(6);
        //    root.left.right.left = new TreeNode(5);
        //    root.left.right.right = new TreeNode(7);
        //    root.right.right = new TreeNode(22);
        //    root.right.right.left = new TreeNode(20);
            
        //    int k = 18;
        //   int res= obj.closestBSTValue(root, k);
        //    }
        }
    }
