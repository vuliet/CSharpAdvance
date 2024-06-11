using System;

namespace DateTimeExample
{
    class DateTimeTutorial
    {
        public static void Main(string[] args)
        {
            // Thời điểm hiện tại.
            DateTime aDateTime = DateTime.Now;

            // Thời điểm cần count down 
            DateTime y2K = new DateTime(2020, 29, 02, 23, 59, 0);

            // Khoảng thời gian từ năm 2000 tới nay.
            TimeSpan interval = aDateTime.Subtract(y2K);


            Console.WriteLine("Interval from Y2K to Now: " + interval);

            Console.WriteLine("Days: " + interval.Days);
            Console.WriteLine("Hours: " + interval.Hours);
            Console.WriteLine("Minutes: " + interval.Minutes);
            Console.WriteLine("Seconds: " + interval.Seconds);


            Console.Read();
        }
    }
}
