using System;

namespace ValidateNumber
{
    class Program
    {
        static bool ValidateNumber(int a)
        {
            bool check;
            if (a % 2 == 0)
                check = true;
            else
                check = false;
            return check;
        }
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap gia tri a : ");
            int a = int.Parse(Console.ReadLine());
            if (ValidateNumber(a) == false)
                Console.WriteLine("So ban vua nhap la so le");
            else
                Console.WriteLine("So ban vua nhap la so chan");
            Console.ReadKey();
        }
    }
}
