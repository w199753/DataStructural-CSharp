using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructural
{
    public class Str
    {
        private char[] str;
        private int len;

        public int Length
        {
            get { return len; }
        }
        public Str(char[] s)
        {
            len = s.Length;
            str = new char[len];
            for (int i = 0; i < len; i++)
            {
                str[i] = s[i];
            }
        }
        public Str(string s)
        {
            len = s.Length;
            str = new char[len];
            for (int i = 0; i < len; i++)
            {
                str[i] = s[i];
            }
            String a = "aaaa";

        }
        public char this[int index]
        {
            get { return str[index]; }
        }

        public void PrintStr()
        {
            string newStr = string.Empty;
            for (int i = 0; i < len; i++)
            {
                newStr += str[i];
            }

            Console.WriteLine(newStr);
        }

        public static Str operator +(Str s1, Str s2)
        {
            char[] aa = new char[s1.len + s2.len];
            int i = 0;
            for (i = 0; i < s1.len; i++)
            {
                aa[i] = s1[i];
            }
            
            for (int z=0 ;z< s2.len; i++,z++)
            {
                aa[i] = s2[z];
            }
            return new Str(aa);
        }


    }
}
