using System;

// từ khóa override chỉ dùng được khi method cần ghi đè ở lớp cha là lớp virtual hoặc abstract
namespace OverrideOverLoad
{
    class Program : OverrideOverLoadExample
    {
        public override string FixKeyWord(string keyword)
        {
            return string.Format("{0} overrided", keyword);
        }

        static void Main(string[] args)
        {
            string test = "Thai";
            Program objOverride = new Program();
            test = objOverride.FixKeyWord(test);
            Console.WriteLine(test);

            var test2 = FixKeyWord(test, false);
            Console.WriteLine(test2);
            Console.ReadLine();
        }
    }
}
