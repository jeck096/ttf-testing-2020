using System;

namespace LeapYear
{
    public static class LeapYears
    {
        public static bool IsLeapYear(int year) {
            if (year % 4 == 0) return true;
            return false;
        }
    }
}
