using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [StructLayout(LayoutKind.Sequential,CharSet =CharSet.Ansi,Pack =4)]
    struct Test
    {
        int a;
       
        double c; short b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Fun_Tree();
            //Fun_List();
            //Fun_Stack();
            //Fun_List();
            //Fun_DoubleList();
            //Fun_MaxHeap();
            //Fun_HashTable();
            Fun_OneWayCircularLinkedList();


            /*Test t = new Test();
            int i = 1;
            int size = Marshal.SizeOf(t);
            Console.WriteLine(size);*/
        }

        /// <summary>
        /// 串
        /// </summary>
        public static void Fun_Str()
        {
            //char[] aaa = new char[10] {"0123456789" };
            Str a = new Str("123");
            Str b = new Str("456");
            Str c = a + b;
            Str e = c + a;

            c.PrintStr();
            e.PrintStr();

            //Console.WriteLine(c);
        }

        /*
        1
        2
        3
        0
        0
        0
        4
        5
        0
        0
        6
        0
        0
        */
        /// <summary>
        /// 二叉树
        /// </summary>
        public static void Fun_Tree()
        {
            Tree a = new Tree();
            //Tree.TreeNode node = new Tree.TreeNode();
            Tree.TreeNode node = a.InitTree();
            a.PrintTreeFirst(node);
            Console.WriteLine("print tree layer");
            a.PrintTreeLayer(node);
            Console.WriteLine(a.GetTreeDepth(node));
            Console.WriteLine(a.GetChildCount(node));
        }

        /// <summary>
        /// 单向链表
        /// </summary>
        public static void Fun_List()
        {
            MyLinkedList list = new MyLinkedList();
            MyLinkedList.MyLinkedListNode node = new MyLinkedList.MyLinkedListNode();
            list.CreateList(5, node);

            list.PrintList(node);

            MyLinkedList.MyLinkedListNode nn = list.FindNodeAsPosition(node, 2);
            Console.WriteLine(nn.data);

            Console.WriteLine("please insert a new node");
            int data = int.Parse(Console.ReadLine());

            //list.DeleteElementAsPosition(node, 2);
            list.Clear(node);
            //list.AddElement(node, 2, data);
            list.PrintList(node);
        }

        /// <summary>
        /// 双向链表
        /// </summary>
        public static void Fun_DoubleList()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            DoubleLinkedList.LinkedListNode node = new DoubleLinkedList.LinkedListNode();
            list.CreateList(5, node);
            Console.WriteLine(list.Length);
            list.PrintList(node);
            list.ReversePrintList(node);
            /*list.Insert(node, 0, 100);
            list.Insert(node, 0, 1000);*/

            /*list.Clear(node);
            list.PrintList(node);
            list.ReversePrintList(node);*/
            list.DeleteValueAsValue(node, 1);
            list.DeleteValueAsValue(node, 5);
            list.PrintList(node);
            list.ReversePrintList(node);
            /*list.DeleteValueAsPosition(node, 3);
            list.PrintList(node);
            list.ReversePrintList(node);*/
        }

        /// <summary>
        /// 栈
        /// </summary>
        public static void Fun_Stack()
        {
            MyStack stack = new MyStack(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Push(4);
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.PrintStack();
        }

        public static void Fun_MaxHeap()
        {
            MaxHeap heap = new MaxHeap();
            for (int i = 0; i < 5; i++)
            {
                heap.Push(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(heap.Pop());
            }
        }

        public static void Fun_HashTable()
        {
            MyHashTable.OpenAddressing open = new MyHashTable.OpenAddressing(10);
            open.CreateTable(5);
            open.Print();
            Console.WriteLine(open.GetElement(10));
        }

        /// <summary>
        /// 单向循环链表测试
        /// </summary>
        public static void Fun_OneWayCircularLinkedList()
        {
            OneWayCircularLinkedList.LinkedListNode node = new OneWayCircularLinkedList.LinkedListNode();
            OneWayCircularLinkedList list = new OneWayCircularLinkedList();
            list.CreatList(5, node);
            list.Add_Back(node, 100);
            list.Add_Back(node, 1000);
            list.PrintList(node);
            //Console.WriteLine(list.FindNodeAsValue(node, 2).val);

            //list.PrintList(node);
            list.PrintListAtPos(node, 3);
        }

    }
}
