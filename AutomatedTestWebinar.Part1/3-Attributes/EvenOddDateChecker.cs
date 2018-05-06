using System;

namespace AutomatedTestWebinar.Part1
{
    public class EvenOddDateChecker
    {
        public bool DayIsEven(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Monday ||
                date.DayOfWeek == DayOfWeek.Wednesday ||
                date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }

            return false;
        }
    }
}
