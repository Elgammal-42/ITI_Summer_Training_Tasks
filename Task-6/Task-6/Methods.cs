using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public static class Methods
    {
        public static int[] Sort(int[] arr)
        {
            bool swapped = false;
            int len = arr.Length - 1;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }

                }
                if (!swapped)
                    return arr;
            }
            return arr;
        }
        public static void Reverse(ArrayList arr)
        {
            int len = arr.Count; // 1,2,3,4,5
            for (int i = 0; i < len / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[len - i - 1];
                arr[len - i - 1] = temp;
            }
        }
        public static List<int> GetEven(List<int> arr)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    list.Add(i);
            }
            return list;

        }
        public static int NonRepeated(string s)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dictionary.ContainsKey(c))
                    dictionary[c] = 0;
                dictionary[c]++;
            }
            for (int i = 0; i < dictionary.Count; i++)
            {
                char c = s[i];
                if (dictionary[c] == 1)
                    return i;
            }
            return -1;
        }
    }
}
