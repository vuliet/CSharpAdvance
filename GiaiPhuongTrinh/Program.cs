using System;

namespace GiaiPhuongTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            Console.WriteLine("x = y² - 2y +1, y[1, 5]");
            Console.Write("Moi nhap gia tri y:");
            z = int.Parse(Console.ReadLine());

            while (z > 5)
            {
                Console.WriteLine("Phai nhap gia tri y nho hon 5");
                Console.Write("Moi nhap lai gia tri y:");
                z = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("x = y² - 2y +1, y[{0}, 5]", z);
            for (int y = z; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(
                    "y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                    y, x);
            }


            Console.ReadKey();
        }
    }
}
