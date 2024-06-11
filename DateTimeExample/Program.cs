using System;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thời điểm hiện tại.
            DateTime aDateTime = DateTime.Now;

            // Thời điểm cần count down.
            DateTime endTime = new DateTime(2022, 04, 10, 23, 59, 0);

            // Khoảng thời gian từ hiện tại đến thời điểm cần đếm.
            TimeSpan interval = endTime.Subtract(aDateTime);

            // Nếu thời gian countdown ở quá khứ thì trả về 00 (check không cho số đếm về âm)
            if (aDateTime > endTime)
                interval = new TimeSpan();

            Console.WriteLine("Interval from Now to EndTime: " + interval);
            Console.WriteLine("Days: " + interval.Days);
            Console.WriteLine("Hours: " + interval.Hours);
            Console.WriteLine("Minutes: " + interval.Minutes);
            Console.WriteLine("Seconds: " + interval.Seconds);
            Console.ReadLine();
        }
    }
}
