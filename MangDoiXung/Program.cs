using System;

namespace MangDoiXung
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInt = new string[] { "t", "a", "m", "m", "a", "t"};
            int arrLength = arrInt.Length;
            int count = 0;
            for (int i = 0; i < arrLength / 2; i++)
            {
                if (arrInt[i] != arrInt[arrLength - 1 - i])
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
                Console.WriteLine("Mang khong doi xung");
            else
                Console.WriteLine("Mang doi xung");
            Console.ReadLine();
        }
    }
}
