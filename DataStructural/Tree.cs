using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    class Tree
    {
        public class TreeNode
        {
            public TreeNode m_left;
            public TreeNode m_right;
            public int data;
        }


        public Tree()
        {

        }
        public TreeNode InitTree()
        {
            int a = int.Parse(Console.ReadLine().ToString());
            TreeNode tmpNode = new TreeNode();
            if (a == 0)
            {
                tmpNode = null;
            }
            else
            {
                tmpNode.data = a;
                tmpNode.m_left = InitTree();
                tmpNode.m_right = InitTree();
            }
            return tmpNode;
        }


        //遍历树
        public void PrintTreeFirst(TreeNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.data);
            PrintTreeFirst(node.m_left);
            PrintTreeFirst(node.m_right);
        }
        public void PrintTreeMiddle(TreeNode node)
        {
            if (node == null) return;
            PrintTreeMiddle(node.m_left);
            Console.WriteLine(node.data);
            PrintTreeMiddle(node.m_right);
        }
        public void PrintTreeLast(TreeNode node)
        {
            if (node == null) return;
            PrintTreeLast(node.m_left);
            PrintTreeLast(node.m_right);
            Console.WriteLine(node);
        }

        //层序遍历
        public void PrintTreeLayer(TreeNode node)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (node!=null)
            {
                q.Enqueue(node);
                while(q.Count!=0)
                {
                    TreeNode p = q.Dequeue();
                    Console.WriteLine(p.data);
                    if (p.m_left != null) q.Enqueue(p.m_left);
                    if (p.m_right != null) q.Enqueue(p.m_right);
                }
            }
        }

        public int GetTreeDepth(TreeNode node)
        {
            if (node == null) return 0;
            else
            {
                int l = GetTreeDepth(node.m_left) + 1;
                int r = GetTreeDepth(node.m_right) + 1;
                return Math.Max(l, r);
            }
        }

        public int GetChildCount(TreeNode node)
        {
            if(node!=null)
            {
                if (node.m_right==null&&node.m_left==null) return 1;
                return GetChildCount(node.m_left)+GetChildCount(node.m_right);
            }
            return 0;
        }

    }
}
