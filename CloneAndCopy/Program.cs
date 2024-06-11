using System;

namespace CloneAndCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[] { 1,2,3,"t"};
            object[] arrCopy = arr;
            object[] arrClone = (object[])arr.Clone();
            arrClone[0] = "abc";
            arrCopy[0] = "h";
            Console.WriteLine("arrOrigin[0]: {0}", arr[0]);
            Console.WriteLine("arrCopy[0]: {0}", arrCopy[0]);
            Console.WriteLine("arrClone[0]: {0}", arrClone[0]);
            Console.ReadLine();
        }
    }
}
