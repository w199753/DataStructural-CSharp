using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    class MyStack
    {
        private int[] m_array = new int[0];
        private int m_length = 0;
        public int Length
        {
            get { return m_length; }
        }
        public MyStack(int c)
        {
            m_array = new int[c];
            m_length = 0;
        }

        public void Push(int value)
        {
            m_array[m_length] = value;
            m_length++;
        }

        public void Pop()
        {
            m_length--;
            m_array[m_length] = 0;
        }

        public int Peek()
        {
            int len = m_length - 1;
            if (len >= 0)
                return m_array[len];
            return -1;
        }

        public void PrintStack()
        {
            for(int i=0;i<m_length;i++)
            {
                Console.WriteLine(m_array[i]);
            }
        }
    }
}
