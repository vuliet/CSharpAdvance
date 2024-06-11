using System;

namespace RandomChance
{
    public class BoxType
    {
        public int Id { get; set; }
        public int FusionRateSuccess { get; set; }

        public int Type { get; set; }

        public Decimal Price { get; set; }

    }

    public enum BoxTypeEnum
    {
        COMMON,
        HIGHEND,
        SUPER
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var rd = new Random();

            List<BoxType> listBoxType = new List<BoxType>()
            {
                new BoxType()
                {
                    Id = 1,
                    FusionRateSuccess  = 51,
                    Price = 10000,
                    Type = (int)BoxTypeEnum.COMMON,
                },
                new BoxType()
                {
                    Id = 2,
                    FusionRateSuccess  = 32,
                    Price = 20000,
                    Type = (int)BoxTypeEnum.HIGHEND
                },
                new BoxType()
                {
                    Id = 3,
                    FusionRateSuccess  = 14,
                    Price = 30000,
                    Type = (int)BoxTypeEnum.SUPER
                }
            };

            // Generate phần trăm
            var percent = rd.Next(1, 100);
            if (percent < 40) // 40% 
            {
                // do something
            }
            else if (percent < 75) // 35%
            {
                // do something
            }
            // do something 25%              

            for (int i = 0; i < listBoxType.Count; i++)
            {
                var idx = rd.Next(1, 100);
                var boxTypeName = Enum.GetName(typeof(BoxTypeEnum), listBoxType[i].Type);
                if (idx <= listBoxType[i].FusionRateSuccess)
                    Console.WriteLine("You update {0} success with: {1}%", boxTypeName, idx);
                else
                    Console.WriteLine("You update {0} fail with: {1}%", boxTypeName, idx);
            }
            Console.ReadLine();
        }
    }
}