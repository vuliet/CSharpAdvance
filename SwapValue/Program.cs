using System;

namespace SwapValue
{
    class Program
    {
        static void SwapUsePlusAndSub(ref double x, ref double y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
        static void SwapUseMultiplicationAndDivision(ref double x, ref double y)
        {
            x = x * y;
            y = x / y;
            x = x / y;
        }
        static void SwapUseTempVariable(ref double x, ref double y)
        {
            double z;
            z = x;
            x = y;
            y = z;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ban vua nhap a=");
            Console.WriteLine(a);
            Console.Write("Ban vua nhap b=");
            Console.WriteLine(b);
            SwapUseTempVariable(ref a, ref b);
            Console.WriteLine("So a va b vua duoc doi gia tri la:");
            Console.WriteLine("a=" + a + " & " + "b=" + b);
            Console.ReadLine();
        }
    }
}
