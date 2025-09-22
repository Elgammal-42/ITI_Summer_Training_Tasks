using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public static class ExtensionMathods
    {
        public static int CountWords(this string value)
        {
            var words = value.Split(' ');
            return words.Length;
        }
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
        public static int Age(this DateTime value)
        {
            int age = DateTime.Now.Year - value.Year;
            return age;
        }
        public static string Reversed(this string value)
        {
            int len = value.Length;
            string s = "";
            for (int i = len - 1; i >= 0; i--)
            {
                char c = value[i];
                s = s + c;
            }
            return s;
        }
    }
}
