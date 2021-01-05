using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    public static class Extension
    {
        public static string CustomReplace(this string str,char oldChar,char newChar)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char letter in str)
            {
                if(letter== oldChar)
                {
                    builder.Append(newChar);
                }
                else
                {
                    builder.Append(letter);
                }
            }
            return builder.ToString();
        }

        public static int GetCount(this int[] arr,int number) //arr -> 10,20,30,10  number->10
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item == number) count++;
            }
            return count;
        }

        public static int[] GetSameValue(this int[] arr1,int[] arr2)
        {
            int[] result = new int[0];
            foreach (int i in arr1) //{ 1, 2, 3, 4, 5, 6 }
            {
                foreach (int j in arr2) //{ 2, 4, 6, 8, 10 }
                {
                    if (i == j)
                    {
                        Array.Resize(ref result, result.Length+1); //3
                        result[result.Length-1] = i; //result[2]=i
                        break;
                    }
                }
            }
            return result;
        }
    }
}
