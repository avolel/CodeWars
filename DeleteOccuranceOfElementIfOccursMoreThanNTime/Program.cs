using System;
using System.Collections.Generic;
using System.Linq;

namespace DeleteOccuranceOfElementIfOccursMoreThanNTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 37, 20, 21 };
            var result = DeleteNth(arr, 1);
            Console.WriteLine($"{string.Join(",", result)}");
        }

        private static int[] DeleteNth(int[] arr, int x)
        {
            List<int> arrLst = new List<int>(arr);
            for (int i = arrLst.Count() - 1; i >= 0; i--)
            {
                if (arrLst.Where(a => a == arrLst[i]).Count() > x)
                {
                    arrLst.RemoveAt(i);
                }
            }

            return arrLst.ToArray();
        }
    }
}
