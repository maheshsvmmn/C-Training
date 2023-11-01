using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public static class NumerFunctions
    {
        public static int Subtraction(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static float Division(float x, float y)
        {
            return x / y;
        }
        public static int Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public static int Min(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static bool Even(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Odd(int x)
        {
            if (x % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Prime(int x)
        {
            int cnt = 0;
            for (int i = 2; i < x / 2; i++)
            {
                if (x % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}