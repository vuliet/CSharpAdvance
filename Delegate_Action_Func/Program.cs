using System;

// delegate (Type) biến = phương thức
// delegate có thể nhận giá trị null
// giống khai báo phương thức nhưng ko có phần thân
// có thể tham chiếu một lúc đến nhiều method
namespace Delegate_Action_Func
{
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"Tong là {kq}");
        }

        static int Hieu(int a, int b) => a - b;

        static void Main(string[] args)
        {
            ShowLog log = null; // lỗi nếu = null
            //log += Info;
            //log += Warning;
            //log?.Invoke("Đây là demo delegate"); // or log("Đây là demo delegate")

            // Action, Func: delegate ~ generic
            //Action action; // ~ delegate void
            //Action<string, int> action1; // ~ delegate void có tham số(string, int)
            //Action<string> action2; // ~ delegate void có tham số(string)
            //action2 = Warning;
            //action2 += Info;
            //action2?.Invoke("Đây là demo Action");

            // Func: tham số cuối cùng là kiểu trả về
            //Func<int> f1; // ~ delegate int không có tham số
            //Func<string, double, string> f2; // ~ delegate int có tham số (string, double)

            Func<int, int, int> Cal = null;

            Cal += Hieu;
            Console.WriteLine($"Hieu la: {Cal?.Invoke(5, 10)}");

            Tong(4, 5, Warning);
            Console.ReadLine();
        }
    }
}
