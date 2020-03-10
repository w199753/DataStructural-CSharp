using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    /// <summary>
    /// 散列表，散列函数都使用除留取余法
    /// </summary>
    abstract public class MyHashTable
    {
        //f(k)=k mod p(p<=m)  m(表长)   p(<=m的最大质数)

        /// <summary>
        /// 解决冲突使用开放定址法
        /// </summary>
        public class OpenAddressing
        {
            int[] table;
            int table_length;
            public int count=0;
            int p;

            public OpenAddressing(int m)
            {
                table_length = m;
                table = new int[m];
            }

            public void CreateTable(int c)
            {
                if (c > table_length) return;

                p = GetP();

                for(int i=0;i<c;i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    int key = GetIndex(x);
                    table[key] = x;
                    count++;
                }
            }
            public void Print()
            {
                Console.WriteLine("element is:");
                for(int i=0;i<table_length;i++)
                {
                    Console.WriteLine(table[i]);
                }
            }
            public int GetIndex(int x)
            {
                int key=x % p;
                while (table[key] != 0)//出现冲突
                {
                    key = ++key % table_length;
                }
                //table[key] = x;
                return key;   
            }

            public int GetElement(int x)
            {
                int key = x % p;
                int compare = 0;
                while (table[key]!=x&&++compare<count)
                {
                    key = ++key % table_length;
                }
                Console.WriteLine(compare+" "+count);
                if (compare == count) return -1;
                else return key;
            }

            public int GetP()
            {
                int tmp = table_length;
                while(tmp-->0)
                {
                    if(IsPrime(tmp))
                    {
                        return tmp;
                    }
                }
                return table_length;
            }
            private bool IsPrime(int x)
            {
                if (x <= 3)
                    return x > 1;
                if (x % 6 != 1 && x % 6 != 5) return false;

                int sqrt = (int)Math.Sqrt(x);
                for (int i = 5; i <= sqrt; i += 6)
                {
                    if (x % i == 0 || x % (i + 2) == 0)
                        return false;
                }
                return true;
            }
        }

        /// <summary>
        /// 解决冲突使用链地址法
        /// </summary>
        public class ChainingAddressing
        {

        }
    }
}
