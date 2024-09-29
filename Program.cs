using System;
using static EnumerationTask.model.Enum;

namespace EnumerationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var month  in Enum.GetValues(typeof(MonthsOfYear)))
            {
                Console.WriteLine($"Value for {month} :{(int)month}");
            }

            Cricket cricket = new Cricket();
            //Cricket cricket = Cricket.Batsman;

            switch (cricket)
            {
                case Cricket.Batsman:
                    Console.WriteLine("I am a Batsman");
                    break;
                case Cricket.Bowler:
                    Console.WriteLine("I am a Bowler");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            DaysInWeek daysInWeek = new DaysInWeek();
            Console.WriteLine(daysInWeek == DaysInWeek.Sunday ? "It is a Weekend" : "It is a Weekday");
        }
    }
}
