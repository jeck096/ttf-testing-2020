using System;

namespace LeapYear
{
    public static class LeapYears
    {
        public static bool IsLeapYear(int year) {

            if (year > 0 && year % 4 == 0 && (year >= 1581 && (year % 100 != 0 || year % 400 == 0) || year <= 1581)) return true;
            else if (year == 0) throw new ArgumentException();
            return false;
        }
    }
}
