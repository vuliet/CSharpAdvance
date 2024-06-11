using System;

namespace BangNhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int resultAll;
            int result;
            Console.WriteLine("\t\t\tBang cuu chuong:");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Hien thi bang nhan:{0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    resultAll = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, resultAll);
                }
            }

            Console.Write("Nhap 1 so bat ky:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Hien thi bang nhan:{0}", x);

            for (int i = 1; i < 10; i++)
            {
                result = x * i;
                Console.WriteLine("{0} x {1} = {2}", x, i, result);
            }

            Console.ReadKey();
        }
    }
}
