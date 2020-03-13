using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    /// <summary>
    /// 单向循环链表
    /// </summary>
    class OneWayCircularLinkedList
    {
        public class LinkedListNode
        {
            public int val;
            public LinkedListNode next;
        }

        public void CreatList(int c, LinkedListNode node)
        {
            InitList(node);
            for (int i = 0; i < c; i++)
            {
                int x = int.Parse(Console.ReadLine());
                Add_Back(node, x);
            }
        }
        private void InitList(LinkedListNode node)
        {
            node = new LinkedListNode();
            node.next = null;
            node.val = -1;
        }

        public void Add_Back(LinkedListNode node, int x)
        {
            LinkedListNode tmp = node;
            do
            {
                if (tmp.next == null) break;//如果只有一个头节点，直接退出
                tmp = tmp.next;
            } while (tmp.next != node.next);
            LinkedListNode p = new LinkedListNode();
            p.val = x;
            p.next = node.next;
            tmp.next = p;
        }

        public void PrintList(LinkedListNode node)
        {
            Console.WriteLine("PrintList elements are:");
            LinkedListNode tmp = node;
            do
            {
                if (tmp.next == null) return;//如果只有一个头节点，直接退出
                Console.WriteLine(tmp.next.val);
                tmp = tmp.next;
            } while (tmp.next != node.next);
        }

        public void PrintListAtPos(LinkedListNode node, int pos)
        {
            Console.WriteLine("PrintListAtPos elements are:");
            LinkedListNode cp= FindNodeAsPosition(node, pos);
            LinkedListNode tmp = cp;
            do
            {
                if (tmp.next == null) return;//如果只有一个头节点，直接退出
                Console.WriteLine(tmp.next.val);
                tmp = tmp.next;
            } while (tmp.next != cp.next);
        }

        public LinkedListNode FindNodeAsPosition(LinkedListNode node, int pos)
        {
            LinkedListNode tmp = node;
            int tPos = 0;
            do
            {   if (tmp.next == null) return null;
                if (tPos == pos) return tmp.next;
                tmp = tmp.next;
                tPos++;
            } while (tmp.next != node.next);
            return null;
        }

        public LinkedListNode FindNodeAsValue(LinkedListNode node, int value)
        {
            LinkedListNode tmp = node;
            do
            {
                if (tmp.next == null) return null;
                if (tmp.next.val == value) return tmp.next;
                tmp = tmp.next;
            } while (tmp.next != node.next);
            return null;
        }
    }
}
