using System;
using System.Collections.Generic;
using System.Text;

namespace homework13.models
{
    static class ExtentionMethods
    {
        public static bool isEven(this int a)
        {
            if (a%2==0)
             return true;
            return false;
        }
        public static bool isOdd(this int  a)
        {
            if (a % 1 == 0)
                return true;
            return false;
        }
        public static int[] GetValueIndexes(this int [] arr,int b)
        {
            int[] allarr = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==b)
                {
                    Array.Resize(ref allarr, allarr.Length + 1);
                    allarr[allarr.Length - 1] = i;
                }
            }
            return allarr;
        }
        public static bool IsDigit(string check)
        {
            bool checktest = false;
            foreach (var item in check)
            {
                if (char.IsDigit(item))
                {
                    checktest = true;
                    return checktest;
                }
            }
            return checktest;
        }
        public static int[] GetValueIndexesstring(this string a, char b)
        {
            int[] allarr = { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    Array.Resize(ref allarr, allarr.Length + 1);
                    allarr[allarr.Length - 1] = i;
                }
            }
            return allarr;
        }
    }
}
