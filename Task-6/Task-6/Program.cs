
using System.Collections;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            var arr1 = new int[] { 2, 34, 55, 23, 1, 4 };
            arr1 = Methods.Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            //2
            var range = new Range<int>(3, 9);
            Console.WriteLine(range.Length());
            Console.WriteLine(range.IsInRange(5));
            Console.WriteLine();
            Console.WriteLine();
            //3
            var arr2 = new ArrayList() { 1, 2, 3, 4, 5 };
            Methods.Reverse(arr2);
            foreach (var item in arr2)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();
            //4
            var arr3 = new List<int>() { 1, 2, 3, 4, 5 };
            var list = Methods.GetEven(arr3);
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();
            //5
            var fixedList = new FixedSizeList<int>(5);
            fixedList.Add(1);
            fixedList.Add(2);
            fixedList.Add(3);
            fixedList.Add(4);
            fixedList.Add(5);
            //fixedList.Add(6);
            Console.WriteLine(fixedList.Get(4));
            //Console.WriteLine(fixedList.Get(6));
            Console.WriteLine();
            Console.WriteLine();
            //6
            string s = "aabdcg";
            Console.WriteLine(Methods.NonRepeated(s));
        }
    }
}
