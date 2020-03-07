using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    public class DoubleLinkedList
    {
        private int m_length = 0;
        public int Length { get { return m_length; } }

        public class LinkedListNode
        {
            public LinkedListNode pre;
            public LinkedListNode next;
            public int val;
        }

        public void CreateList(int c, LinkedListNode node)
        {
            InitList(c, node);
            for (int i = 0; i < c; i++)
            {
                int x = int.Parse(Console.ReadLine().ToString());
                Add_Back(node, x);
            }
        }
        private void InitList(int c, LinkedListNode node)
        {

            node = new LinkedListNode();
            node.pre = node;
            node.next = null;
            node.val = -1;
        }

        public void Add_Back(LinkedListNode node, int x)
        {
            LinkedListNode tmp = node;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            LinkedListNode p = new LinkedListNode();
            p.next = null;
            p.pre = tmp;
            p.val = x;

            node.pre = p;
            tmp.next = p;

            m_length++;
        }

        /// <summary>
        /// 插入元素，要判断实在尾部还是在身子部
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pos"></param>
        /// <param name="x"></param>
        public void Insert(LinkedListNode node, int pos, int x)
        {
            LinkedListNode p = new LinkedListNode();
            if(pos==Length-1)
            {
                Add_Back(node, x);
            }
            else
            {
                LinkedListNode tNode = FindNodeAsPosition(node, pos);
                p.val = x;
                p.pre = tNode;
                p.next = tNode.next;

                tNode.next.pre = p;
                tNode.next = p;
            }
            m_length++;
        }

        public void PrintList(LinkedListNode node)
        {
            LinkedListNode p = node;
            while (p.next != null)
            {
                Console.WriteLine(p.next.val);
                p = p.next;
            }
            Console.WriteLine();
        }

        public void ReversePrintList(LinkedListNode node)
        {
            LinkedListNode p = node.pre;
            while (p != node)
            {
                Console.WriteLine(p.val);
                p = p.pre;
            }
            Console.WriteLine();

        }

        public LinkedListNode FindNodeAsPosition(LinkedListNode node, int pos)
        {
            LinkedListNode tNode = node;
            int tPos = 1;
            while (tNode.next != null)
            {
                if (tPos == pos)
                {
                    Console.WriteLine("value is:" + tNode.next.val);
                    return tNode.next;
                } 
                tNode = tNode.next;
                tPos++;
            }
            return null;
        }

        public LinkedListNode FindNodeAsValue(LinkedListNode node, int val)
        {
            LinkedListNode tNode = node;
            while (tNode.next != null)
            {
                if (tNode.next.val == val) return tNode.next;
                tNode = tNode.next;
            }
            return null;
        }

        public int IndexOf(LinkedListNode node,int val)
        {
            int index = -1;
            int z = 0;
            LinkedListNode tNode = node;
            while (tNode.next != null)
            {
                if (tNode.next.val == val)
                {
                    index = z;
                    return index;
                }
                tNode = tNode.next;
                z++;
            }
            return index;
        }

        /// <summary>
        /// 删除节点，要考虑最后一个和中间元素的情况。
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pos"></param>
        public void DeleteValueAsPosition(LinkedListNode node, int pos)
        {
            LinkedListNode tNode= FindNodeAsPosition(node, pos);
            
            if(pos==Length)//如果是尾节点的情况
            {
                Console.WriteLine("删除的是尾节点");
                node.pre = tNode.pre;
                tNode.pre.next = null;
            }
            else//如果不是尾巴节点的情况
            {
                tNode.pre.next = tNode.next;
                tNode.next.pre = tNode.pre;
            }
            m_length--;
        }

        public void DeleteValueAsValue(LinkedListNode node,int value)
        {
            LinkedListNode tNode = FindNodeAsValue(node, value);

            int index = IndexOf(node, value);

            if (index==Length-1)//最后一个节点
            {
                node.pre = tNode.pre;
                tNode.pre.next = null;
            }
            else//不是最后一个节点
            {
                tNode.pre.next = tNode.next;
                tNode.next.pre = tNode.pre;
            }
            m_length--;
        }

        public void Clear(LinkedListNode node)
        {
            int len = Length;
            for (int i=1;i<=len;i++)
            {
                DeleteValueAsPosition(node, 1);
            }
        }

    }
}
