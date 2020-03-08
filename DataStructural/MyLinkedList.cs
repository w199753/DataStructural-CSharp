using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    public class MyLinkedList
    {
        public MyLinkedList() { }

        public class MyLinkedListNode
        {
            public MyLinkedListNode next;
            public int data;
        }

        public void CreateList(int c, MyLinkedListNode node)
        {
            InitList(c, node);
        }

        private void InitList(int c, MyLinkedListNode node)
        {
            MyLinkedListNode p = new MyLinkedListNode();
            node.next = null;
            p = node;
            for (int i = 0; i < c; i++)
            {
                int a = int.Parse(Console.ReadLine().ToString());
                MyLinkedListNode tNode = new MyLinkedListNode();
                tNode.data = a;
                p.next = tNode;
                p = p.next;//使当前节点指向下一个节点

                /*tNode.next = p.next;
                p.next = tNode;*/
            }
            p.next = null;
        }

        public void AddElement(MyLinkedListNode node, int pos, int data)
        {
            MyLinkedListNode tNode = FindNodeAsPosition(node, pos);
            if(tNode!=null)
            {
                MyLinkedListNode q = new MyLinkedListNode();
                q.data = data;  
                q.next = tNode.next;
                tNode.next = q;
            }

        }

        public void PrintList(MyLinkedListNode node)
        {
            Console.WriteLine("the list element is:");
            MyLinkedListNode tNode = node;
            while (tNode.next != null)
            {
                Console.WriteLine(tNode.next.data);
                tNode = tNode.next;
            }
        }

        public void DeleteElementAsPosition(MyLinkedListNode node,int pos)
        {
            MyLinkedListNode tNode = FindNodeAsPosition(node, pos);
            if(tNode!=null)
            {
                tNode.next = tNode.next.next;
            }
        }

        public void DeleteElementAsValue(MyLinkedListNode node,int value)
        {
            MyLinkedListNode tNode = FindNodeAsValue(node, value);
            if(tNode!=null)
            {
                tNode.next = tNode.next.next;
            }
        }
        public void Clear(MyLinkedListNode node)
        {
            MyLinkedListNode tNode = node;
            while(node.next!=null)
            {
                tNode = node.next;
                node.next = null;
                node = tNode;
            }
            
        }

        public MyLinkedListNode FindNodeAsPosition(MyLinkedListNode node, int pos)
        {
            MyLinkedListNode tNode = node;
            int tPos = 1;
            while (tNode.next != null)
            {
                if (tPos == pos)
                {
                    return tNode.next;
                }
                tNode = tNode.next;
                tPos++;
            }
            return null;
        }

        public MyLinkedListNode FindNodeAsValue(MyLinkedListNode node, int value)
        {
            MyLinkedListNode tNode = node;
            while(tNode.next!=null)
            {
                if(tNode.next.data==value)
                {
                    return tNode.next;
                }
                tNode = tNode.next;
            }
            return null;
        }

    }
}
