using System;
using System.Reflection.Metadata.Ecma335;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://leetcode.com/problems/merge-two-binary-trees/description/


        }

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            
            if (t1 == null || t2 == null)
            {
                return t1 ?? t2;
            }

            var result = new TreeNode(
                    t1.val + t2.val
                );

            result.left = MergeTrees(t1.left, t2.left);                       
            result.right = MergeTrees(t1.right, t2.right);
            
            return result;
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) => val = x;    
    }

}