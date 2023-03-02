using System;
using System.Collections.Generic;

namespace QuilgoAssesment
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] RemoveDuplicate(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    continue;

                dict[arr[i]] = arr[i];
            }

            var length = dict.Keys.Count;
            var result = new int[length];
            int count = 0;

            foreach (var item in dict.Keys)
            {
                result[count] = item;
                count++;
            }

            return result;
        }
    }
}
