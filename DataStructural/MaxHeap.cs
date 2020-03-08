using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    /// <summary>
    /// 大根堆。小根堆实现方法相同
    /// </summary>
    public class MaxHeap
    {
        int[] heap = new int[1000];
        int heapSize = 0;

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            //思路：每次先将新元素放到最后，在进行调整。从下向上，比较父元素
            heap[++heapSize] = x;
            int now = heapSize, nxt = 0;

            while (now > 1)
            {
                nxt = now / 2;
                if (heap[now] <= heap[nxt]) break;
                Swap(ref heap[now], ref heap[nxt]);
                now = nxt;
            }
        }

        /// <summary>
        /// 删除元素并返回最大值
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            //思路：把顶的元素先存到零时变量中，在将堆末尾的元素覆盖到顶元素完成删除。之后再由顶	
            //      向下进行调整。上一个元素比较子两个元素，其中要比较两个子元素的大小，选择最大/	小的与上边的元素进行交换
            int res = heap[1];
            int now = 1, nxt = 0;
            heap[1] = heap[heapSize--];

            while (now * 2 <= heapSize)
            {
                nxt = now * 2;
                if (heap[nxt + 1] > heap[nxt] && nxt + 1 <= heapSize) nxt++;
                if (heap[nxt] <= heap[now])
                {
                    return res;
                }
                Swap(ref heap[nxt], ref heap[now]);
                now = nxt;
            }
            return res;
        }

        public void Clear()
        {
            heap = new int[1000];
            heapSize = 0;
        }
        private void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
