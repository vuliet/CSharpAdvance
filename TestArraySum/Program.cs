using System;
using System.Collections.Generic;
using System.Linq;

namespace TestArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArr = new int[] { 1, 3, 4, 7, 11 };
            int sum = 0;
            var arr2 = new List<int>();
            for (int i = 0; i < intArr.Length; i++)
            {
                if (i + 2 < intArr.Length)
                {
                    sum = intArr[i] + intArr[i + 1];
                    if (sum == intArr[i + 2])
                        arr2.Add(intArr[i + 2]);
                    sum = 0;
                }
            }
            if (arr2 != null && arr2.Any())
            {
                var result = string.Join(",", arr2.ToArray());
                Console.WriteLine("Cac so co 2 so truoc cong lai bang la: {0}", result);
            }
               
            Console.ReadLine();
        }
    }
}
