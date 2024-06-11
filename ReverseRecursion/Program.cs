using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseRecursion
{
    class Program
    {
        public static int Reverse(int n, int rev)
        {
            if (n == 0)
                return rev;
            else
            {
                rev = rev * 10 + n % 10;
                return Reverse(n / 10, rev);
            }
        }

        static void Main(string[] args)
        {
            int a = 12345;
            int b = 0;
            var result = Reverse(a,b);
            //string strResult = "";
            //var convertIntToListInt = a.ToString().ToList();

            //// loop dao nguoc
            //for (int i = convertIntToListInt.Count - 1; i >= 0; i--) 
            //{
            //    strResult += convertIntToListInt[i];
            //}
            //Console.WriteLine(strResult);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
