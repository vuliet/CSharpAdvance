using System;

namespace EpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Parse
            int a = int.Parse("123");
            float b = float.Parse("20.5");
            bool c = bool.Parse("true");
            //int a1 = int.Parse("Hello"); //sai định dạng, FormatException 
            //byte b1 = byte.Parse("10000000000"); //quá giới hạn, OverflowException 
            //bool c1 = bool.Parse(null); //tham số là null, ArgumentNullException

            // 2.TryParse
            int.TryParse("hello", out int a2);
            bool.TryParse("", out bool b2);

            // 3.Convert
            //a3 = Convert.ToBoolean("hello"); //FormatException
            //int b3 = Convert.ToInt32("123456787654"); //OverflowException
            //d3 = Convert.ToDouble(null); //trả về giá trị mặc định

            // 4.Casting
            int a4 = 100;
            float b4 = a4; //chuyển đổi ngầm định, b = 100
            int c4 = (int)b4; //chuyển đổi rõ ràng, c = 100

            //string a5 = "1234";
            //int b5 = (int)a5; //lỗi, không thể ép kiểu chuỗi sang kiểu số
            //bool c5 = true;
            //double d5 = (double)c5; //lỗi, không thể ép kiểu bool sang kiểu double

            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine("c = {0}", c);
            //Console.WriteLine("a2 = {0}", a2);
            //Console.WriteLine("b2 = {0}", b2);
            //Console.WriteLine("a4 = {0}", a4);
            //Console.WriteLine("b4 = {0}", b4);
            //Console.WriteLine("c4 = {0}", c4);


            int g = 2;
            int h = 1;
            double total = g + h;
            double result = total / 2;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
