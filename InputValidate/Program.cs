using System;

namespace InPutValidate
{
    class Program
    {
        static double Cong(double x, double y)
        {
            return x + y;
        }
        static double Tru(double x, double y)
        {
            return x - y;
        }
        static double Nhan(double x, double y)
        {
            return x * y;
        }
        static double Chia(double x, double y)
        {
            return x / y;
        }
        static double Avg(double x, double y, double z, double g)
        {
            return (x + y + z + g) / 4;
        }
        static void Main(string[] args)
        {
            Console.Write("Moi nhap vao so a:");
            double a = 0;
            double b = 0;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Nhap sai!Chi duoc nhap gia tri so");
                Console.Write("Moi ban nhap lai so a:");
            }
            Console.Write("Moi nhap vao so b:");

            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Nhap sai!Chi duoc nhap gia tri so");
                Console.Write("Moi ban nhap lai so b:");
            }
            Console.WriteLine("Tong hai so {0} va {1} la:{2}", a, b, Cong(a, b));
            Console.WriteLine("Hieu hai so {0} va {1} la:{2}", a, b, Tru(a, b));
            Console.Write("Tich hai so a va b la:");
            Console.WriteLine(Nhan(a, b));
            Console.Write("Thuong hai so a va b la:");
            Console.WriteLine(Chia(a, b));
            Console.Write("Moi nhap vao so c:");
            double c = 0;
            double d = 0;
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Nhap sai!Chi duoc nhap gia tri so");
                Console.Write("Moi ban nhap lai so c:");
            }
            Console.Write("Moi nhap vao so d:");

            while (!double.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Nhap sai!Chi duoc nhap gia tri so");
                Console.Write("Moi ban nhap lai so d:");
            }
            Console.Write("Gia tri trung binh cua 4 so la:");
            Console.Write(Avg(a, b, c, d));
            Console.ReadLine();
        }
    }
}
